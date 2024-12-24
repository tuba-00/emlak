using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class EstateController : Controller
{
    public IActionResult Index()
    {
        // Örnek veri
        var estates = new List<Estate>
        {
            new Estate { Id = 1, Category = "Satılık Arsa", Title = "Geniş Arsa", Description = "500 m²", Price = 100000, ImageUrl = "/images/arsa.jpg" },
            new Estate { Id = 2, Category = "Kiralık Daire", Title = "Şehir Merkezinde", Description = "2+1, 90 m²", Price = 2500, ImageUrl = "/images/daire.jpg" }
        };
        return View(estates);
    }
}
