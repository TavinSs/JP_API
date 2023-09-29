using Modelo.Application.Interface;
using Modelo.Domain;
using Modelo.Infra.Repositorio.Interface;

namespace Modelo.Application
{
    public class AlunoApplication : IAlunoApplication
    {
        private readonly IAlunoRepositorio _alunorepositorio;
        public AlunoApplication(IAlunoRepositorio alunorepositorio)
        {
            _alunorepositorio = alunorepositorio;
        }

        public Aluno BuscarAluno(int id)
        {
            var aluno = _alunorepositorio.BuscarId(id);
            return aluno;
        }
    }
}