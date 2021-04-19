using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredefinedTypes
{
    public class Person
    {
        public string Name;
        public void SayHowManyLetters()
        {
            Console.WriteLine(Name.Length);
        }
    }
}
