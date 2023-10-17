using Modelo.Domain;
using Modelo.Infra.Repositorio.Interface;

namespace Modelo.Infra.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Aluno BuscarId(int id)
        {
            return _bancoContexto.Aluno.FirstOrDefault(x => x.Id == id);
        }

        public void InserirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }

        public void EditarAluno(AlunoDto alunoDto)
        {
            Aluno aluno = new ();
            aluno.Id = alunoDto.Id;
            aluno.Nome = alunoDto.Nome;
            aluno.Idade = alunoDto.Idade;
            aluno.Matricula = alunoDto.Matricula;
            aluno.Cep = alunoDto.Cep;

            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }
        public void DeletarAluno(AlunoDto alunoDto)
        {
            Aluno aluno = new();
            aluno.Id = alunoDto.Id;

            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }
    }
}
