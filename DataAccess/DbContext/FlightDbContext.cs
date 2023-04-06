using FlightTour_Service.DataDomain;
using Microsoft.EntityFrameworkCore;

namespace FlightTour_Service.DataAccess.DbContext;

public class FlightDbContext: Microsoft.EntityFrameworkCore.DbContext
{
	public DbSet<FlightData> FlightData { get; set; }


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		FlightData_builder(modelBuilder);
	}


	private void FlightData_builder(ModelBuilder modelBuilder)
	{
		
	}
	
}