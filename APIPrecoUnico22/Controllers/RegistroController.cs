using APIPrecoUnico22.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIPrecoUnico22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        private readonly IServices _services;

        public RegistroController(IConfiguration configuration,
            IServices services)
        {
            _services = services;
        }



        [HttpGet]
        public async Task<dynamic> ObterRegistros()
        {
            var registro = await _services.ObterRegistros("87474770-319C-4180-8ADF-39D59A50763F");

            // Retorna os registros como resposta JSON
            return new { registro };
        }
    }
}
