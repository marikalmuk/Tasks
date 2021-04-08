using System;

namespace ConsoleApp8
{
    interface IAnimal
    {
        public string Type { get; }
        public string Name { get; set; }
        public string Sound { get; }
        public void Move();
        public void Print();
        public void Feed(string f);

    }
    interface IEatable
    {
        public string FoodType { get; }
    }

    class Lion : IAnimal
    {
        public Lion(string name)
        {
            Type = "Lion";
            Name = name;
            Sound = "roar";
        }
        public string Type
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Sound
        {
            get; set;
        }
        public void Move()
        {
            Console.WriteLine("Lion -walk");
        }
        public void Feed(string f)
        {
            if (f == "meat")
            {
                Console.WriteLine("Lion eats meat");
            }
            if (f == "grain")
            {
                Console.WriteLine("Lion does not eat grain");
            }
            if (f == "fruit")
            {
                Console.WriteLine("Lion does not eat fruit");
            }
        }

        public void Print()
        {
            Console.WriteLine("type={0}, name={1}, sound={2}", Type, Name, Sound);
        }
    }

    class Elephant : IAnimal
    {
        public Elephant(string name)
        {
            Type = "Elephant";
            Name = name;
            Sound = "ugh";
        }
        public string Type
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Sound
        {
            get; set;
        }
        public void Move()
        {
            Console.WriteLine("Elephant -walk");
        }
        public void Feed(string f)
        {
            if (f == "meat")
            {
                Console.WriteLine("Elephant does not eat meat");
            }
            if (f == "grain")
            {
                Console.WriteLine("Elephant eats grain");
            }
            if (f == "fruit")
            {
                Console.WriteLine("Elephant eats fruit");
            }
        }
        public void Print()
        {
            Console.WriteLine("type={0}, name={1}, sound={2}", Type, Name, Sound);
        }
    }

    class Frog : IAnimal
    {
        public Frog(string name)
        {
            Type = "Frog";
            Name = name;
            Sound = "ugh";
        }
        public string Type
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Sound
        {
            get; set;
        }
        public void Move()
        {
            Console.WriteLine("Frog -jump");
        }
        public void Feed(string f)
        {
            if (f == "meat")
            {
                Console.WriteLine("Frog does not eat meat");
            }
            if (f == "grain")
            {
                Console.WriteLine("Frog does not eat grain");
            }
            if (f == "fruit")
            {
                Console.WriteLine("Frog does not eat fruit");
            }
        }
        public void Print()
        {
            Console.WriteLine("type={0}, name={1}, sound={2}", Type, Name, Sound);
        }
    }

    class Pinguin : IAnimal
    {
        public Pinguin(string name)
        {
            Type = "Pinguin";
            Name = name;
            Sound = "no sound";
        }
        public string Type
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Sound
        {
            get; set;
        }
        public void Move()
        {
            Console.WriteLine("Pinguin -walk");
        }
        public void Feed(string f)
        {
            if (f == "meat")
            {
                Console.WriteLine("Pinguin does not eat meat");
            }
            if (f == "grain")
            {
                Console.WriteLine("Pinguin does not eat grain");
            }
            if (f == "fruit")
            {
                Console.WriteLine("Pinguin does not eat fruit");
            }
        }
        public void Print()
        {
            Console.WriteLine("type={0}, name={1}, sound={2}", Type, Name, Sound);
        }
    }

    class Eagle : IAnimal
    {
        public Eagle(string name)
        {
            Type = "Eagle";
            Name = name;
            Sound = "$$$$";
        }
        public string Type
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Sound
        {
            get; set;
        }
        public void Move()
        {
            Console.WriteLine("Eagle -fly");
        }
        public void Feed(string f)
        {
            if (f == "meat")
            {
                Console.WriteLine("Eagle eats meat");
            }
            if (f == "grain")
            {
                Console.WriteLine("Eagle eats grain");
            }
            if (f == "fruit")
            {
                Console.WriteLine("Eagle eats fruit");
            }
        }
        public void Print()
        {
            Console.WriteLine("type={0}, name={1}, sound={2}", Type, Name, Sound);
        }
    }
    class Fish : IAnimal
    {
        public Fish(string name)
        {
            Type = "Fish";
            Name = name;
            Sound = "????";
        }
        public string Type
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Sound
        {
            get; set;
        }
        public void Move()
        {
            Console.WriteLine("Fish -swim");
        }
        public void Feed(string f)
        {
            if (f == "meat")
            {
                Console.WriteLine("Fish does not eat meat");
            }
            if (f == "grain")
            {
                Console.WriteLine("Fish does not eat grain");
            }
            if (f == "fruit")
            {
                Console.WriteLine("Fish does not eat fruit");
            }
        }
        public void Print()
        {
            Console.WriteLine("type={0}, name={1}, sound={2}", Type, Name, Sound);
        }
    }

    class Meat : IEatable
    {
        public Meat()
        {
            FoodType = "meat";
        }
        public string FoodType
        {
            get; set;
        }
    }

    class Grain : IEatable
    {
        public Grain ()
        {
            FoodType = "grain";
        }
        public string FoodType
        {get;set; 
        }
    }
    class Fruit : IEatable
    {
        public Fruit()
        {
            FoodType = "fruit";
        }
        public string FoodType
        {
            get; set;
        }
    }

    class Zoo

    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Simba");
            Elephant elephant = new Elephant("Jumbo");
            Frog frog = new Frog("Froggy");
            Pinguin pinguin = new Pinguin("Kovalski");
            Eagle eagle = new Eagle("Adler");
            Fish fish = new Fish("Nemo");

            IAnimal[] animals = new IAnimal[] { lion, elephant, frog, pinguin, eagle, fish };

            Meat meat = new Meat();
            Grain grain = new Grain();
            Fruit fruit = new Fruit();

            IEatable[] food = new IEatable[] { meat, grain, fruit };

            foreach (var a in animals)
            {
                a.Print();
                a.Move();

                foreach (var f in food)
                {
                    a.Feed(f);
                }
            }
        }
    }




}



