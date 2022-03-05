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
    public class DersController : ControllerBase
    {
        
        //constructor
        public DersController()
        {

        }
        [HttpGet]
        public List<Ders> Get()
        {
            List<Ders> dersler = new List<Ders>();
            dersler.Add(new Ders { id = 0, ad = "Matematik 1", dersKodu = "MM101", kontenjan = 5 });
            dersler.Add(new Ders { id = 1, ad = "Matematik 2", dersKodu = "MM102", kontenjan = 30 });
            dersler.Add(new Ders { id = 2, ad = "Fizik 1", dersKodu = "FF101", kontenjan = 30 });
            return dersler;
        }
    }
}
