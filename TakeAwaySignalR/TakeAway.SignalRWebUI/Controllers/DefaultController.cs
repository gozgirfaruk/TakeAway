using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TakeAway.SignalRWebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();


            var responseMessage = await client.GetAsync("https://localhost:7252/api/Deliveries/TotalPrice");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.v1 = jsonData;

            
            var responseMessage2 = await client.GetAsync("https://localhost:7252/api/Deliveries/TotalOrder");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.v2 = jsonData2;
            return View();

            return View();
        }


    }
}
