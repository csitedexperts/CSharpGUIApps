using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_GUI.ClassScripts
{
    public class Person
    {
        string firstName;
        string lastName;
        long phoneNumber;
        Address address;
        public string FirstName
        {
            get => firstName;
            set
            {
                try
                {
                    firstName = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to First Name");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                try
                {
                    lastName = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to LastName");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public long PhoneNumber
        {
            get => phoneNumber;
            set
            {
                try
                {
                    phoneNumber = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to PhoneNumber");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public Address Address
        {
            get => address;
            set
            {
                try
                {
                    address = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to Adress");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }



        public Person()
        {
            firstName = "first name";
            lastName = "last name";
            phoneNumber = 0;
            address = new Address("Adress", 0, "city", "state", 0);
        }

        public Person(string firstName, string lastName, long phoneNumber, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }



        public override string ToString()
        {
            string data = firstName + " " + lastName + ", Phone Number: " + phoneNumber + ", Address: " + address.ToString();
            return data;

        }
    }
}
