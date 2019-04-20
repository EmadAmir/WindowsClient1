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
    public partial class NEWUSE : Form
    {
        public NEWUSE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference.Restaurant restaurant = new ServiceReference.Restaurant();
            restaurant.Name = txtName.Text;
            restaurant.Gender = CmbGender.Text;
            restaurant.DateOfBirth = dateTimePicker1.Value;
            restaurant.ContactNumber = Convert.ToInt32(txtContactnumber.Text);
            ServiceReference.RestaurantWCFServiceClient client = new ServiceReference.RestaurantWCFServiceClient();
            client.SaveDetails(restaurant);
            MessageBox.Show("Saved");
            txtName.Text = " ";
            CmbGender.Text = " ";
            dateTimePicker1.Text = " ";
            txtContactnumber.Text = " ";
        }
    }
}
