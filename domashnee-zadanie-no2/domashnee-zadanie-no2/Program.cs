using System;

namespace domashnee_zadanie_no2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y = 0;
            double R = 0;
            //построение прямой
            Console.WriteLine("Прямая:");
            x = straight(ref y);
            // построение полуокружности
            Console.WriteLine("Окружность:");
            x = circle(ref y, R,0,3);
            x = circle(ref y, R, 3, 6); 
        }

        private static double straight(ref double y)
        {
            double x;
            for (x = -6; x <= 0; x += 0.1)
            {
                x = Math.Round(x, 4);
                y = (0.5 * x - 3);
                y = Math.Round(y, 4);

                Console.WriteLine($"X: {x}  Y: {y}");
            }

            return x;
        }

        private static double circle(ref double y, double R, double a, double b)
        {
            Console.WriteLine("Введите значение R:");
            R = Convert.ToDouble(Console.ReadLine());

            int k;
            Console.WriteLine("Введите -1,если нижняя четверть, 1 - если верхняя:");
            k = Convert.ToInt32(Console.ReadLine());
           
            double x,z;
            for (x = a; x <= b; x += 0.1)
            {
                x = Math.Round(x, 4);
                if (a != 0)
                {
                    z = x - b;
                }
                else
                    z = x;
               
                y = Math.Sqrt(Math.Abs(R * R - (z * z)));
                y = k*(Math.Round(y, 4));
                Console.WriteLine($"X: {x}  Y: {y}");
            }

            return x;
        }
    }
}
