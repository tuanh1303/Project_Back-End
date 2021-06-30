using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopDT_Back_End
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Shop", action = "Index", id = UrlParameter.Optional }
            );         

            routes.MapRoute(
                name: "GioHang",
                url: "gio-hang",
                defaults: new { controller = "GioHang", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Payment",
            url: "thanh-toan",
            defaults: new { controller = "GioHang", action = "Payment", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Payment Success",
            url: "hoan-thanh",
            defaults: new { controller = "GioHang", action = "Success", id = UrlParameter.Optional }
        );

        }
    }
}
