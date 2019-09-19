using Microsoft.AspNetCore.Mvc;
using ShopApp.Domain.Interfaces;
using ShopApp.Infrastructure;

namespace ShopApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private readonly IPointOfSaleTerminalService pointOfSaleTerminalService;

        public TerminalController(IPointOfSaleTerminalService pointOfSaleTerminalService)
        {
            this.pointOfSaleTerminalService = pointOfSaleTerminalService;
        }


        // GET api/terminal
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Welcome to the Shop Application!";
        }

        // POST api/terminal
        [HttpPost]
        public ActionResult<double> Post([FromBody] string[] productsNames)
        {
            try { 
                return pointOfSaleTerminalService.CalculateOrderTotalPrice(productsNames);
            }
            catch(ProductNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
