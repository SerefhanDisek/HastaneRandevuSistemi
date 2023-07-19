using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
  public class BirimController : Controller
  {
    static List<Birim> birimler = new List<Birim>();

    public IActionResult Index()
    {
      return View(birimler);
    }

    [HttpPost]
    public IActionResult BirimKaydet()
    {
      string isim = HttpContext.Request.Form["Isim"];

      Birim newBirim = new Birim()
      {
        Isim = isim,
      };

      birimler.Add(newBirim);
      return View("Index", birimler);
    }

    [HttpGet]
    public string BirimKaydetGet()
    {
      string isim = HttpContext.Request.Query["Isim"];

      string text = isim;
      return text;
    }

    public string BirimKaydetBagla(string isim)
    {
      string text = isim;
      return text;
    }

    public IActionResult BirimKaydetModel(Birim birim)
    {
      birimler.Add(birim);
      return View("Index", birimler);
    }
  }
}
