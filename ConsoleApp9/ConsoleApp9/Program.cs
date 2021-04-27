using System;

namespace ConsoleApp9
{


    public interface IBaton
    {
        void IsPassed(string message, PlayerBase player);
    }

    class Baton : IBaton
    {
        public Runner Player1 { get; set; }
        public Swimmer Player2 { get; set; }
        
        public void IsPassed(string message, PlayerBase current)
        {
            if (message == "action ended" && current is Runner)
            {
                Console.WriteLine("Baton is passed to next player");
                current = Swimmer;
                Runner.PassesTo(current);
            }
            if (message == "action ended" && current is Swimmer)
            {
                Console.WriteLine("Baton is passed to next player");
                return;
            }
            else
            { Console.WriteLine("the last player has finished"); }
        }
    }
    
    public abstract class PlayerBase
    {
        protected readonly IBaton Baton;
        protected string _action;
        protected PlayerBase(string action, IBaton baton)
        {
            Baton = baton;
            _action = action;
        }

        public  void PassesTo(PlayerBase player)
        {
                Console.WriteLine(player.GetType().Name + " gets baton");
        }
        public virtual void StartAction()
        {
            Console.WriteLine(this.GetType().Name + " is " + _action);
        }
    }

    public class Runner : PlayerBase
    {
        public Runner(string action, IBaton baton) : base(action, baton)
        {

        }


        public override void StartAction()
        {
            Console.WriteLine("Relay race stareded by" + this);
            Console.WriteLine(this + " is " + _action);
            var message = "action ended";
            Baton.IsPassed(message, this);
        }

      
    }

    public class Swimmer : PlayerBase
    {
        public Swimmer(string action, IBaton baton) : base(action, baton)
        {

        }
    }
    public class Сyclist : PlayerBase
    {
        public Сyclist(string action, IBaton baton) : base(action, baton)
        {

        }
    }
    public class Shooter : PlayerBase
    {
        public Shooter(string action, IBaton baton) : base(action, baton)
        {

        }
        public void EndGame()
        {
            Console.WriteLine("Relay race is finished by" + this);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Baton baton = new Baton();
            Runner runner = new Runner("running", baton);
            Swimmer swimmer = new Swimmer("swimming", baton);
            //Cyclist cyclist = new Cyclist("riding", baton);


            //PlayerBase[] Players = new PlayerBase[4];
            //Players[0] = runner;
            //Players[1] = swimmer;

            runner.StartAction();
            swimmer.StartAction();
        }

    }
}
