using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapp.Controllers
{
    [Route("api/[controller]")]
    public class MyappController : Controller
    {
        [HttpGet("sum/a={valor1}&b={valor2}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Sum(double valor1, double valor2)
        {   
            var soma = valor1 + valor2;
            return Ok("Valor da Soma = " + soma.ToString());
        }
        [HttpGet]
        public string Get()
        {
            return "Para fazer funciona tem que colocar o endpoint igual api/myapp/sum/a={valor1}&b={valor2} na URL";
        }
    }
}
