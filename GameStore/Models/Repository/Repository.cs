using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameStore.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }

        // Чтение данных из таблицы Orders
        public IEnumerable<Order> Orders
        {
            get
            {
                return context.Orders
                    .Include(o => o.OrderLines.Select(ol => ol.Game));
            }
        }
        public IEnumerable<Comment> Comments
        {
            get { return context.Comments; }
        }

        public void addComment(Comment comment)
        {
            if (comment.id == 0)
            {
                comment = context.Comments.Add(comment);
            }
            else
            {
                Comment dbComment = context.Comments.Find(comment.id);
                if (dbComment != null)
                {
                    dbComment.login = comment.login;
                    dbComment.text = comment.text;
                }
            }
            
            context.SaveChanges();
        }

        public void deleteComment(Comment comment)
        {
            context.Comments.Remove(comment);
            context.SaveChanges();
        }

        public IEnumerable<User> Users {
            get { return context.Users; }
        }

        public void SaveGame(Game game)
        {
            if (game.GameId == 0)
            {
                game = context.Games.Add(game);
            }
            else
            {
                Game dbGame = context.Games.Find(game.GameId);
                if (dbGame != null)
                {
                    dbGame.Name = game.Name;
                    dbGame.Description = game.Description;
                    dbGame.Price = game.Price;
                    dbGame.Category = game.Category;
                }
            }
            context.SaveChanges();
        }

        public void DeleteGame(Game game)
        {
            IEnumerable<Order> orders = context.Orders
                .Include(o => o.OrderLines.Select(ol => ol.Game))
                .Where(o => o.OrderLines
                    .Count(ol => ol.Game.GameId == game.GameId) > 0)
                .ToArray();

            foreach (Order order in orders)
            {
                context.Orders.Remove(order);
            }
            context.Games.Remove(game);
            context.SaveChanges();
        }

        // Сохранить данные заказа в базе данных
        public void SaveOrder(Order order)
        {
            if (order.OrderId == 0)
            {
                order = context.Orders.Add(order);

                foreach (OrderLine line in order.OrderLines)
                {
                    context.Entry(line.Game).State
                        = EntityState.Modified;
                }

            }
            else
            {
                Order dbOrder = context.Orders.Find(order.OrderId);
                if (dbOrder != null)
                {
                    dbOrder.Name = order.Name;
                    dbOrder.Phone = order.Phone;
                    dbOrder.Address = order.Address;
                    dbOrder.City = order.City;
                    dbOrder.GiftWrap = order.GiftWrap;
                    dbOrder.Dispatched = order.Dispatched;
                }
            }
            context.SaveChanges();
        }
    }
}