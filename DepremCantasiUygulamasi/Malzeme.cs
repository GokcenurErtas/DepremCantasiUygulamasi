using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepremCantasiUygulamasi
{
    public class Malzeme
    {
        public string Isim { get; set; }
        public int Adet { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }

        public Malzeme(string isim, int adet, DateTime tarih)
        {
            Isim = isim;
            Adet = adet;
            SonKullanmaTarihi = tarih;
        }

        public override string ToString()
        {
            return $"{Isim} - {Adet} adet - {SonKullanmaTarihi.ToShortDateString()}";
        }

        public bool TarihYaksiyor()
        {
            TimeSpan fark = SonKullanmaTarihi - DateTime.Now;
            return fark.TotalDays <= 3;
        }

    }

}
