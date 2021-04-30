using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Baton baton = new Baton();
            Runner runner = new Runner("running", baton);
            Swimmer swimmer = new Swimmer("swimming", baton);
            Сyclist cyclist = new Сyclist("riding", baton);
            Shooter shooter = new Shooter("shooting", baton);

            baton.Player1 = runner;
            baton.Player2 = swimmer;
            baton.Player3 = cyclist;
            baton.Player4 = shooter;

            runner.StartAction();
            swimmer.StartAction();
            cyclist.StartAction();
            shooter.StartAction();
        }
    }
}
