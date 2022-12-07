// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Dictionary;
using Microsoft.VisualBasic;
Dictionary<string, object> properties = new Dictionary<string, object>();
properties.Add("umut", 1);
foreach (var item in properties)
{
    Console.WriteLine(item);
}

//Console.WriteLine(properties);


myDictionary<string, int> ogrenciler = new myDictionary<string, int>();
ogrenciler.Add("umut", 1);


//foreach (var item in ogrenciler)
//{
  //  Console.WriteLine(item);
//}
Console.WriteLine(ogrenciler.Length);
ogrenciler.Get();

