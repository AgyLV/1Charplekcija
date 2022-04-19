using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lekcija
{

        public class Person

{
        public Person(string name)
        {
            Name = name;
        }
        public Person ()
        {

        }


        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsMale { get; set; }

        public bool IsAdult {
            get
            {
                return Age > +18;
            }
        }
        
        public void Greeting()
        {
            Console.WriteLine($"Hello my name is: {Name} and I am {Age} years old");
        }

        public bool GetIsAdult()
        {
            return Age >= 18;
        }
    }
}
