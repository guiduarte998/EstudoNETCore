using Dapper;
using DefaultStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DefaultStore.Controllers
{
    public class StoreController : Controller
    {

        private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetProduct([FromServices] IConfiguration configuration)
        {
            SqlConnection conn = new(configuration.GetConnectionString("StoreDataBase"));

            conn.Open();

            var productList = conn.Query<Product>("SELECT * FROM Store.PRODUCT");
            
            conn.Close();

            return View("Store", productList);
        }
    }
}
