using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CustomerOrder : Form
    {
        public CustomerOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.businessHandler.PlaceOrder();
            MessageBox.Show("Order made succesfully");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Close();
            new Form1().Show();
        }
    }
}
