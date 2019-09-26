using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_GUI.ClassScripts
{
    public class Employee : Person
    {
        string jobTitle;
        float wage;
        float hoursWorked;
        bool onPayroll;

        public string JobTitle
        {
            get => jobTitle; set
            {
                try
                {
                    jobTitle = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to JobTilte");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public float Wage
        {
            get => wage; set
            {
                try
                {
                    wage = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to Wage");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public float HoursWorked
        {
            get => hoursWorked; set
            {
                try
                {
                    hoursWorked = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to HoursWorked");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }
        public bool OnPayroll
        {
            get => onPayroll; set
            {
                try
                {
                    OnPayroll = value;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Cannot Convert input to wether the emplyoee is on the payroll or not");
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Found");
                    Console.WriteLine(e);

                }
            }
        }

        public Employee() : base()
        {
            jobTitle = "jobTitile";
            wage = 0;
            hoursWorked = 0;
            onPayroll = false;
        }

        public Employee(string firstname, string lastName, long phoneNumber, Address address, string jobTitle, float wage, float hoursWorked, bool onPayroll) : base(firstname, lastName, phoneNumber, address)
        {
            this.jobTitle = jobTitle;
            this.wage = wage;
            this.hoursWorked = hoursWorked;
            this.onPayroll = onPayroll;
        }

        /// <summary>
        /// returns the total pay of the employee
        /// </summary>
        /// <returns></returns>
        public float Pay()
        {
            return wage * hoursWorked;
        }
        public override string ToString()
        {
            string data = base.ToString() + "\n" + "Title: " + jobTitle + ", Wage: " + wage + ", Hours Worked: " + hoursWorked + ", On Payroll: " + onPayroll;
            return data;
        }
    }
}
