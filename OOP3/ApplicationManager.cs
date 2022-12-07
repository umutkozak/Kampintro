using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void makeApp (ICrediManager crediManager ,ILoggerService loggerService)
        {
            crediManager.Count();
            loggerService.Log();
        }
        public void crediInformation(List<ICrediManager> crediManagers) 
        {
            foreach (var credi in crediManagers)
            {
                credi.Count();
            }
        
        }
    }
}
