// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using GameBackend.Abstract;
using GameBackend.Concrate;
using GameBackend.Entities;

Gamer gamer = new Gamer() { FirstName = "Umut", LastName = "Kozak" };
Product product = new Product() { Name = "Knight Online", ProductPrice = 32 };
Campaign campaign = new Campaign() { CampaignName = "Yılsonu", DiscountRate = 25 };

SaleManager saleManager = new SaleManager();
saleManager.Sales(product,gamer,campaign);
GamerCheckManager gamer1 = new GamerCheckManager();
gamer1.CheckIfRealPerson(gamer);



Console.ReadLine();