using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBackend.Entities;
using InterfaceGameBackend.Abstract;

namespace GameBackend.Abstract
{
    public abstract class CampaignServiceManager : InterfaceGameBackend.Abstract.IGamerService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("campaign deleted!");
        }

       
        public void Save(Campaign campaign)
        {
            Console.WriteLine("campaign saved!");
        }

    

        public void Update(Campaign campaign)
        {
            Console.WriteLine("campaign updated!");
        }

       
    }

    public interface IGamerService<T>
    {
    }
}
