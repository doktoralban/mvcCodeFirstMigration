using mvcCodeFirstTest.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace mvcCodeFirstTest.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{

			clsAd.RunMigration();


			return View();
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