using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TamagotchiApp.Models;

namespace TamagotchiApp.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/tamagotchi/create")]
    public ActionResult CreateNew()
    {
      Tamagotchi myTamagotchi = new Tamagotchi(Request.Form["name"]);
      myTamagotchi.Save();
      return RedirectToAction("Create");
    }

    [HttpGet("/tamagotchi/create")]
    public ActionResult Create()
    {
      Tamagotchi foundTama = Tamagotchi.GetTama();
      return View(foundTama);
    }

    [HttpPost("/tamagotchi/food")]
    public ActionResult Food()
    {
      Tamagotchi foundTama = Tamagotchi.GetTama();
      foundTama.GiveFood();
      return RedirectToAction("Create");
    }

    [HttpPost("/tamagotchi/death")]
    public ActionResult Death()
    {
      Tamagotchi foundTama = Tamagotchi.GetTama();
      foundTama.GiveDeath();
      return View("Death");
    }

    [HttpPost("/tamagotchi/happiness")]
    public ActionResult Happiness()
    {
      Tamagotchi foundTama = Tamagotchi.GetTama();
      foundTama.GiveHappiness();
      return RedirectToAction("Create");
    }

    [HttpPost("/tamagotchi/sleep")]
    public ActionResult Sleep()
    {
      Tamagotchi foundTama = Tamagotchi.GetTama();
      foundTama.GiveSleep();
      return RedirectToAction("Create");
    }
  }
}
