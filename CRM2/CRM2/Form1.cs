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
        public Form1()
        {
            InitializeComponent();
        }

        // Add button
        private void Button2_Click(object sender, EventArgs e)
        { bool Favstatus = false;
            if(checkBox1.Checked == true)
            {
                Favstatus = true;
            }
            string fullName = textBox1.Text + " " + textBox2.Text;
            CustomerList.Add(new Customer()
            {
                FirstName = textBox1.Text,
                Surname = textBox2.Text,
                Email = textBox3.Text,
                Fullname = fullName,
                Phone = textBox4.Text,
                Favorite = Favstatus
            });
            string listmessage = "Customer " + fullName + " has been added";
            listBox1.Items.Add(listmessage);


        }

        // Show list button
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        //First Name input textbox = textBox1
        //Surname input textbox = textBox2
        // Email input textbox = textBox3
        //Phone input textbox = textBox4

        //Favorite option
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
