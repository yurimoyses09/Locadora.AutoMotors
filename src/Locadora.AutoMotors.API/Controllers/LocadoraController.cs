using Microsoft.AspNetCore.Mvc;

namespace Locadora.AutoMotors.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocadoraController : ControllerBase
    {
        private readonly ILogger<LocadoraController> _logger; 

        public LocadoraController(ILogger<LocadoraController> logger)
        {
            _logger = logger;
        }
    }
}
