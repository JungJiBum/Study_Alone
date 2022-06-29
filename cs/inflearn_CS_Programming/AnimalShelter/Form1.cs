using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Customer Cus1;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateCustomer_Click(object sender, EventArgs e)
        {

            Cus1 = new Customer(CusNewFirstName.Text,CusNewLastName.Text,
                                                DateTime.Parse(CusNewBirthday.Text));
            Cus1.Address = CusNewAddress.Text;
            Cus1.Description = CusNewDescription.Text;
            
            CusFullName.Text = Cus1.FullName;
            CusAge.Text = Cus1.Age.ToString();
            CusAddress.Text = Cus1.Address;
            CusDescription.Text = Cus1.Description;
            CusIsQualified.Text = Cus1.IsQualified.ToString();
            bool test = Cus1.IsQualified;
       }
        

    }
}
