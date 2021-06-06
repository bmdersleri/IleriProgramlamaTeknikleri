using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using yeni_mvc_uyg.model;

namespace yeni_mvc_uyg.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<kitap>()
            {
                new kitap(){ID=1,kitap_adı="SUÇ VE CEZA", yazar_adı="dostoyesvki"},
                new kitap(){ID=2,kitap_adı="OLASILIKSIZ", yazar_adı="ADAM FAWER"},
                new kitap(){ID=3,kitap_adı="HAYVAN ÇİFTLİĞİ", yazar_adı="GEORGE ORWELL"}
            };
            return View(ktp);
        }
    }
}
