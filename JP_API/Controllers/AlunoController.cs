using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Application.Interface;
using Modelo.Domain;

namespace JP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoApplication _alunoApplication;

        public AlunoController(IAlunoApplication alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }

        [HttpGet("BuscarDadosAluno/{id}")]
        public async Task<IActionResult> BuscarDadosAluno(int id)
        {
            Retorno<Aluno> retorno = new(null);

            try
            {
                var aluno = _alunoApplication.BuscarAluno(id);
                if(aluno != null)
                {
                    retorno.CarregaRetorno(aluno, true, "Consulta realizada com sucesso!", 200);
                }
                else
                {
                    retorno.CarregaRetorno(aluno, true, $"aluno com o {id} não foi encontrado ou não existe", 204);
                }
                
                return Ok(retorno);
            }
            catch (Exception e)
            {
                retorno.CarregaRetorno(false, e.Message, 400);
                return BadRequest(retorno);
            }
        }

        [HttpPost("AdicionarDadosAluno")]
        public async Task<IActionResult> AdicionarDadosAluno([FromBody] Aluno aluno)
        {
            Retorno retorno = new();

            try
            {
                retorno = _alunoApplication.InserirAluno(aluno);
                return Ok(retorno);
            }
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }

        [HttpPut("EditarDadosAluno")]
        public async Task<IActionResult> EditarDadosAluno([FromBody] AlunoDto alunoDto)
        {
            Retorno<AlunoDto> retorno = new(null);

            try
            {
                _alunoApplication.EditarAluno(alunoDto);
                retorno.CarregaRetorno(alunoDto, true, "Aluno editado com sucesso!", 200);
                return Ok(retorno);
            }
            catch (Exception e)
            {
                retorno.CarregaRetorno(false, e.Message, 400);
                return BadRequest(retorno);
            }
        }
        [HttpDelete("DeletarAluno")]
        public async Task<IActionResult> ExcluirAluno([FromBody]AlunoDto alunoDto)
        {
            try
            {
                _alunoApplication.DeletarAluno(alunoDto);
                return Ok("Aluno Delete com Sucesso!");
            }
            catch (Exception)
            {
                return BadRequest("erro");
            }
        }
    }
}
