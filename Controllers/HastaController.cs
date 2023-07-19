using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
  public class HastaController : Controller
  {
    static List<Hasta> hastalar = new List<Hasta>();

    public IActionResult Index ()
    {
      return View(hastalar);
    }

    [HttpPost]
    public IActionResult HastaKaydet()
    {
      string Isim = HttpContext.Request.Form["Isim"];
      string SoyIsim = HttpContext.Request.Form["SoyIsim"];
      string TelefonNumarasi = HttpContext.Request.Form["TelefonNumarasi"];
      string Email = HttpContext.Request.Form["email"];

      Hasta newHasta = new Hasta();
      {
        Isim = isim,
        SoyIsim = soyIsim,
        TelefonNumarasi = telefonNumarasi,
        Email = email,
      };

      hastalar.Add(newHasta);
      return View("Index",hastalar);
    }

    [HttpGet]
    public string HastaKaydetGet()
    {
      string isim = HttpContext.Request.Query["Isim"];
      string soyIsim = HttpContext.Request.Query["SoyIsim"];
      string telefonNumarasi = HttpContext.Request.Query["TelefonNumarasi"];
      string email = HttpContext.Request.Query["email"];

      string text = isim + " " + soyIsim + " " + telefonNumarasi + " " + email;
      return text;
    }

    public string HastaKaydetBagla(string isim, string soyIsim, string telefonNumarasi, string email )
    {
      string text = isim + " " + soyIsim + " " + telefonNumarasi + " " + email;
      return text;
    }

    public IActionResult HastaKaydetModel(Hasta hasta)
    {
      hastalar.Add(hasta);
      return View("Index",hastalar);
    }
  }
}
