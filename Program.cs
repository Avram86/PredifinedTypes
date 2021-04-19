using PredefinedTypes;
using System;

namespace PredifinedTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            
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

        private static void PersonFunction()
        {
            Person p = new Person();
            if (p.Name != null && p.Name.Length > 0)
            {
                p.SayHowManyLetters();
            }
            else
            {
                Console.WriteLine("Person's name is not valid!");
            }
        }

        private static void IntOperatoriPeBiti()
        {
            Console.WriteLine("1=" +Convert.ToString(1, 2));
            Console.WriteLine("-1=" + Convert.ToString(-1, 2));
            Console.WriteLine("1 | -1=" + Convert.ToString(1 | -1, 2));
            Console.WriteLine("1&-1=" + Convert.ToString(1 & -1, 2));
            //output
            //1=1
            //-1 = 11111111111111111111111111111111
            //1 | -1 = 11111111111111111111111111111111
            //1 & -1 = 1

        }

        private static void Characters()
        {
            char letterA = 'A';
            Console.WriteLine("The letter is :"+letterA);
            
            letterA = '\u0041';
            Console.WriteLine("The letter is :" + letterA);
            
            letterA = '\x0041';
            Console.WriteLine("The letter is :" + letterA);

            //output
            /*The letter is :A
            The letter is :A
            The letter is :A*/
        }

        private static void ConvertChar()
        {
            var letterA = 'A';
            ushort ushortA = letterA;
            Console.WriteLine("Conversion char A to ushort :" + ushortA);

            int intA = letterA;
            Console.WriteLine("Conversion char A to int :" + intA);

            uint uintA = letterA;
            Console.WriteLine("Conversion char A to uint :" + uintA);

            long longA = letterA;
            Console.WriteLine("Conversion char A to long :" + longA);

            ulong ulongA = letterA;
            Console.WriteLine("Conversion char A to ulong :" + ulongA);


            float floatA = letterA;
            Console.WriteLine("Conversion char A to float :" + floatA);
            double doubleA = letterA;
            Console.WriteLine("Conversion char A to double :" + doubleA);
            decimal decimalA = letterA;
            Console.WriteLine("Conversion char A to decimal :" + decimalA);

            //output 
            /*
Conversion char A to ushort :65
Conversion char A to int :65
Conversion char A to uint :65
Conversion char A to long :65
Conversion char A to ulong :65
Conversion char A to float :65
Conversion char A to double :65
Conversion char A to decimal :65
             */
        }

        private static void ImmutableStrings1()
        {
            string msg1 = "Hello world!";
            string msg2 = msg1;
            msg1 = msg1 + "123";
            if(object.ReferenceEquals(msg1, msg2))
            {
                Console.WriteLine("Same address reference");
            }
            else
            {
                Console.WriteLine("Different address reference");
            }
            //output: different address
        }

        private static void ImmutableStrings2()
        {
            string msg1 = new string(new []{'H', 'e', 'l', 'l', 'o' });
            string msg2 = new string(new[] { 'H', 'e', 'l', 'l', 'o' });
 
            if (object.ReferenceEquals(msg1, msg2))
            {
                Console.WriteLine("Same address reference");
            }
            else
            {
                Console.WriteLine("Different address reference");
            }

            //output: different address
        }
        private static void ImmutableStrings3()
        {
            string msg1 = "Hello";
            string msg2 = "Hello";

            if (object.ReferenceEquals(msg1, msg2))
            {
                Console.WriteLine("Same address reference");
            }
            else
            {
                Console.WriteLine("Different address reference");
            }

            //output :SAME address
        }

        private static void StringComparison()
        {
            var str1 = "Bob";
            var str2 = "Alice";

            bool areEqual1 = (str1 == str2);
            bool areEqual2 = string.Equals(str1, str2, System.StringComparison.OrdinalIgnoreCase);
            //bool areEqual2 = string.Equals(str1, str2, System.StringComparison.CurrentCultureIgnoreCase);
            bool areEqual3 = str1.Equals(str2);

            Console.WriteLine("== result: "+areEqual1);
            Console.WriteLine("string.Equal(string1, string2) result: " + areEqual2);
            Console.WriteLine("string1.Equal(string2) result: " + areEqual3);
        }

        private static void FormatatreStrings()
        {
            int quantity = 10;
            double unitprice = 20.5;
            string productName = "Product A";
            string unitofMeasure = "buc";

            string message = string.Format("Ati cumparat {0} {1} din produsul \"{2}\" ,preturl unitar fiind {3}",
                quantity,unitofMeasure, productName, unitprice);
            Console.WriteLine(message);
        }

        private static void Pad()
        {
            decimal price1 = 25.16M;
            decimal price2 = 123.6M;

            Console.WriteLine($"Price 1 is: {price1.ToString().PadLeft(6, ' ')}");
            Console.WriteLine($"Price 2 is: {price2.ToString().PadLeft(6, ' ')}");
        }

        private static void UnboxedObject()
        {
            int i = 10;
            //creeaza o copie a valorii lui i
            object unboxedObj = i;
            i = 5;
            Console.WriteLine($"i is {i}");
            Console.WriteLine($"unboxed i is {unboxedObj}");
        }
        private static void UnboxedObject2()
        {
            object obj = 15;
            long i = (int)obj;

            Console.WriteLine(i);
        }

        private static void RangeOperator()
        {
            int startIndex = 2;
            int length = 2;
            int[] array = new int[] { 1, 2, 3, 4 };
            int[] subArray = array[startIndex..(startIndex+length)];

            Console.WriteLine($"Sub Array: {string.Join(",", subArray)}");
            //Sub Array: 3,4

            int[] middleSubArray = array[1..^1];
            Console.WriteLine($"Sub Array: {string.Join(",", middleSubArray)}");
            //Sub Array: 2,3
            //exclude ultimul element din sir ^1



            int[] fullSubArray = array[0..^0];
            Console.WriteLine($"Sub Array: {string.Join(",", fullSubArray)}");
            //Sub Array: 1,2,3,4

            int[] fullSubArray2 = array[0..];
            Console.WriteLine($"Sub Array: {string.Join(",", fullSubArray2)}");
            //Sub Array: 1,2,3,4

            int[] fullSubArray3 = array[..^0];
            Console.WriteLine($"Sub Array: {string.Join(",", fullSubArray3)}");
            //Sub Array: 1,2,3,4

            int[] fullSubArray4 = array[..];
            Console.WriteLine($"Sub Array: {string.Join(",", fullSubArray4)}");
            //Sub Array: 1,2,3,4
        }

        public static bool CkeckIsInt(object value)
        {
            return value is int;
        }

        public static void PrintIfStringValue(object value)
        {
            string stringValue = value as string;
            if(!string.ReferenceEquals(stringValue, null))
            {
                Console.WriteLine($"PrintIfStringValue('{stringValue}')");
            }
        }

        
    }
}
