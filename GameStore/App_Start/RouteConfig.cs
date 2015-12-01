﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace GameStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "list/{category}/{page}",
                                        "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");
            routes.MapPageRoute("comments", "comments", "~/Pages/Comments.aspx");
            routes.MapPageRoute("authentication", "authentication", "~/Pages/Authentication.aspx");

            routes.MapPageRoute("cart", "cart", "~/Pages/CartView.aspx");
            routes.MapPageRoute("checkout", "checkout", "~/Pages/Checkout.aspx");

            // Новые маршруты для административных страниц
            routes.MapPageRoute("admin_orders", "admin/orders", "~/Pages/Admin/Orders.aspx");
            routes.MapPageRoute("admin_games", "admin/games", "~/Pages/Admin/Games.aspx");
            routes.MapPageRoute("admin_comments", "admin/comments", "~/Pages/Admin/Comments.aspx");
        }
    }
}