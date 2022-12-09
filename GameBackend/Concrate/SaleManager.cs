using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBackend.Abstract;
using GameBackend.Entities;

namespace GameBackend.Concrate
{
    public class SaleManager : ISaleManager
    {
        public void Sales(Product product, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Oyun Satıldı!");
        }

    }
}
