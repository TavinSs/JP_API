using Microsoft.AspNetCore.Mvc;


namespace JP_API.Controllers
{
    [Route("api/´[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("ObterIdAluno")]
        public async Task<IActionResult> ObterIdAluno()
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.Id = 1;
                return Ok(aluno);
            }
            catch (Exception) 
            {
                return BadRequest();
            }
        }
    }
}
