using System;


public interface IBaton
{
    void IsPassedFrom(PlayerBase player);
}

public class Baton : IBaton
{
    public Runner Player1 { get; set; }
    public Swimmer Player2 { get; set; }
    public Cyclist Player3 { get; set; }
    public Shooter Player4 { get; set; }

    public void IsPassedFrom(PlayerBase current)
    {
        if (current is Runner)
        {
            Console.WriteLine("Baton is passed to next player");
            current.PassesTo(Player2);
            return;
        }
        if (current is Swimmer)
        {
            Console.WriteLine("Baton is passed to next player");
            current.PassesTo(Player3);
            return;
        }
        if (current is Cyclist)
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
