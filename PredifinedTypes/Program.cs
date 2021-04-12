using PredefinedTypes;
using System;

namespace PredifinedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            if(p.Name!=null && p.Name.Length > 0)
            {
                p.SayHowManyLetters();
            }
            else
            {
                Console.WriteLine("Person's name is not valid!");
            }

        }
        private static void Boolean_ConversionFromString()
        {
            string text = "true";

            if (bool.TryParse(text, out bool valueAsBool))
            {
                Console.WriteLine(valueAsBool);
            }
            else
            {
                Console.WriteLine("String is NOT convertible to bool!");
            }
        }

        private static void Boolean_EvaluateExpression()
        {
            int nr = 25;
            bool isEven = nr % 2 == 0;
            if (isEven)
            {
                Console.WriteLine("Number " + nr + " is even");
            }
            else
            {
                Console.WriteLine("Number " + nr + " is odd");
            }
        }

        private static bool ReturnBool(bool value)
        {
            Console.WriteLine("Called ReturnBool("+value+" )");
            return value;

        }

        private static void Boolean_ConditionalVsBitWiseOperators()
        {
            Console.WriteLine("Bitwise AND");
            bool condiftion1 = ReturnBool(false) & ReturnBool(true);
            Console.WriteLine(condiftion1);
            Console.WriteLine("--------------------------------------");

            bool condiftion2 = ReturnBool(false) && ReturnBool(true);
            Console.WriteLine(condiftion2);
        }
    }
}
