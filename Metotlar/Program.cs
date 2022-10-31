// See https://aka.ms/new-console-template for more information
using Metotlar;
//Console.WriteLine("Hello, World!");

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 50;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

foreach (var urun in urunler)
{
    Console.WriteLine(urun.Adi+" , "+urun.Fiyati+" , "+urun.Aciklama );    
}

SepetManager sepetManager= new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "iyi", 12);
sepetManager.Ekle2("Elma", "Amasya", 9);