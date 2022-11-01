// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ClassMetotDemo;

int sayi = 16;
Customer customer1 = new Customer();
customer1.name = "Ali";
customer1.surname = "Ayaz";
customer1.tittle = "İşçi";

Customer customer2 = new Customer();
customer2.name = "Ayşe";
customer2.surname = "Varan";
customer2.tittle = "Yönetici";

CustomerManager.customerAdd(customer1);

CustomerManager.customerList(customer2);