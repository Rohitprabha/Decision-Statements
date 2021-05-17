using System;

namespace If_Ifelse_nested_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the largest");
                }
                else
                {
                    Console.Write("The 3rd Number is the largest");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("The 2nd Number is the largest");
            }
            else
            {
                Console.Write("The 3rd Number is the largest");
            }
        }
    }
}
