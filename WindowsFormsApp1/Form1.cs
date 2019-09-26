using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // auto generated code created by double clicking on form
        private void Form1_Load(object sender, EventArgs e)
        {
            // would put a call to a method in here that would run on form load
        }
        // on button click 
        private void button1_Click(object sender, EventArgs e)
        {
            //calls the SayHello method when the button is pressed
            helloWorld();  
        }
        // method to creat a message box with a message displayeed inside
        public void helloWorld()
        {
            MessageBox.Show("Hello World! Click OK to exit");
        }
    }
}
