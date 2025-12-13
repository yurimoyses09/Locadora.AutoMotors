using Microsoft.AspNetCore.Mvc;

namespace Locadora.AutoMotors.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutomovelController : ControllerBase
    {
        private readonly ILogger<AutomovelController> _logger;
        public AutomovelController(ILogger<AutomovelController> logger)
        {
            _logger = logger;
        }
    }
}
