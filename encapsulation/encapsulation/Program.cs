using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus();

            Console.WriteLine("Enter the bus colour");
            bus1.setColour(Console.ReadLine());

            Console.WriteLine("Enter the bus rego");
            bus1.setRego(Console.ReadLine());

            Console.WriteLine("Enter the bus doors");
            bus1.setDoors(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the bus seats");
            bus1.setSeats(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Colour: {bus1.getColour()}\n Rego: {bus1.getRego()}\n Doors: {bus1.getDoors()}\n Seats: {bus1.getSeats()}");
            Console.ReadLine();
        }
    }
}
