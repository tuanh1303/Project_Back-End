using ShopDT_Back_End.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopDT_Back_End.Controllers
{
    public class HomeCartController : Controller
    {
        private string CartSession = "CartSession";
        // GET: HomeCart
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult HeaderCart()
        {
            var cart = Session[CartSession];
            var list = new List<GHItem>();
            if (cart != null)
            {
                list = (List<GHItem>)cart;
            }
            return PartialView(list);
        }
    }
}