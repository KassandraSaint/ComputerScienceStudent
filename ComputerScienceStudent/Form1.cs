using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScienceStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hoursBtn_Click(object sender, EventArgs e)
        {
            // Initializing variables to hold user's input
            string name, id, track;

            // Getting user's input and storing it in the appropriate variables
            name = nameBox.Text;
            id = idBox.Text;

            // Getting user's radio button choice and storing it in a variable
            if (infoSysRadio.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            // Creating a computer science object
            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            // Displaying studen't required hours
            hoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
