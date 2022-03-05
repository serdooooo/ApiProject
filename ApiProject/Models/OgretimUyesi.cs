using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class OgretimUyesi:Kisi
    {
        public int persNo { get; set; }
        public ICollection<Ders> verdigiDersler { get; set; }
    }
}
