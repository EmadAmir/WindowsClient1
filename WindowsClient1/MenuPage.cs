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
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDetailsDataSet5.tblRestaurantMenu' table. You can move, or remove it, as needed.
            this.tblRestaurantMenuTableAdapter.Fill(this.restaurantDetailsDataSet5.tblRestaurantMenu);
            // TODO: This line of code loads data into the 'restaurantDetailsDataSet4.tblRestaurantMenu' table. You can move, or remove it, as needed.
            //this.tblRestaurantMenuTableAdapter.Fill(this.restaurantDetailsDataSet4.tblRestaurantMenu);
            // TODO: This line of code loads data into the 'restaurantDetailsDataSet3.tblRestaurantMenu' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'restaurantDetailsDataSet2.tblRestaurantMenu' table. You can move, or remove it, as needed.
            //Add a CheckBox Column to the DataGridView at the first position.
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, checkBoxColumn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ServiceReference.Restaurant restaurant = new ServiceReference.Restaurant
            //{

            //    price = int.Parse(dataGridView1.SelectedItems[0].SubItems[1].Text);

            //quantity = LoginPassword.Text
            //};
            string message = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    message += Environment.NewLine;
                    message += row.Cells[2].Value.ToString();
              
                }
            }
            label1.Text = message;
            //MessageBox.Show("Selected Values" + message);
        }
    }
}
