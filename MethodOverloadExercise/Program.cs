using System;

namespace MethodOverloadExercise
{
    class Program
    {
        static void Main(string[]args)
        {
            bool money = true;
            Console.WriteLine(Add(6, 7, money));
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static decimal Add(decimal x, decimal y)
        {
            return x + y; 
        }
        static string Add(int x, int y, bool money)
        {
            if(money == true)
            {
                if(x + y ==1)
                {
                    return $"{x + y} : dollars";
                }
                return $"{x + y} : dollars";
            }
            else
            {
                return $"error";
            }
        }
    }
}
