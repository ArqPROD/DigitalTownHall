using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DigitalTownHall.Repository;

namespace DigitalTownHall.Controllers
{
    [RoutePrefix("api/v1.0/aluno")]
    public class AlunoController : MainController
    {
        [Route("historico_aluno/{codigo}")]
        [HttpGet]
        public IHttpActionResult HistoricoAluno(int codigo)
        {
            var historico = DadosRepository.ConsultaHistoricoAluno(codigo);
            return Ok(historico);
        }
    }
}