namespace FlightTour_Service.DataDomain;

public class FlightData
{
	public int Id { get; set; }
	public string? proposalId { get; set; }
	public string? origin { get; set; }
	public string? destination { get; set; }
	public string? airlineCode { get; set; }
	public string? flightNumber { get; set; }
	public string? leaveDateTime { get; set; }
	public string? arrivalDateTime { get; set; }
	public string? aircraft { get; set; }
	public int? priceChild { get; set; }
	public int? priceAdult { get; set; }
	public int? priceInfant { get; set; }
	public string? flightId { get; set; }
	public string? classType { get; set; }
	public string? classTypeName { get; set; }
	public string? statusName { get; set; }
	public string? ticketType { get; set; }
	public int? seat { get; set; }
	public int? stars { get; set; }
	public string? uniqueKey { get; set; }
	public string? terminal { get; set; }
	public string? ticketTypeLabel { get; set; }
	public string? originName { get; set; }
	public string? destinationName { get; set; }
	public string? airlineName { get; set; }
}


public class Result
{
	public int id { get; set; }
	public List <FlightData>? departing { get; set; }
}


public class Root
{
	public int id { get; set; }
	public Result? result { get; set; }
}

