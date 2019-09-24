using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM2
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList CustomerList = new System.Collections.ArrayList();
        string firstName;
        string surname;
        string phone;
        string email;
        string fullName;
        bool Favorite = false;
        public Form1()
        {
            InitializeComponent();
        }

        // Add button
        private void Button2_Click(object sender, EventArgs e)
        {
            CustomerList.Add(new Customer() { FirstName = firstName, Surname = surname, Email = email, Fullname = fullName, Phone = phone , });
        }

        // Show list button
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        //First Name input textbox

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        //Surname input textbox
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Email input textbox
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Phone input textbox
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //Favorite option
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
