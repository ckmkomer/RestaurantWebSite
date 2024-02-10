using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Restaurant.UI.Dtos.About;
using System.Text;

namespace Restaurant.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AboutController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AboutController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

	
		[HttpGet]
		public async Task<IActionResult> UpdateAbout(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7014/api/About/{2}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateAboutDto>(jsonData);
				return View(values);
			}
			return View();

		}
		[HttpPost]

		public async Task<IActionResult> UpdateAbout(UpdateAboutDto dto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(dto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "aplication/json");
			var responseMessage = await client.PutAsync($"https://localhost:7014/api/About", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("UpdateAbout");
			}
			return View();
		}
	}
}
