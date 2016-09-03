using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalTownHall.Models
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public IList<DisciplinaAluno> Disciplinas { get; set; }
    }
}