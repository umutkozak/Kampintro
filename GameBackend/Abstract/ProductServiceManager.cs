using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBackend.Entities;
using InterfaceGameBackend.Abstract;

namespace GameBackend.Abstract
{
    public abstract class ProductServiceManager : IGamerService
    {
        public void Delete(Product product)
        {
            Console.WriteLine("Product Deleted!");
        }

        public void Save(Product product)
        {
            Console.WriteLine("Product saved!");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Product updeted!");
        }
    }

}
