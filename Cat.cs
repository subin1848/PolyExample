using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    internal class Cat
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public Cat() {  this.Age = 0; }
        public void Eat()
        {
            Console.WriteLine("냠냠");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨");
        }
        public void Bark()
        {
            Console.WriteLine("왈왈");
        }
    }
}
