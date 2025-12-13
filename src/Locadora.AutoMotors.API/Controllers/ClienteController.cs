using Microsoft.AspNetCore.Mvc;

namespace Locadora.AutoMotors.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> logger;
        public ClienteController(ILogger<ClienteController> logger)
        {
            this.logger = logger;
        }
    }
}
