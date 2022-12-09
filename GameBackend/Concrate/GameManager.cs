using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBackend.Abstract;
using GameBackend.Entities;

namespace GameBackend.Concrate
{
    public class GameManager : GamerServiceManager 
    {
        public IGamerCheckService IgamerCheckService { get; set; }

        public override void Save(Gamer gamer)
        {
            if (IgamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

       
    }
}
