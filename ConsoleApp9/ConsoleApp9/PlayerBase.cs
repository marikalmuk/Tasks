using System;

public abstract class PlayerBase
{
    protected readonly IBaton Baton;
    protected string _action;
    protected PlayerBase(string action, IBaton baton)
    {
        Baton = baton;
        _action = action;
    }

    public void PassesTo(PlayerBase player)
    {
        Console.WriteLine(player.GetType().Name + " gets baton");
        Console.WriteLine(player.GetType().Name + " is " + player._action);
        Baton.IsPassedFrom(player);
    }
}
