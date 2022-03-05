using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Kisi:Entity
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dTarihi { get; set; }
    }
}
