using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProject.Models;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        // Constructor
        public OgrenciController()
        {
        }
        [HttpGet]
        public List<Ogrenci> Get()
        {
            List<Ders> dersler1 = new List<Ders>();
            dersler1.Add(new Ders { id = 0, ad = "Matematik I", dersKodu = "MM101", kontenjan = 5 });
            dersler1.Add(new Ders { id = 1, ad = "Matematik 2", dersKodu = "MM102", kontenjan = 30 });

            List<Ders> dersler2 = new List<Ders>();
            dersler2.Add(new Ders { id = 0, ad = "Matematik I", dersKodu = "MM101", kontenjan = 5 });

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler.Add(new Ogrenci { id = 0, ogrNo = 111, ad = "Erdemhan", soyad = "Özdin", dTarihi = DateTime.Today, aldigiDersler = dersler1 });
            ogrenciler.Add(new Ogrenci { id = 1, ogrNo = 222, ad = "Ayşe", soyad = "Yılmaz", dTarihi = DateTime.Today, aldigiDersler = dersler2 });

            return ogrenciler;
        }
    }
}
