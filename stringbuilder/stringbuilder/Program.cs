using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder details;
            details = new StringBuilder();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
                        
            Console.WriteLine("Enter age");
            string age = Console.ReadLine();
            
            Console.WriteLine("Enter job");
            string job = Console.ReadLine();

            Console.WriteLine("Enter exp");
            string exp = Console.ReadLine();

            Console.WriteLine("Enter qualification");
            string qualification = Console.ReadLine();

            Console.WriteLine("name {0} , age{1} , job {2} , exp{3} and qualification{4} ", name, age, job , exp , qualification);
            








        }
    }
}
