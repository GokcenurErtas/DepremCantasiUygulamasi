using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepremCantasiUygulamasi
{
    public class Canta
    {
        private List<Malzeme> malzemeler = new List<Malzeme>();

        public void MalzemeEkle(Malzeme m)
        {
            malzemeler.Add(m);
        }

        public void MalzemeSil(string isim)
        {
            malzemeler.RemoveAll(m => m.Isim.Equals(isim, StringComparison.OrdinalIgnoreCase));
        }

        public List<string> Listele()
        {
            return malzemeler.Select(m => m.ToString()).ToList();
        }

        public List<string> EksikKontrol()
        {
            List<string> eksikler = new List<string>();
            List<string> gerekli = new List<string>
            {
                "Su", "Yiyecek", "İlk Yardım", "Battaniye", "Fener", "Pil", "Radyo"
            };

            foreach (var isim in gerekli)
            {
                if (!malzemeler.Any(m => m.Isim.Equals(isim, StringComparison.OrdinalIgnoreCase)))
                {
                    eksikler.Add($"{isim} eksik");
                }
            }

            return eksikler;
        }

        public List<string> TarihiYaklasanlariGetir()
        {
            List<string> yaklasanlar = new List<string>();
            foreach (var m in malzemeler)
            {
                if (m.TarihYaksiyor())
                {
                    yaklasanlar.Add($"{m.Isim} ({m.SonKullanmaTarihi.ToShortDateString()}) süresi bitmek üzere!");
                }
            }
            return yaklasanlar;
        }

    }
}
