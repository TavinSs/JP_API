using Modelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Application.Interface
{
    public interface IAlunoApplication
    {
        Aluno BuscarAluno(int id);
        void InserirAluno(Aluno aluno);
        void EditarAluno(Aluno aluno);
    }
}
