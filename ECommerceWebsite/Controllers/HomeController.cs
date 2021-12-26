using Newtonsoft.Json;
using ECommerceWebsite.Dal;
using ECommerceWebsite.Models;
using ECommerceWebsite.Models.Home;
using ECommerceWebsite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ECommerceWebsite.Controllers
{
	public class HomeController : Controller
	{
		MaharajaEDBEntities ctx = new MaharajaEDBEntities();

		public ActionResult Index(string search, int? page)
		{
			HomeIndexViewModel model = new HomeIndexViewModel();
			return View(model.CreateModel(search, 4, page));
		}


		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}