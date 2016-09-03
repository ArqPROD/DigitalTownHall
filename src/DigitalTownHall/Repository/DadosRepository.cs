using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DigitalTownHall.Models;

namespace DigitalTownHall.Repository
{
    public class DadosRepository
    {
        /*
         * Dados 
         */
        static int cont = 0;

        static Endereco[] enderecos = new Endereco[]
        {
            new Endereco { Cidade = "Contagem", Logradouro = "Rua Sumarã", Numero = 100 },
            new Endereco { Cidade = "Contagem", Logradouro = "Av João César", Numero = 1003 },
            new Endereco { Cidade = "Contagem", Logradouro = "Av José Faria da Rocha", Numero = 1200 },
            new Endereco { Cidade = "Contagem", Logradouro = "Rua Mojoara", Numero = 1004 },
            new Endereco { Cidade = "Contagem", Logradouro = "Rua das Indústrias", Numero = 1100 },
        };

        static ColetaLixo[] coletasLixo = new ColetaLixo[]
        {
            new ColetaLixo { Data = DateTime.Now, Logradouro = enderecos[0] },
            new ColetaLixo { Data = new DateTime(2015, 2, 15), Logradouro = enderecos[1] },
            new ColetaLixo { Data = new DateTime(2016, 10, 5), Logradouro = enderecos[2] },
            new ColetaLixo { Data = new DateTime(2016, 8, 20), Logradouro = enderecos[3] }
        };

        static Imovel[] imoveis = new Imovel[]
        {
            new Imovel { Code = 1, Iptu = 500 },
            new Imovel { Code = 2, Iptu = 1000 },
            new Imovel { Code = 3, Iptu = 400 },
            new Imovel { Code = 4, Iptu = 1500 }
        };

        static Disciplina[] disciplinas = new Disciplina[]
        {
            new Disciplina { Codigo = 1 },
            new Disciplina { Codigo = 2 },
            new Disciplina { Codigo = 3 },
            new Disciplina { Codigo = 4 },
            new Disciplina { Codigo = 5 },
            new Disciplina { Codigo = 6 }
        };

        static DisciplinaAluno[] disciplinasAluno = new DisciplinaAluno[]
        {
            new DisciplinaAluno { Disciplina = disciplinas[0], Nota = 10 },
            new DisciplinaAluno { Disciplina = disciplinas[5], Nota = 9 },
            new DisciplinaAluno { Disciplina = disciplinas[1], Nota = 5 },
            new DisciplinaAluno { Disciplina = disciplinas[2], Nota = 7 },
            new DisciplinaAluno { Disciplina = disciplinas[3], Nota = 4 },
            new DisciplinaAluno { Disciplina = disciplinas[4], Nota = 5 }
        };

        static Aluno[] alunos = new Aluno[]
        {
            new Aluno { Codigo = 1, Disciplinas = disciplinasAluno }
        };

        static List<PodaArvore> podasArvores = new List<PodaArvore>();
        static List<ConstrucaoMeioFio> meioFio = new List<ConstrucaoMeioFio>();
        static List<RecolhimentoCarro> recolhimentoCarro = new List<RecolhimentoCarro>();
        static List<DesobstrucaoViaPublica> viaPublica = new List<DesobstrucaoViaPublica>();
        static List<LimpezaBocaDeLobo> limpezaBocaLobo = new List<LimpezaBocaDeLobo>();
        static List<DesobstrucaoCorrego> corrego = new List<DesobstrucaoCorrego>();
        static List<ColetaAnimal> coletaAnimal = new List<ColetaAnimal>();
        static List<Adocao> adocaoAnimal = new List<Adocao>();

        /*
         * Métodos
         */
        public static Endereco GetEndereco(string logradouro)
        {
            var logra = enderecos.FirstOrDefault(l => l.Logradouro == logradouro);
            return logra;
        }

        public static Imovel ConsultaIptu(int codigo)
        {
            var imovel = imoveis.FirstOrDefault(i => i.Code == codigo);
            return imovel;
        }

