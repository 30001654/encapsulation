using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Bus
    {
        string colour, rego;
        int doors, seats;

        public string getColour()
        {
            return colour;
        }

        public void setColour(string col)
        {
            colour = col;
        }

        public string getRego()
        {
            return rego;
        }

        public void setRego(string reg)
        {
            rego = reg;
        }

        public int getDoors()
        {
            return doors;
        }

        public void setDoors(int door)
        {
            doors = door;
        }

        public int getSeats()
        {
            return seats;
        }

        public void setSeats(int seat)
        {
            seats = seat;
        }
    }
}
