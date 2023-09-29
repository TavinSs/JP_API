using Modelo.Domain;


namespace Modelo.Infra.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        Aluno BuscarId(int id);
    }
}
