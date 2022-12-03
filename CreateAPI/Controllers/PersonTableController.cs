using CreateAPI.DAL;
using CreateAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreateAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonTableController : ControllerBase
    {
        [HttpGet]
        [Route("GetPersonTable")]
        public IActionResult Get()
        {
            try
            {
                return Ok(new TipoPessoaDAL().Listar());
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("GetPersonTable/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                TipoPessoaDAL dal = new TipoPessoaDAL();
                GêneroPessoa gêneroPessoa = dal.Consultar(id);
                return Ok(gêneroPessoa);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost(Name = "GetPersonTable")]
        public IActionResult Post([FromBody] GêneroPessoa gêneroPessoa)
        {
            try
            {

                TipoPessoaDAL dal = new TipoPessoaDAL();
                dal.Inserir(gêneroPessoa);
                string location = "https://localhost:7013/PersonTable";

                return Created(new Uri(location), gêneroPessoa);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete(Name = "GetPersonTable")]
        public IActionResult Delete(int id)
        {
            try
            {
                TipoPessoaDAL dal = new TipoPessoaDAL();
                dal.Excluir(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut(Name = "GetPersonTable")]
        public IActionResult Put([FromBody] GêneroPessoa gêneroPessoa)
        {
            try
            {
                TipoPessoaDAL dal = new TipoPessoaDAL();
                dal.Alterar(gêneroPessoa);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
