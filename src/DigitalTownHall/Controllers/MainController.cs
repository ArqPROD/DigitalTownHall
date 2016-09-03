using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DigitalTownHall.Controllers
{
    public class MainController : ApiController
    {

        public IHttpActionResult RespostaSolicitacao(bool status)
        {
            if (status)
            {
                return Ok("Solicitação completada com sucesso");
            }
            else
            {
                return Ok("Solicitação não completada. Consulte o logradouro");
            }
        }
    }
}