using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsClient1
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
            //LoginPassword.PasswordChar = '*';
            txtPass.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                ServiceReference.Restaurant restaurant = new ServiceReference.Restaurant
                {

                    Name = txtName.Text,
                    Gender = CmbGender.Text,
                  // DateOfBirth = dateTimePicker1.Value,
                    Psw = txtPass.Text
                };
          
            ServiceReference.RestaurantWCFServiceClient client = new ServiceReference.RestaurantWCFServiceClient();
            client.SaveDetails(restaurant);
            MessageBox.Show("Saved");
            MessageBox.Show(restaurant.Psw);
           
            txtName.Text = " ";
            CmbGender.Text = " ";
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            txtPass.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = " ";
            CmbGender.Text = " ";
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            txtPass.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference.Restaurant restaurant = new ServiceReference.Restaurant
            {

                Name = LoginUserName.Text,
                
                Psw = LoginPassword.Text
            };
            ServiceReference.RestaurantWCFServiceClient client = new ServiceReference.RestaurantWCFServiceClient();
            client.Login(restaurant);
            if (restaurant.flag == 1)
            {
                MessageBox.Show("Hi "+restaurant.Name+",\n"+"Welcome to My Cafe");
            }
            else
            {
                MessageBox.Show("Your UserName and Password are incorrect try again or create a new account");
            }
            LoginUserName.Text = " ";
            LoginPassword.Text = " ";
        }
    }
}
