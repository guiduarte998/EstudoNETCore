using DefaultStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace DefaultStore.Controllers
{
    public class StoreController : Controller
    {

        private readonly ILogger<StoreController> _logger;

        private readonly StoreContext _context;

        public StoreController(ILogger<StoreController> logger, StoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetProduct([FromServices] IConfiguration configuration)
        {
            var productList = _context.Products.ToList();

            return View("Store", productList);
        }
    }
}
