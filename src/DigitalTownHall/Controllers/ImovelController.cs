using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DigitalTownHall.Models;
using DigitalTownHall.Repository;

namespace DigitalTownHall.Controllers
{
    [RoutePrefix("api/v1.0/imovel")]
    public class ImovelController : MainController
    {
        Imovel[] imoveis = new Imovel[]
        {
            new Imovel { Code = 1, Iptu = 500 },
            new Imovel { Code = 2, Iptu = 1000 },
            new Imovel { Code = 3, Iptu = 400 },
            new Imovel { Code = 4, Iptu = 1500 }
        };

        [Route("consulta_iptu/{codigo}")]
        [HttpGet]
        public IHttpActionResult ConsultaIptu(int codigo)
        {
            var imovel = DadosRepository.ConsultaIptu(codigo);
            if (imovel == null)
            {
                return NotFound();
            }

            return Ok(imovel.Iptu);
        }
    }

}