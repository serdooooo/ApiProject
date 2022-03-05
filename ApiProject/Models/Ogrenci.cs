using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class Ogrenci:Kisi
    {
        public int ogrNo { get; set; }
        public ICollection<Ders> aldigiDersler { get; set; }
    }
}
