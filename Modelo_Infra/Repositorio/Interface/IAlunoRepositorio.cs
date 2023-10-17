using Modelo.Domain;


namespace Modelo.Infra.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        void InserirAluno(Aluno aluno);
        void EditarAluno(AlunoDto alunoDto);
        void DeletarAluno(AlunoDto alunoDto);
        Aluno BuscarId(int id);
    }
}
