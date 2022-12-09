using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBackend.Entities;

namespace GameBackend.Abstract
{
    public interface ISaleManager
    {
        void Sales(Product product, Gamer gamer, Campaign campaign);
        
    }
}
