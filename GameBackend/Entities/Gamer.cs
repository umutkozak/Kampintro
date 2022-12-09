using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBackend.Abstract;

namespace GameBackend.Entities
{
    //TcNo, Ad, Soyad, DoğumYılı
    public class Gamer : IEntity

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }
    }
}
