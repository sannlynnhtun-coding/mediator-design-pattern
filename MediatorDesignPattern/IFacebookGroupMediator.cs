namespace MediatorDesignPatternExample_20220828;

internal interface IFacebookGroupMediator
{
    void SendMessage(string msg, User user);
    void RegisterUser(User user);
}