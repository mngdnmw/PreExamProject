using JokeAppBLL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace JokeAppRestAPI.Controllers
{
	[EnableCors("MyPolicy")]
	[Produces("application/json")]
	[Route("api/addresses")]
	public class DemoController : Controller
	{
        IBLLFacade facade;

        public DemoController(IBLLFacade facade)
        {
            this.facade = facade;
        }
    }
}
