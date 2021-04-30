using System;


public interface IBaton
{
    void IsPassed(string message, PlayerBase player);
}

public class Baton : IBaton
{
    public Runner Player1 { get; set; }
    public Swimmer Player2 { get; set; }
    public Сyclist Player3 { get; set; }
    public Shooter Player4 { get; set; }

    public void IsPassed(string message, PlayerBase current)
    {
        if (message == "action ended" && current is Runner)
        {
            Console.WriteLine("Baton is passed to next player");
            current.PassesTo(Player2);
            return;
        }
        if (message == "action ended" && current is Swimmer)
        {
            Console.WriteLine("Baton is passed to next player");
            current.PassesTo(Player3);
            return;
        }
        if (message == "action ended" && current is Сyclist)
        {
            Console.WriteLine("Baton is passed to next player");
            current.PassesTo(Player4);
            return;
        }
        if (current is Shooter)
        {
            Console.WriteLine("the last player has finished");
            return;
        }
    }
}
