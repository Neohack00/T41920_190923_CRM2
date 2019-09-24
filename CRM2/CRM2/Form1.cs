using System;
using System.Collections;
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
        ArrayList CustomerList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            CustomerList.Add(new Customer() { Fullname = "Groot" , FirstName = "Groot" , Surname = " ", Email = "Groot@groot.groot" , Favorite = true , Phone = "I am Groot" });
            CustomerList.Add(new Customer() { Fullname = "Neo hack", FirstName = "Neo", Surname = "Hack", Email = "Neohackpower@gmail.com", Favorite = true, Phone = "Unknown" });
            CustomerList.Add(new Customer() { Fullname = "Lucifer Morningstar", FirstName = "Lucifer", Surname = "Morningstar", Email = "Lucifer@Morningstar.hell", Favorite = true, Phone = "666 661 611" });
            CustomerList.Add(new Customer() { Fullname = "God", FirstName = "God", Surname = " ", Email = "God@Allmighty.heaven", Favorite = true , Phone = "331 133 311" });
            CustomerList.Add(new Customer() { Fullname = "Jeff Jeffson", FirstName = "Jeff", Surname = "Jeffson", Email = "Jeffson@gmail.com", Favorite = false, Phone = "070 452 04 58" });
            CustomerList.Add(new Customer() { Fullname = "Neo Bylock", FirstName = "Neo", Surname = "Bylock", Email = "neo@bylock.se", Favorite = false, Phone = "070 778 54 50" });
            CustomerList.Add(new Customer() { Fullname = "Neia Hack", FirstName = "Neia", Surname = "Hack", Email = "Neiahackpower@gmail.com", Favorite = false, Phone = "070 545 08 77" });
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            listBox1.Items.Clear();
            string listmessage = "Customer " + fullName + " has been added";
            listBox1.Items.Add(listmessage);


        }

        // Show list button
        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Customer x in CustomerList)
            {
                listBox1.Items.Add(x.Fullname);
            }
        }

        //First Name input textbox = textBox1
        //Surname input textbox = textBox2
        // Email input textbox = textBox3
        //Phone input textbox = textBox4

    }
}
