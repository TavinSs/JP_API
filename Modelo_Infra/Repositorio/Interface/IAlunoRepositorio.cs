using Modelo.Domain;


namespace Modelo.Infra.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        void InserirAluno(Aluno aluno);
        void EditarAluno(Aluno aluno);
        Aluno BuscarId(int id);
    }
}
