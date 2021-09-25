using System;

namespace HelloWorld
{
    class Program
    {
        // Pole Kwadratu
        static int GetSquareArea(int SideDimension)
        {
            return SideDimension * SideDimension;
        }

        // Obwód kwadratu
        static int GetSquarePerimeter(int SideDimension)
        {
            return SideDimension * 4;
        }

        // Pole Koła
        static double GetCircleArea(int Radius)
        {
            return 3.14 * (Radius * Radius);
        }

        // Obwód Koła
        static double GetCirclePerimeter(int Radius)
        {
            return 2 * 3.14 * Radius;
        }

        static void IsAdult(int Age)
        {
            if (Age >= 18)
            {
                Console.WriteLine("Pełnoletni");
            }
            else
            {
                Console.WriteLine("Niepełnoletni");
            }
        }

        // Sumowanie liczb od X do Y
        static int SumXY(int x, int y)
        {
            int Sum = 0;

            for (int i = x; i <= y; i++)
            {
                // Warunek sumujący tylko liczby parzyste
                if (i % 2 == 0) 
                {
                    Sum += i;
                }
            }

            return Sum;
        }

        static void Main(string[] args)
        {
            // Wyświetlanie w konsoli
            string Name = "Tiramisu";
            int Age = 5;
            Console.WriteLine("Hello " + Name);
            Console.WriteLine($"{Name} is {Age} year Old!");

            Console.WriteLine($"{Name} will be {Age + 1} year old in next year");
            Console.WriteLine($"{Name} will be {Age + 10} year old in next 10 years");

           
            int SquareSide = 5;
            // Pole kwadratu
            int FieldSquare = SquareSide * SquareSide;
            Console.WriteLine($"Square field: {FieldSquare}");
            // Obwód kwadratu
            int CircuitSquare = SquareSide * 4;
            Console.WriteLine($"Square circuit: {CircuitSquare}");

            // PRZYKŁAD
            // USER INPUT STRING
            // string name = Console.ReadLine();

            // USER INPUT NUMBER
            // int UserAge = Convert.ToInt32(Console.ReadLine());

            // Pobieranie wartości od użytkownika
            Console.Write("W którym roku się urodziłeś?: ");
            int Year = Convert.ToInt32(Console.ReadLine());
            int CurrentAge = 2021 - Year;
            Console.WriteLine($"Masz {CurrentAge} lat");

            if (CurrentAge == 18)
            {
                Console.WriteLine("Jesteś dorosły!");
            }
            else if (CurrentAge > 18)
            {
                Console.WriteLine("Jesteś pełnoletni");
            }
            else
            {
                Console.WriteLine("Jesteś niepełnoletni!");

                Console.WriteLine($"Będziesz pełnoletni za {18 - CurrentAge} lat");
            }

            // Szukanie największej wartości
            int a = 5;
            int b = 10;
            int c = 10;

            if (a >= b && a >= c)
            {
                Console.WriteLine($"{a} jest największa");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine($"{b} jest największa");
            }
            else
            {
                Console.WriteLine($"{c} jest największe");
            }

            // Odwołanie do funkcji IsAdult
            IsAdult(22);

            // Pole kwadratu
            Console.WriteLine($"{GetSquareArea(5)}");
            // Obwód kwadratu
            Console.WriteLine($"{GetSquarePerimeter(5)}");
            // Pole koła
            Console.WriteLine($"{GetCircleArea(5)}");
            // Obwód koła
            Console.WriteLine($"{GetCirclePerimeter(5)}");

            // PĘTLE - przykład
            int x = 10;
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"{i}");
            }

            // PĘTLE- zadanie suma liczb pomiedzy dwoma parametrami
            // Suma liczb od x do y
            Console.WriteLine($"{SumXY(10, 15)}");
        }
    }
}
