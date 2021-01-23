using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123465";
            musteri1.Adi = "Gökhan";
            musteri1.Soyadi = "Tekiner";
            musteri1.TcNo = "13245456";


            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "13245";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "132135456";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
           
        }
    }
}
