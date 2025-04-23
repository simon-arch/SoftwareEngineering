namespace Mediator
{
    public abstract class BaseComponent
    {
        protected ICommandCentre? _mediator;
        public void SetMediator(ICommandCentre mediator)
        {
            _mediator = mediator;
        }
    }
}
