using Acme.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acme.GUI
{
    public partial class Form1 : Form
    {
        List<Customer> CustomerStorage = new List<Customer>();

        public Form1()
        {
            InitializeComponent();

            button1.Text = "Spara kund";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer() { Name = textBox1.Text };
            CustomerStorage.Add(c);

            MessageBox.Show("Antal kunder: " + CustomerStorage.Count);
        }
    }

    
}
