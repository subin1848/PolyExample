using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    internal class Cat : Animal
    {
        public string Color { get; set; }
        public Cat() {  this.Age = 0; }

        public void Meow()
        {
            Console.WriteLine("냐옹");
        }
    }
}
