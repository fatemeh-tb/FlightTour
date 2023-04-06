using Microsoft.EntityFrameworkCore;

namespace FlightTour_Service.DataAccess.DbContext;

public class SqliteFlightDbContext: FlightDbContext
{
	public SqliteFlightDbContext()
	{
		
	}
	
	protected override void OnConfiguring(DbContextOptionsBuilder options)
		=> options.UseSqlite(@"DataSource=D:\Source\WebClientDb/FlightTourDatabase.db;");
}