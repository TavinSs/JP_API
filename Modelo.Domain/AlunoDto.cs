using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Domain
{
    public class AlunoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Matricula { get; set; }
        public string Cep { get; set; }
    }
}
