// See https://aka.ms/new-console-template for more information
string kurs1 = "Programlama geliştirici kursu";
string kurs2 = "";


for (int i = 0; i <= 10; i+=2)
{
    Console.WriteLine(i);
}


Product urun1 = new Product();
urun1.urunAdi = "Kalem";
urun1.urunAdedi = 20;
urun1.gorsel = "dolma kalem";

Product urun2 = new Product();
urun2.urunAdi = "Silgi";
urun2.urunAdedi = 15;
urun2.gorsel = "Renkli";

Product urun3 = new Product();
urun3.urunAdi = "dosya";
urun3.urunAdedi = 30;
urun3.gorsel = "Şeffaf";

Product[] urunler=new Product[] {urun1,urun2,urun3};  

foreach (var urun in urunler)
{
    Console.WriteLine(urun.urunAdi+" , "+urun.gorsel+" , "+urun.urunAdedi);
}

Console.WriteLine("for");

for (int i = 0; i < urunler.Length; i++)
{
    Console.WriteLine(urunler[i].gorsel +" , "+ urunler[i].urunAdi);
        
 }
Console.WriteLine("while");
int deger = 0;
while (deger<urunler.Length)
{
    Console.WriteLine(urunler[deger].gorsel+" , " + urunler[deger].urunAdi);
    deger++;
}

class Product
{
    public string urunAdi { get; set; }
    public int urunAdedi { get; set; }
    public string gorsel { get; set; }
}

