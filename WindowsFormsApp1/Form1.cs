using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class Form1 : Form
    {
        private Contact[] phoneBook = new Contact[1];

        public Form1()
        {
            InitializeComponent();
        }
        private void Write(Contact obj, int x)
        {
            StreamWriter sw = new StreamWriter("Contacts.txt");
            sw.WriteLine(phoneBook.Length + 1);
            sw.WriteLine(obj.FirstName);
            sw.WriteLine(obj.LastName); 
            sw.WriteLine(obj.Phone);
            sw.WriteLine(obj.Email);

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnAddContact_Click(object sender, EventArgs e)
        {
            Contact obj = new Contact();    
            obj.FirstName = txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            obj.Phone = txtPhone.Text;  
            obj.Email = txtEmail.Text;      


            lstContacts.Items.Add(obj.ToString()); 
        }
    }
}
