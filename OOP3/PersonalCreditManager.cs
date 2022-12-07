using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class PersonalCreditManager : ICrediManager
    {
        public void Count()
        {
            Console.WriteLine("Personal Credi Count");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
