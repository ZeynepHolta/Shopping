using eCommerce.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.PL.Controllers
{
    public class ShoppingCardController : Controller
    {
        ShoppingDbContext _db;

        public ShoppingCardController()
        {
            _db = new ShoppingDbContext();
        }

        public ActionResult List()
        {
            List<ShoppingCard> shoppingCardList;
            shoppingCardList = _db.ShoppingCards.ToList();

            return View(shoppingCardList);
        }

        public ActionResult Create()
        {
            BindOrderToDDL();
            return View();
        }

        [HttpPost]
        public ActionResult Create(ShoppingCard shoppingCard)
        {
            _db.ShoppingCards.Add(shoppingCard);

            try
            {
                int result = _db.SaveChanges();
                if (result > 0)
                {
                    return RedirectToAction("List");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                BindOrderToDDL();
                ViewBag.IsSuccess = false;
                return View();
            }
        }

        public ActionResult Update(int? shoppingCardID)
        {
            if (!shoppingCardID.HasValue)
            {
                return RedirectToAction("List");
            }

            ShoppingCard shoppingCard = _db.ShoppingCards.Where(a => a.ShoppingCardId == shoppingCardID).SingleOrDefault();
            if (shoppingCard == null)
            {
                return RedirectToAction("List");
            }
            BindOrderToDDL();
            return View(shoppingCard);
        }

        [HttpPost]
        public ActionResult Update(ShoppingCard shoppingCard)
        {
            _db.Entry(shoppingCard).State = System.Data.Entity.EntityState.Modified;

            try
            {
                int result = _db.SaveChanges();
                if (result > 0)
                {
                    return RedirectToAction("List");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                BindOrderToDDL();
                ViewBag.IsSuccess = false;
                return View(shoppingCard);
            }
        }

        public ActionResult Delete(int? shoppingCardID)
        {
            if (!shoppingCardID.HasValue)
            {
                return RedirectToAction("List");
            }

            ShoppingCard shoppingCard = _db.ShoppingCards.Where(a => a.ShoppingCardId == shoppingCardID).SingleOrDefault();
            if (shoppingCard == null)
            {
                return RedirectToAction("List");
            }

            return View(shoppingCard);
        }

        [HttpPost]
        public ActionResult Delete(ShoppingCard shoppingCard)
        {
            ShoppingCard deleted = _db.ShoppingCards.Find(shoppingCard.ShoppingCardId);

            _db.Set<ShoppingCard>().Remove(deleted);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        private void BindOrderToDDL()
        {
            List<SelectListItem> order = new List<SelectListItem>();

            foreach (Order item in _db.Orders)
            {
                order.Add(new SelectListItem()
                {
                    Value = item.OrderId.ToString()
                });
            }

            ViewBag.Orders = order;
        }
    }
}