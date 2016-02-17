using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCShoppingCart.Models;
using PagedList;
using PagedList.Mvc;

namespace ASPMVCShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        private DemoDBEntities de = new DemoDBEntities();

        public ActionResult Index(int? page)
        {

            //ViewBag.ListProducts = de.tblProducts.ToList();
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)

            var onePageOfProducts = de.tblProducts.OrderBy(x => x.Id).ToPagedList(pageNumber, 5); // will only contain 25 products max because of the pageSize
            ViewBag.ListProducts = onePageOfProducts;

            return View();
            //return View(ViewBag.ListProducts);
        }

    }
}
