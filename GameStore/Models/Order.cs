using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        //[Required(ErrorMessage = "Пожалуйста введите свое имя")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Пожалуйста введите свой телефон")]
        public string Phone { get; set; }

        //[Required(ErrorMessage = "Вы должны указать отделение новой почты")]
        public string Address { get; set; }
        

        //[Required(ErrorMessage = "Пожалуйста укажите город, куда нужно доставить заказ")]
        public string City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public Game Game { get; set; }
        public int Quantity { get; set; }
    }
}