using eCommerce.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.PL.Controllers
{
    public class ProductController : Controller
    {
        ShoppingDbContext _db;

        public ProductController()
        {
            _db = new ShoppingDbContext();
        }

        public ActionResult List()
        {
            List<Product> productList;
            productList = _db.Products.ToList();

            return View(productList);
        }

        public ActionResult Create()
        {
            BindShoppingCardToDDL();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            _db.Products.Add(product);

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
                BindShoppingCardToDDL();
                ViewBag.IsSuccess = false;
                return View();
            }
        }

        public ActionResult Update(int? productID)
        {
            if (!productID.HasValue)
            {
                return RedirectToAction("List");
            }

            Product product = _db.Products.Where(a => a.ProductId == productID).SingleOrDefault();
            if (product == null)
            {
                return RedirectToAction("List");
            }
            BindShoppingCardToDDL();
            return View(product);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            _db.Entry(product).State = System.Data.Entity.EntityState.Modified;

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
                BindShoppingCardToDDL();
                ViewBag.IsSuccess = false;
                return View(product);
            }
        }

        public ActionResult Delete(int? productID)
        {
            if (!productID.HasValue)
            {
                return RedirectToAction("List");
            }

            Product product = _db.Products.Where(a => a.ProductId == productID).SingleOrDefault();
            if (product == null)
            {
                return RedirectToAction("List");
            }

            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            Product deleted = _db.Products.Find(product.ProductId);

            _db.Set<Product>().Remove(deleted);
            _db.SaveChanges();
            return RedirectToAction("List");
        }

        private void BindShoppingCardToDDL()
        {
            List<SelectListItem> shoppingCard = new List<SelectListItem>();

            foreach (ShoppingCard item in _db.ShoppingCards)
            {
                shoppingCard.Add(new SelectListItem()
                {
                    Value = item.ShoppingCardId.ToString()
                });
            }

            ViewBag.ShoppingCards = shoppingCard;
        }
    }
}