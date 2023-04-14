using System.Collections;
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
					"https://ws.alibaba.ir/api/v1/flights/domestic/available/GE4DINBRGA2TQNZZFUYC2NRTHAYTMOJYHEZDKNZQGA3TANJVGIWTQLKUJBJC2TKIIQWTEMBSGMYDIMJWFUWS2");
			var body = await result.Content.ReadAsStringAsync();

			var obj = JsonSerializer.Deserialize<Root>(body);


			// db.FlightData.AddRange(obj.result.departing);
			// db.SaveChanges();


			var flightId = db.FlightData.Select(f => f.flightId);

			foreach (var item in flightId)
			{
				var res = obj.result.departing.SingleOrDefault(i => i.flightId == item);

				var identicalFlightId = db.FlightData.Where(f => f.flightId == res.flightId);
				var maxVersion = identicalFlightId.Max(m => m.version);
				res.version = maxVersion + 1;

				if (res != null & res.seat != 0)
				{
					db.FlightData.AddRange(res);
					db.SaveChanges();
				}
			}
		}
	}
}