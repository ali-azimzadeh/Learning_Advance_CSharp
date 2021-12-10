using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp_OOP.OOP.Access_Modifiers.Private_Protected
{
    class User
    {
        private protected string Name;
        private protected string Location;
        private protected int Age;
        private protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
}
