using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // Need constructor
            Console.WriteLine("Enter the persons first name");
            person1.setFirstName(Console.ReadLine());

            Console.WriteLine("Enter the persons last name");
            person1.setLastName(Console.ReadLine());

            Console.WriteLine("Enter the persons age");
            person1.setAge(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the persons address");
            person1.setAddress(Console.ReadLine());

            Console.WriteLine("Enter the persons phone number");
            person1.setPhone(int.Parse(Console.ReadLine()));

            person1.getDetails();
            Console.ReadLine();
        }
    }
}
