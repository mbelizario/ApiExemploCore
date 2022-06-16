using Core.Interfaces.Service;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorService fornecedorService;

        public FornecedorController(IFornecedorService fornecedorService)
        {
            this.fornecedorService = fornecedorService;
        }
        // GET: api/<FornecedorController>
        [HttpGet]
        public async Task<IEnumerable<Fornecedor>> Get()
        {
            var resultado = await fornecedorService.ObterAsync();
            return resultado;
        }

        //// GET api/<FornecedorController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<FornecedorController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<FornecedorController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<FornecedorController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
