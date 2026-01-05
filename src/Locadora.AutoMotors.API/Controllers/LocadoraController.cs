using Locadora.AutoMotors.API.DataTransferObjects;
using Locadora.AutoMotors.API.Mappers;
using Locadora.AutoMotors.Application.IService;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.AutoMotors.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocadoraController : ControllerBase
    {
        private readonly ILogger<LocadoraController> _logger;
        private readonly ILocadoraService _service;

        public LocadoraController(ILogger<LocadoraController> logger, ILocadoraService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLocacaoDTO dto)
        {
            _logger.LogInformation($"Realizando solicitação de locação de carro");
            var result = await _service.CreateAsync(LocadoraMapper.ToEntity(dto));

            return Ok(result);
        }
    }
}
