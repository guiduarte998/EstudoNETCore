using DefaultStore.Models;
using DefaultStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
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
            IEnumerable<Product> productList = _context.Products;

            return View("Store", productList);
        }
    }
}
