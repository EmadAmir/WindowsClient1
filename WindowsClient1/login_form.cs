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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference.Restaurant restaurant = new ServiceReference.Restaurant
            {
                Name = txtName.Text,
                Gender = CmbGender.Text,
                DateOfBirth = dateTimePicker1.Value,
                ContactNumber = Convert.ToInt32(txtContactnumber.Text),
                Password = txtPassword.Text
            };
            ServiceReference.RestaurantWCFServiceClient client = new ServiceReference.RestaurantWCFServiceClient();
            client.SaveDetails(restaurant);
            MessageBox.Show("Saved");
            txtName.Text = " ";
            CmbGender.Text = " ";
            dateTimePicker1.Text = " ";
            txtContactnumber.Text = " ";
            txtPassword.Text = " ";
        }
    }
}
