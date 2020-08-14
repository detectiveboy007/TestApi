using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using TestApi.Models;

namespace TestApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            List<DataAPI> reservationList = new List<DataAPI>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<DataAPI>>(apiResponse);
                }
            }
            return View(reservationList);
        }
        public async Task<IActionResult> Details(int? id)
        {

            List<DataAPIValue> reservationList2 = new List<DataAPIValue>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList2 = JsonConvert.DeserializeObject<List<DataAPIValue>>("[" + apiResponse + "]");
                 
                }
            }
            return View(reservationList2);


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
