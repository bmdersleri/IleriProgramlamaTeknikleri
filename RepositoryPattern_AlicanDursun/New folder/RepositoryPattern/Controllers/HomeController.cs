using RepositoryPatternModel;
using RepositoryPatternWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            vmTablolar _vmTablolar = new vmTablolar();
            using (var _work = new GenericRepository<tblKullanicilar>("tblKullanicilar"))
            {
                _vmTablolar.glst_tblKullanicilar = await _work.Liste_Getir();
            }

            using (var _work = new GenericRepository<tblDersler>("tblDersler"))
            {
                _vmTablolar.glst_tblDersler = await _work.Liste_Getir();

            }
            return View(_vmTablolar);
        }
        public async Task<ActionResult> Kullanici_Kaydet_Guncelle(vmTablolar _vmTablolar)
        {
            using (var _work = new GenericRepository<tblKullanicilar>("tblKullanicilar"))
            {
                if (_vmTablolar.tblKullanicilar.Id == 0)
                {
                    await _work.Veri_Kaydet(_vmTablolar.tblKullanicilar);
                }
                else
                {
                    await _work.Veri_Guncelle(_vmTablolar.tblKullanicilar);
                }
            }

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> KullaniciSil(int Id)
        {
            using (var _work = new GenericRepository<tblKullanicilar>("tblKullanicilar"))
            {
                await _work.Veri_Sil(Id);
            }
            return RedirectToAction("Index");
        }


        public async Task<ActionResult> Ders_Kaydet_Guncelle(vmTablolar _vmTablolar)
        {
            using (var _work = new GenericRepository<tblDersler>("tblDersler"))
            {
                if (_vmTablolar.tblDersler.Id == 0)
                {
                    await _work.Veri_Kaydet(_vmTablolar.tblDersler);
                }
                else
                {
                    await _work.Veri_Guncelle(_vmTablolar.tblDersler);
                }

            }
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> DersSil(int Id)
        {
            using (var _work = new GenericRepository<tblDersler>("tblDersler"))
            {
                await _work.Veri_Sil(Id);
            }
            return RedirectToAction("Index");
        }

    }
}