using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HastaneRandevuSistemi.Controllers
{
  public class HastalikController : Controller
  {
    static List<Hastalik> hastaliklar = new List<Hastalik>();

    public IActionResult Index()
    {
      return View(hastaliklar);
    }

    [HttpPost]
    public IActionResult HastalikKaydet()
    {
      string isim = HttpContext.Request.Form["Isim"];
      string tanim = HttpContext.Request.Form["Tanim"];
      string belirti = HttpContext.Request.Form["Belirti"];

      Hastalik newHastalik = new Hastalik
      {
        Isim = isim,
        Tanim = tanim,
        Belirti = belirti
      };

      hastaliklar.Add(newHastalik);
      return View("Index", hastaliklar);
    }

    [HttpGet]
    public string HastalikKaydetGet()
    {
      string isim = HttpContext.Request.Query["Isim"];
      string tanim = HttpContext.Request.Query["Tanim"];
      string belirti = HttpContext.Request.Query["Belirti"];

      string text = isim + " " + tanim + " " + belirti;
      return text;
    }

    public IActionResult HastalikKaydetModel(Hastalik hastalik)
    {
      hastaliklar.Add(hastalik);
      return View("Index", hastaliklar);
    }
  }
}
