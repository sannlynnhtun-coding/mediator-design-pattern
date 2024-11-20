namespace MediatorDesignPatternExample_20220828;

internal class ConcreteFacebookGroupMediator : IFacebookGroupMediator
{
    private readonly List<User> _usersList = [];
    public void RegisterUser(User user)
    {
        _usersList.Add(user);
    }
        
    public void SendMessage(string message, User user)
    {
        foreach (var u in _usersList.Where(u => u != user))
        {
            u.Receive(message);
        }
    }
}