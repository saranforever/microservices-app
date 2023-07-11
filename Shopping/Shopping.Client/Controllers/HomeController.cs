using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Client.Controllers
{
    public class HomeController : Controller
    {
        //private readonly HttpClient _httpClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IHttpClientFactory httpClientFactory, ILogger<HomeController> logger)
        {            
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            //_httpClient = httpClientFactory.CreateClient("ShoppingAPIClient");
        }

        public async Task<IActionResult> Index()
        {
            //var response = await _httpClient.GetAsync("/product");
            //var content = await response.Content.ReadAsStringAsync();

            List<Product> content = new List<Product>();
            Product p1 = new Product();
            p1 = p1.ToProduct(1);
            content.Add(p1);
            Product p2 = new Product();
            p2 = p2.ToProduct(1);
            content.Add(p2);
            //var productList = JsonConvert.DeserializeObject<IEnumerable<Product>>(content);

            return View(content);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
