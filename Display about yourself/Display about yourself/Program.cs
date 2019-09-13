using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_about_yourself
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, age, contact, address ;
            Console.WriteLine("Please Enter Your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine();
            Console.WriteLine("Enter your contact");
            contact = Console.ReadLine();
            Console.WriteLine("Enter your address");
            address = Console.ReadLine();

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Contact: " + contact);
            Console.WriteLine("Address " + address);
            Console.WriteLine(" Thank you ");

            Console.ReadKey();


        }
    }
}
