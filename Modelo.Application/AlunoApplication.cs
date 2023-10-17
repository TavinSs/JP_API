using Modelo.Application.Interface;
using Modelo.Domain;
using Modelo.Infra;
using Modelo.Infra.Repositorio;
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

        public void InserirAluno(Aluno aluno)
        {
            try { 
            _alunorepositorio.InserirAluno(aluno);
            }
            catch (Exception)
            {
                
            }
        }

        public void EditarAluno(AlunoDto aluno)
        {
            _alunorepositorio.EditarAluno(aluno);
        }

        public void DeletarAluno(AlunoDto aluno)
        {
            _alunorepositorio.DeletarAluno(aluno);
        }

    }
}