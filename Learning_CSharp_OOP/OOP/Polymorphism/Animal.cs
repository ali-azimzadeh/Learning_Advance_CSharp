using System;

namespace Learning_CSharp_OOP.Polymorphism
{
    class Animal  // Base class (parent) 
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }

        //public virtual void animalSound()
        //{
        //    Console.WriteLine("The animal makes a sound");
        //}
    }
}
