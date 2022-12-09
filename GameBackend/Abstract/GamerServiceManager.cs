using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBackend.Entities;
using InterfaceGameBackend.Abstract;

namespace GameBackend.Abstract
{
    public abstract class GamerServiceManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted!");
        }

        public  virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Gamer saved!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated!");
        }
    }
}
