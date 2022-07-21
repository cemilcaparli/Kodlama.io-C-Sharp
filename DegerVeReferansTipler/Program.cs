namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Hello, World!");


            int sayi1 = 15;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 1000;
            Console.WriteLine(sayi1);


            // sayi 1 ?  sayi1 20 dir çünkü değer tip olduğu için en son atanan değer sayi1 de kalacaktır. 

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0] );
            // int , decimal , float , double ,boole = değer tip 
            // array , class , interface = referans tip 
            // değer tipler sadece  bellek içinde stack te tutulur 
        }   // new lemek bellekten değer tip için bir adres oluştur demektedir bir arrayi newlemek yalnızca stackte tutulmaz stacke kısmında new den öncesi 
            // heap kısmında newden sonrası tutulur   new heapte yeni bir adres oluştur demektedir.  
            // değer tiplerde değer atanır referans tiplerde adres numaraları atanır yukarıdaki örnekte sayilar2 nin referans numarası sayilar1 e atandığı için sayilar1 de 
            //  artık sayilar2 nin tuttuğu arrayi tutar 

    }
} 