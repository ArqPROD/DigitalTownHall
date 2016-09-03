using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DigitalTownHall.Models;
using DigitalTownHall.Repository;

namespace DigitalTownHall.Controllers
{
    [RoutePrefix("api/v1.0/servico_publico")]
    public class ServicoViaPublicaController : MainController
    {
        [Route("construcao_meio_fio")]
        [HttpPost]
        public IHttpActionResult ConstrucaoMeioFio(Endereco logradouro)
        {
            var status = DadosRepository.SolicitacaoConstrucaoMeioFio(logradouro.Logradouro);

            return RespostaSolicitacao(status);
        }

        [Route("recolhimento_carro_abandonado")]
        [HttpPost]
        public IHttpActionResult RecolhimentoCarroAbandonado(Endereco logradouro)
        {
            var status = DadosRepository.RecolhimentoCarroAbandonado(logradouro.Logradouro);

            return RespostaSolicitacao(status);
        }

        [Route("poda_arvore")]
        [HttpPost]
        public IHttpActionResult SolicitacaoPodaArvore(Endereco logradouro)
        {
            var status = DadosRepository.SolicitacaoPodaArvore(logradouro.Logradouro);

            return RespostaSolicitacao(status);
        }
    }

}