using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayRoll_GUI.ClassScripts;

namespace PayRoll_GUI
{
    

    static class Program
    {
        public static List<Employee> PayRoll = new List<Employee>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           
        }

        public static float PayEmployees()
        {
            float TotalPaid = 0;
            foreach (Employee employee in PayRoll)
            {
                TotalPaid += employee.Pay();
            }
            return TotalPaid;
        }
    }

}
