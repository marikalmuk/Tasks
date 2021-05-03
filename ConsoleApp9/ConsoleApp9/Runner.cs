using System;

public class Runner : PlayerBase
{
    public Runner(string action, IBaton baton) : base(action, baton)
    {

    }

    public void StartAction()
    {
        Console.WriteLine("Relay race stareded by" + this);
        Console.WriteLine(this + " is " + _action);
        Baton.IsPassedFrom(this);
    }
}
