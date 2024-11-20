namespace MediatorDesignPatternExample_20220828;

internal class ConcreteUser(IFacebookGroupMediator mediator, string name) : User(mediator, name)
{
    public override void Receive(string message)
    {
        Console.WriteLine(this.Name + ": Received Message:" + message);
    }
        
    public override void Send(string message)
    {
        Console.WriteLine(this.Name + ": Sending Message=" + message + "\n");
        Mediator.SendMessage(message, this);
    }
}