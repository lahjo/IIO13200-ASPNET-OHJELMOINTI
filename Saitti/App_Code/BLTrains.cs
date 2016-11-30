using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLTrains
/// </summary>
public class Stations
{
    public string stationName { get; set; }
    public string stationShortCode { get; set; }
}

public class Trains
{
    public string trainNumber { get; set; }
    public string cancelled { get; set; }
    public string departureDate { get; set; }
}