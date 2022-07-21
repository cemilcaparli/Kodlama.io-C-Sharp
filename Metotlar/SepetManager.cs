using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
    {
        //naming convention metodların ve klasların baş harfleri büyük 
        public void Ekle( Urun urun)
        {
            Console.WriteLine(" tebrikler sepete eklendi  : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine(" tebrikler sepete eklendi  : " + urunAdi);
        }
    }
}
 