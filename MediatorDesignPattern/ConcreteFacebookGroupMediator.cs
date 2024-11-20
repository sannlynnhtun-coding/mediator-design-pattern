namespace MediatorDesignPatternExample_20220828;

internal class ConcreteFacebookGroupMediator : IFacebookGroupMediator
{
    private List<User> _usersList = new List<User>();
    public void RegisterUser(User user)
    {
        _usersList.Add(user);
    }
        
    public void SendMessage(string message, User user)
    {
        foreach (var u in _usersList)
        {
            // message should not be received by the user sending it
            if (u != user)
            {
                u.Receive(message);
            }
        }
    }
}