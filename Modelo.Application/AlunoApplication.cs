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

        public Retorno InserirAluno(Aluno aluno)
        {
            Retorno retorno = new();

            if (aluno == null)
            {
                var mensagem = ValidaAluno(aluno);

                if (mensagem != null)
                {
                    retorno.CarregaRetorno(false, mensagem, 200);
                    return retorno;
                }
                _alunorepositorio.InserirAluno(aluno);

                retorno.CarregaRetorno(true, "Aluno(a) Adicionado(a) com Sucesso!", 200);
            }
            else
            {
                retorno.CarregaRetorno(true, "Nenhum dado fo informado.", 200);
            }

            return retorno;
        }

        public void EditarAluno(AlunoDto aluno)
        {
            _alunorepositorio.EditarAluno(aluno);
        }

        public void DeletarAluno(AlunoDto aluno)
        {
            _alunorepositorio.DeletarAluno(aluno);
        }

        private string ValidaAluno(Aluno aluno)
        {
            string mensagem = "";

            if (!aluno.Nome.Any())
                mensagem = "Não é possivel inserir o aluno sem nome.";

            if (aluno.Nome.Length > 50)
                mensagem = "O nome do aluno deve possuir até 50 caracteres.";

            return mensagem;
        }

    }
}