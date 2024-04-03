using GestaoDeCadastro.Crosscutting.DTO.Cadastro;
using GestaoDeCadastro.Service.ApplicationServices.Cadastro;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeCadastro.Interface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly CadastroApplicationServices _service;

        public CadastroController(CadastroApplicationServices service)
        {
            _service = service;
        }

        [HttpGet("GetListPessoas")]
        public async Task<ActionResult<List<PessoaDTO>>> GetListPessoas()
        {
            try
            {
                var Pessoas = await _service.GetListPessoas();

                return Ok(Pessoas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("CreatePessoa")]
        public async Task<ActionResult> CreatePessoa(CreatePessoaDTO CreatePessoa)
        {
            try
            {
                await _service.CreatePessoa(CreatePessoa);

                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
