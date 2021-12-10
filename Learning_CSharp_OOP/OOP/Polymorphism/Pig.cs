using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp_OOP.Polymorphism
{
    class Pig : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }

        //public override void animalSound()
        //{
        //    Console.WriteLine("The pig says: wee wee");
        //}
    }
}
