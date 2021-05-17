using System;

namespace Nested_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string Men = "Women";
            string MartialStatus = "UnMarried";
            switch (Men)
            {
                case "Men":
                    switch (MartialStatus)
                    {
                        case "Married":
                            Console.WriteLine("The Person is Men and Married");
                            break;
                        case "UnMarried":
                            Console.WriteLine("The Person is Men and UnMarried");
                            break;
                    }
                    break;
                case "Women":
                    switch (MartialStatus)
                    {
                        case "Married":
                            Console.WriteLine("The Person is Women and Married");
                            break;
                        case "UnMarried":
                            Console.WriteLine("The Person is Women and UnMarried");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("The person is not  Men or Women");
                    break;
            }
            Console.ReadLine();
        }
    }
}
