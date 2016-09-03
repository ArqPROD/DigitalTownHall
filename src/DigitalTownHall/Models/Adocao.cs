using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalTownHall.Models
{
    public enum TipoAnimal
    {
        GATO, CAO
    }

    public class Adocao
    {
        public int Codigo { get; set; }
        public Cidadao Cidadao { get; set; }
        public DateTime Data { get; set; }
        public TipoAnimal TipoAnimal { get; set; }
    }
}