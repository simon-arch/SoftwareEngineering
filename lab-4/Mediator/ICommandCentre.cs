namespace Mediator
{
    public interface ICommandCentre
    {
        void OnTryLand(Aircraft aircraft);
        void OnTryTakeOff(Aircraft aircraft);
    }
}
