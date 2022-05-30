using Microsoft.AspNetCore.Mvc;
using System;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.PageTitle ="Home";
        ViewBag.Tab="home";
        ViewBag.DateTime= DateTime.Now;
        return View();
      }

    }
}