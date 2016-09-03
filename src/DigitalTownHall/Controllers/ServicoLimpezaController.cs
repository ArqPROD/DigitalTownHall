using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DigitalTownHall.Models;
using DigitalTownHall.Repository;

namespace DigitalTownHall.Controllers
{
    [RoutePrefix("api/v1.0/servico_limpeza")]
    public class ServicoLimpezaController : MainController
    {
              
        [HttpGet]
        [Route("consulta_coleta_lixo/{logradouro:alpha}")]
        public IHttpActionResult ConsultaColetaLixo(string logradouro)
        {
            var logradouroModel = new Endereco() { Logradouro = logradouro };

            var coleta = DadosRepository.ConsultaColetaLixo(logradouroModel.Logradouro);

            if (coleta == null)
            {
                return Ok("Não há coletas de lixo para este logradouro");
            }
            return Ok(coleta);
        }

        
        [HttpPost]
        [Route("desobstrucao_via_publica")]
        public IHttpActionResult DesobstrucaoViaPublica(Endereco logradouro)
        {
            var status = DadosRepository.DesobstrucaoViaPublica(logradouro.Logradouro);

            return RespostaSolicitacao(status);
        }

        
        [HttpPost]
        [Route("desobstrucao_corrego")]
        public IHttpActionResult DesobstrucaoCorrego(Endereco logradouro)
        {
            var status = DadosRepository.DesobstrucaoCorrego(logradouro.Logradouro);

            return RespostaSolicitacao(status);
        }

        
        [HttpPost]
        [Route("limpeza_boca_lobo")]
        public IHttpActionResult LimpezaBocaLobo(Endereco logradouro)
        {
            var status = DadosRepository.LimpezaBocaDeLobo(logradouro.Logradouro);
            return RespostaSolicitacao(status);
        }

        
        [HttpPost]
        [Route("coleta_animal_morto")]
        public IHttpActionResult ColetaAnimalMorto(Endereco logradouro)
        {
            var status = DadosRepository.ColetaAnimal(logradouro.Logradouro);

            return RespostaSolicitacao(status);
        }
    }
}