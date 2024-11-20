namespace MediatorDesignPatternExample_20220828;

internal abstract class User(IFacebookGroupMediator mediator, string name)
{
    protected IFacebookGroupMediator Mediator = mediator;
    protected string Name = name;
    public abstract void Send(string message);
    public abstract void Receive(string message);
}