using Covid19Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Services
{
	public class OutsideApiService
	{
		private readonly HttpClient _httpClient = new HttpClient();
		private readonly string baseUrl = "https://corona.lmao.ninja/v2/states/Indiana";

		public async Task<OutsideApiStateModel> GetStateAsync() 
		{
			HttpResponseMessage response = await _httpClient.GetAsync(baseUrl);

			if (response.IsSuccessStatusCode) 
			{
				OutsideApiStateModel state = await response.Content.ReadAsAsync<OutsideApiStateModel>();
				return state;
			}

			return null;

		}
	}
}
