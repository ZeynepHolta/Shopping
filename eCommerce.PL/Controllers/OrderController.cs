using eCommerce.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.PL.Controllers
{
    public class OrderController : Controller
    {
        ShoppingDbContext _db;

        public OrderController()
        {
            _db = new ShoppingDbContext();
        }

        public ActionResult List()
        {
            List<Order> orderList;
            orderList = _db.Orders.ToList();

            return View(orderList);
        }

    }
}