using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_GUI.ClassScripts
{
    public class Address
    {
        string streetAddress;
        int apartmentNumber;
        string city;
        string state;
        int zip;

        public string StreetAddress
        {
            get => streetAddress; set
            {
                try
                {
                    streetAddress = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to street adress");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }

        }
        public int ApartmentNumber
        {
            get => apartmentNumber; set
            {
                try
                {
                    apartmentNumber = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to apartment number");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public string City
        {
            get => city; set
            {
                try
                {
                    city = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to city");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public string State
        {
            get => state; set
            {
                try
                {
                    state = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to state");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public int Zip
        {
            get => zip; set
            {
                try
                {
                    zip = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to zip code");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }

        Address()
        {
            streetAddress = "";
            apartmentNumber = 0;
            city = "";
            state = "";
            zip = 0;
        }
        public Address(string streetAddress, int apartmentNumber, string city, string state, int zip)
        {
            this.streetAddress = streetAddress;
            this.apartmentNumber = apartmentNumber;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }



        public override string ToString()
        {
            return streetAddress + " Apartment " + apartmentNumber + " " + city + " " + state + " " + zip;
        }
    }

}
