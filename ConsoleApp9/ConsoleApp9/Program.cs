using System;

namespace ConsoleApp9
{
    class Program
    {


        public static class PlayerHelper
        {

            public static object ToNext(PlayerBase current)
            { if (current is Runner)
                {
                    PlayerBase current =  Swimmer;
                    return current;
                   
                }
                if (current is Swimmer)
                {
                    _ = current is Cyclist;
                    return current;

                }

            }        
        }

        public interface IBaton
        {
            void IsPassed(string message, PlayerBase player);

        }

        class Baton : IBaton
        {
            public Runner Runner { get; set; }


            public void IsPassed(string message, PlayerBase player)


            { if (message == "action ended" && player is Runner)
                {
                    Console.WriteLine("Baton is passed to next player");
                    Runner.PassesTo(PlayerHelper.ToNext());

                }
            
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

            public void PassesTo( PlayerBase player)
            {
                Console.WriteLine(this.GetType().Name + "gets baton");
            }

            public virtual void StartAction()
            {
                Console.WriteLine(this.GetType().Name + " is " + _action);

            }



        }

        class Runner : PlayerBase
        {

            public Runner(string action, IBaton baton) : base(action, baton)
            {
            }

            public override void StartAction()
            {
                Console.WriteLine("Relay race stareded by" + this);
                Console.WriteLine(this + " is " + _action);
                var message = "action ended";
                Baton.IsPassed(message);
            }

        }


    

        class Swimmer : PlayerBase
        {
            public Swimmer(string action, IBaton baton) : base(action, baton)
            {

            }
        }
        class Сyclist : PlayerBase
        {
            public Сyclist(string action, IBaton baton) : base(action, baton)
            {

            }
        }
        class Shooter : PlayerBase
        {
            public Shooter(string action, IBaton baton) : base(action, baton)
            {

            }
            public void EndGame()
            {
                Console.WriteLine("Relay race is finished by" + this);
            }

        }
        static void Main(string[] args)
        {
            Baton baton = new Baton();
            Runner Runner = new Runner("running", baton);
            

            Runner.StartAction();
         








        }
    }
}