        public static ColetaLixo ConsultaColetaLixo(string logradouro)
        {
            var logra = GetEndereco(logradouro);
            if (logra == null)
            {
                return null;
            }

            var coleta = coletasLixo.FirstOrDefault(c => c.Logradouro.Logradouro == logradouro);
            return coleta;
        }

        public static bool SolicitacaoPodaArvore(string logradouro)
        {
            var logra = GetEndereco(logradouro);
            if (logra == null)
            {
                return false;
            }

            PodaArvore novo = new PodaArvore { Codigo = cont++, Data = DateTime.Now, Logradouro = logra };
            podasArvores.Add(novo);
            return true;
        }

        public static bool SolicitacaoConstrucaoMeioFio(string logradouro)
        {
            var logra = GetEndereco(logradouro);
            if (logra == null)
            {
                return false;
            }

            ConstrucaoMeioFio novo = new ConstrucaoMeioFio { Codigo = cont++, Data = DateTime.Now, Logradouro = logra };
            meioFio.Add(novo);
            return true;
        }

        public static bool RecolhimentoCarroAbandonado(string logradouro)
        {
            var logra = GetEndereco(logradouro);
            if (logra == null)
            {
                return false;
            }

            RecolhimentoCarro novo = new RecolhimentoCarro { Codigo = cont++, Data = DateTime.Now, Logradouro = logra };
            recolhimentoCarro.Add(novo);
            return true;
        }

        public static bool DesobstrucaoViaPublica(string logradouro)
        {
            var logra = GetEndereco(logradouro);
            if (logra == null)
            {
                return false;
            }

            DesobstrucaoViaPublica novo = new DesobstrucaoViaPublica { Codigo = cont++, Data = DateTime.Now, Logradouro = logra };
            viaPublica.Add(novo);
            return true;
        }

        public static bool DesobstrucaoCorrego(string logradouro)
        {
            var logra = GetEndereco(logradouro);
            if (logra == null)
            {
                return false;
            }

            DesobstrucaoCorrego novo = new DesobstrucaoCorrego { Codigo = cont++, Data = DateTime.Now, Logradouro = logra };
            corrego.Add(novo);
            return true;
        }

        public static bool ColetaAnimal(string logradouro)
        {
            var logra = GetEndereco(logradouro);
            if (logra == null)
            {
                return false;
            }

            ColetaAnimal novo = new ColetaAnimal { Codigo = cont++, Data = DateTime.Now, Logradouro = logra };
            coletaAnimal.Add(novo);
            return true;
        }

        public static bool LimpezaBocaDeLobo(string logradouro)
        {
            var logra = GetEndereco(logradouro);
            if (logra == null)
            {
                return false;
            }

            LimpezaBocaDeLobo novo = new LimpezaBocaDeLobo { Codigo = cont++, Data = DateTime.Now, Logradouro = logra };
            limpezaBocaLobo.Add(novo);
            return true;
        }

        public static IList<DisciplinaAluno> ConsultaHistoricoAluno(int codigoAluno)
        {
            var aluno = alunos.FirstOrDefault(a => a.Codigo == codigoAluno);
            if (aluno == null)
            {
                return null;
            }

            return aluno.Disciplinas;
        }

        public static bool PedidoAdocaoCaes(Cidadao cidadao)
        {
            if (cidadao == null)
            {
                return false;
            }

            Adocao novo = new Adocao { Codigo = cont++, Data = DateTime.Now, Cidadao = cidadao, TipoAnimal = TipoAnimal.CAO };
            adocaoAnimal.Add(novo);
            return true;
        }

        public static bool PedidoAdocaoGato(Cidadao cidadao)
        {
            if (cidadao == null)
            {
                return false;
            }

            Adocao novo = new Adocao { Codigo = cont++, Data = DateTime.Now, Cidadao = cidadao, TipoAnimal = TipoAnimal.GATO };
            adocaoAnimal.Add(novo);
            return true;
        }
    }

}