using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternModel
{
    public class tblKullanicilar
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre { get; set; }
    }

    public class tblDersler
    {
        public int Id { get; set; }
        public string DersAdi { get; set; }
    }

    public class vmTablolar
    {
        public List<tblKullanicilar> glst_tblKullanicilar { get; set; }
        public tblKullanicilar tblKullanicilar { get; set; }

        public List<tblDersler> glst_tblDersler { get; set; }
        public tblDersler tblDersler { get; set; }

    }
}
