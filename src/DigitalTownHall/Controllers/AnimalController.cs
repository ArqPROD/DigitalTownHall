using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DigitalTownHall.Models;
using DigitalTownHall.Repository;

namespace DigitalTownHall.Controllers
{
    [RoutePrefix("api/v1.0/animal")]
    public class AnimalController : MainController
    {
        [Route("adocao_cao")]
        [HttpPost]
        public IHttpActionResult PedirAdocaoCao(Cidadao cidadao)
        {
            if (cidadao == null)
            {
                return BadRequest("Dados do cidadão devem ser informados.");
            }

            if (cidadao.Endereco == null
                || cidadao.Endereco.Logradouro == null
                || cidadao.Endereco.Cidade == null
                || cidadao.Endereco.Numero == null)
            {
                return BadRequest("Endereço completo do cidadão deve ser informado.");
            }

            var endereco = DadosRepository.GetEndereco(cidadao.Endereco.Logradouro);
            if (endereco == null)
            {
                return BadRequest("Endereço não encontrado.");
            }

            var status = DadosRepository.PedidoAdocaoCaes(cidadao);

            return RespostaSolicitacao(status);
        }

        [Route("adocao_gato")]
        [HttpPost]
        public IHttpActionResult PedirAdocaoGato(Cidadao cidadao)
        {
            if (cidadao == null)
            {
                return BadRequest("Dados do cidadão devem ser informados.");
            }

            if (cidadao.Endereco == null
                || cidadao.Endereco.Logradouro == null
                || cidadao.Endereco.Cidade == null
                || cidadao.Endereco.Numero == null)
            {
                return BadRequest("Endereço completo do cidadão deve ser informado.");
            }

            var endereco = DadosRepository.GetEndereco(cidadao.Endereco.Logradouro);
            if (endereco == null)
            {
                return BadRequest("Endereço não encontrado.");
            }

            var status = DadosRepository.PedidoAdocaoGato(cidadao);

            return RespostaSolicitacao(status);
        }
    }

}