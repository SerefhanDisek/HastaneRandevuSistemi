using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HastaneRandevuSistemi.Controllers
{
  public class PoliklinikController : Controller
  {
    static List<Poliklinik> poliklinikler = new List<Poliklinik>();

    public IActionResult Index()
    {
      return View(poliklinikler);
    }

    [HttpPost]
    public IActionResult PoliklinikKaydet()
    {
      string isim = HttpContext.Request.Form["Isim"];

      Poliklinik newPoliklinik = new Poliklinik
      {
        Isim = isim
      };

      poliklinikler.Add(newPoliklinik);
      return View("Index", poliklinikler);
    }

    [HttpGet]
    public string PoliklinikKaydetGet()
    {
      string isim = HttpContext.Request.Query["Isim"];

      string text = isim;
      return text;
    }

    public IActionResult PoliklinikKaydetModel(Poliklinik poliklinik)
    {
      poliklinikler.Add(poliklinik);
      return View("Index", poliklinikler);
    }
  }
}
