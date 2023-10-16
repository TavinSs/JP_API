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

            try
            {
                var aluno = _alunoApplication.BuscarAluno(id);
                return Ok(aluno);
            }
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }

        [HttpPost("AdicionarDadosAluno")]
        public async Task<IActionResult> AdicionarDadosAluno([FromBody] Aluno aluno)
        {

            try
            {
                _alunoApplication.InserirAluno(aluno);
                return Ok("Aluno Adicionado com Sucesso!");
            }
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }

        [HttpPut("EditarDadosAluno")]
        public async Task<IActionResult> EditarDadosAluno([FromBody] AlunoDto aluno)
        {

            try
            {             
                
                return Ok("Aluno Editado com Sucesso!");
            }
            catch (Exception)
            {
                return BadRequest("Erro");
            }
        }
    }
}
