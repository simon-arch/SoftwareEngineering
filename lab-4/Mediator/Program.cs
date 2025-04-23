using Mediator;
internal class Program
{
    private static void Main(string[] args)
    {
        var runways = new List<Runway> {
            new Runway(), 
            new Runway()
        };
        
        var aircraftA = new Mediator.Aircraft("ATR 42");
        var aircraftB = new Mediator.Aircraft("Airbus A310");
        var aircraftC = new Mediator.Aircraft("Boeing 717");

        var commandCentre = new CommandCentre(runways);

        commandCentre.AppendAircraft(aircraftA);
        commandCentre.AppendAircraft(aircraftB);
        commandCentre.AppendAircraft(aircraftC);

        GetRunwayStatus(commandCentre);

        UseAircraft(Aircraft.Land,    aircraftA, commandCentre);
        UseAircraft(Aircraft.Land,    aircraftB, commandCentre);
        UseAircraft(Aircraft.Land,    aircraftC, commandCentre);
        UseAircraft(Aircraft.TakeOff, aircraftA, commandCentre);
        UseAircraft(Aircraft.Land,    aircraftC, commandCentre);
        UseAircraft(Aircraft.TakeOff, aircraftB, commandCentre);
        UseAircraft(Aircraft.TakeOff, aircraftC, commandCentre);
        UseAircraft(Aircraft.TakeOff, aircraftC, commandCentre);

        GetRunwayStatus(commandCentre);
    }
    private enum Aircraft { Land, TakeOff }
    private static void UseAircraft(Aircraft action, Mediator.Aircraft aircraft, CommandCentre centre)
    {
        string suffix = action == Aircraft.Land ? "Landing" : "Taking Off";
        Console.WriteLine($"=== {aircraft.Name} is {suffix} | ({centre.GetRunwayInfo()}) ===");
        if (action == Aircraft.Land) aircraft.Land();
        else aircraft.TakeOff();
        Console.WriteLine();
    }
    private static void GetRunwayStatus(CommandCentre centre)
    {
        Console.WriteLine($"Runways status: {centre.GetRunwayInfo()}.\n");
    }
}