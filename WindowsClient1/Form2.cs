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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NEWUSE nu = new NEWUSE();
            nu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
