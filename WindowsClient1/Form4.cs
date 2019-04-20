using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = " ";
            txtUserName.Text = " ";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ServiceReference.Restaurant rest = new ServiceReference.Restaurant();
            rest.Name = txtUserName.Text;
            rest.ContactNumber = int.Parse(txtUserName.Text);
            ServiceReference.RestaurantWCFServiceClient client = new ServiceReference.RestaurantWCFServiceClient();
            if (Convert.ToInt32(client.Login()) == 1)
            {
                MessageBox.Show("test");
            }


            //ServiceReference.Restaurant rest = client.Login();
            //if (txtUserName.Text == rest.Name && txtPassword.Text == ((rest.ContactNumber).ToString()))
            //{
            //    Menu m = new Menu();
            //    m.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("incorrect User Name and Password");
            //}
          
        }
    }
}
