using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation2
{
    class Person
    {
        string firstName, lastName, address;
        int age, phone;

        string getFirstName()
        {
            return firstName;
        }

        void setFirstName(string fname)
        {
            firstName = fname;
        }

        string getLastName()
        {
            return lastName;
        }

        void setLastName(string lname)
        {
            lastName = lname;
        }

        string getAddress()
        {
            return address;
        }

        void setAddress(string add)
        {
            address = add;
        }

        int getAge()
        {
            return age;
        }

        void setAge(int ag)
        {
            age = ag;
        }

        int getPhone()
        {
            return phone;
        }

        void setPhone(int ph)
        {
            phone = ph;
        }

        public string getDetails()
        {
            return $"First Name: {firstName}\n Last Name: {lastName}\n Age: {age}\n Address: {address}\n Phone Number: {phone}";
        }

        //Need Constructor
    }
}
