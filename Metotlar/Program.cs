namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun   urun1 = new Urun();
             
            urun1.Id = 1;
            urun1.Adi = "elma";
            urun1.Fiyati = 10.5 ;
            urun1.Aciklama = "amasya elması ";

            Urun urun2 = new Urun();

            urun2.Id = 2;
            urun2.Adi = "portakal";
            urun2.Fiyati = 25.5;
            urun2.Aciklama = "adana protakalı ";

            Urun[] urunler = new Urun[] {urun1 , urun2};
               
            foreach (Urun urun in urunler) 

            {
                Console.WriteLine(urun.Adi + " " + urun.Fiyati + " " + urun.Aciklama );


            }
            Console.WriteLine("------------metodlar------------");
            //instance - örnek 
            //encapsulation özellikleri class a koyup parametre olarak o klası  çağırmak 
            SepetManager   sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            // hatalı kullanımdır özellikleri bu  şekilde tek 
            sepetManager.Ekle2("armut1", "yeşil artmut ", 15.5);
            sepetManager.Ekle2("elma", "kırmızı", 18);
            sepetManager.Ekle2("üzüm", "yapıncak", 95);


        }

    }
}