using Microsoft.AspNetCore.Mvc;

namespace Cashback.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CallbackController : Controller
    {
        public string Index () {
            return "API Successfully started";
        }
    }
}