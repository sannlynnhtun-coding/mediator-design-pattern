// See https://aka.ms/new-console-template for more information
using MediatorDesignPatternExample_20220828;

Console.WriteLine("Hello, World!");
IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
User ram = new ConcreteUser(facebookMediator, "Ram");
User dave = new ConcreteUser(facebookMediator, "Dave");
User smith = new ConcreteUser(facebookMediator, "Smith");
User rajesh = new ConcreteUser(facebookMediator, "Rajesh");
User sam = new ConcreteUser(facebookMediator, "Sam");
User pam = new ConcreteUser(facebookMediator, "Pam");
User anurag = new ConcreteUser(facebookMediator, "Anurag");
User john = new ConcreteUser(facebookMediator, "John");
facebookMediator.RegisterUser(ram);
facebookMediator.RegisterUser(dave);
facebookMediator.RegisterUser(smith);
facebookMediator.RegisterUser(rajesh);
facebookMediator.RegisterUser(sam);
facebookMediator.RegisterUser(pam);
facebookMediator.RegisterUser(anurag);
facebookMediator.RegisterUser(john);
dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
Console.WriteLine();
rajesh.Send("What is Design Patterns? Please explain ");
Console.Read();
