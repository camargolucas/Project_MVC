using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_MVC.ProductService;

namespace Project_MVC.Controllers
{
    public class ProductController : Controller
    {
        readonly ProductServiceClient _wcf = new ProductServiceClient();
        public ActionResult Index()
        {
            List<TB_PRODUCT> products = _wcf.getProducts().ToList();
            return View(products);
        }
    }
}