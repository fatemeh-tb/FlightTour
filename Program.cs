using System.Text.Json;
using System.Text.Json.Serialization;
using FlightTour_Service.DataAccess.DbContext;
using FlightTour_Service.DataDomain;

namespace FlightTour_Service
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var db = new SqliteFlightDbContext();
			db.Database.EnsureCreated();

			var httpclient = new HttpClient();
			var result =
				await httpclient.GetAsync(
					"https://ws.alibaba.ir/api/v1/flights/domestic/available/G4ZTIMBSGY4DINBNGAWTMMZYGE3DANBWG42DONBQGYYDQNZWFUZTALKUJBJC2TKIIQWTEMBSGMYDIMBUFUWS2");
			var body = await result.Content.ReadAsStringAsync();

			var obj = JsonSerializer.Deserialize<Root>(body);

			db.FlightData.AddRange(obj.result.departing);
			db.SaveChanges();
			
			
			// var prices = obj.result.departing.Select(i => i.priceAdult);
			// Console.WriteLine(prices);
			
		}
	}
}