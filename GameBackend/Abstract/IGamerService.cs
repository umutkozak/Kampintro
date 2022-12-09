using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGameBackend.Abstract
{
    //Oyuncuların sisteme kayıt olabileceği,
    //bilgilerini güncelleyebileceği,
    //kayıtlarını silebileceği bir ortamı simule ediniz.
    public interface IGamerService<T>
    {
        void Save();
        void Update();
        void Delete();


    }
}
