namespace Mediator
{
    public class CommandCentre : ICommandCentre
    {
        private List<Runway> _runways;
        public string GetRunwayInfo() => $"{_runways.Count(r => r.IsBusy)}/{_runways.Count} runways busy";
        public CommandCentre(List<Runway> runways)
        {
            _runways = runways;
            foreach (var runway in _runways)
            {
                runway.SetMediator(this);
            }
        }

        public void AppendAircraft(Aircraft aircraft)
        {
            aircraft.SetMediator(this);
        }

        public void OnTryLand(Aircraft aircraft)
        {
            var runway = _runways.FirstOrDefault(r => !r.IsBusy);

            if (runway != null)
            {
                Console.WriteLine($"Landing {aircraft.Name} on runway {runway.Id}.");
                runway.SetBusy();
            }
            else
            {
                Console.WriteLine($"Could not land {aircraft.Name}. Runway is busy.");
            }
        }

        public void OnTryTakeOff(Aircraft aircraft)
        {
            var runway = _runways.FirstOrDefault(r => r.IsBusy);

            if (runway != null)
            {
                Console.WriteLine($"{aircraft.Name} Taking off from runway {runway.Id}.");
                runway.SetFree();
            }
            else
            {
                Console.WriteLine($"{aircraft.Name} is not assigned to any runway.");
            }
        }
    }
}
