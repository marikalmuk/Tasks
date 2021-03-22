using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            circle1.Diametr = ReadDouble("Enter diametr");
            circle1.WriteInfo();

            Triangle triangle1 = new Triangle();
            triangle1.Cat1 = ReadDouble ("Enter Cathetus1");
            triangle1.Cat2 = ReadDouble("Enter Cathetus2");
            circle1.WriteInfo();

            Trapezoid trap = new Trapezoid();
            trap.BaseA = ReadDouble("Enter Base A");
            trap.BaseB = ReadDouble("Enter Base B");
            Console.WriteLine(trap.Midsegment());
        }
        public static double ReadDouble (string s)
        {
            Console.WriteLine(s);
            return Convert.ToDouble(Console.ReadLine());
        }
    }

    class Circle
    {
        private double _diametr;
        public Circle()
        {
            _diametr = this.Diametr;
        }
        public double Diametr
        {
            get
            { return _diametr; }
            set
            {
                _diametr = value;
            }
        }
        public double Radius
        {
            get
            { return Diametr / 2; }
        }
        public double CircleArea
        {
            get
            { return GetCircleArea(); }
        }
        public double GetCircleArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double Length
        {
            get
            { return 2 * Math.PI * Radius; }
        }
        public void WriteInfo()
        {
            Console.WriteLine($"The area of a circle is {CircleArea}");
            Console.WriteLine($"The circumference is {Length}");
        }
    }
    class Triangle
    {
        private double _cat1;
        private double _cat2;
        public Triangle()
        {
            _cat1 = this.Cat1;
            _cat2 = this.Cat2;
        }
        public double Cat1
        {
            get => _cat1;
            set
            {
                _cat1 = value;
            }
        }
        public double Cat2
        {
            get => _cat2;
            set
            {
                _cat2 = value;
            }
        }
        public double Hipotenuse
        {
            get
            { return Math.Sqrt(Math.Pow(Cat1, 2) + Math.Pow(Cat2, 2)); }
        }
        public double TriangleArea
        {
            get => 0.5 * Cat1 * Cat2;
        }
        public void WriteInfo()
        {
            Console.WriteLine($"The area of a circle is {Hipotenuse}");
            Console.WriteLine($"The circumference is {TriangleArea}");
        }
    }
    class Trapezoid
    {
        private double _baseA;
        private double _baseB;
        public Trapezoid()
        {
            _baseA = this.BaseA;
            _baseB = this.BaseB;
        }
        public double BaseA
        {
            get => _baseA;
            set
            {
                _baseA = value;
            }
        }
        public double BaseB
        {
            get => _baseB;
            set
            {
                _baseB = value;
            }
        }
        public double Midsegment()
        {
            return (BaseA + BaseB) / 2;
        }
    }
}



