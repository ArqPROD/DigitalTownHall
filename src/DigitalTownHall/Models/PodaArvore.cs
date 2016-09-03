using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalTownHall.Models
{
    public class PodaArvore
    {
        public Endereco Logradouro { get; set; }
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
    }
}