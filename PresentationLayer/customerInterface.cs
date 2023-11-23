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
    public partial class customerInterface : Form
    {
        public customerInterface()
        {
            InitializeComponent();
        }
        private void btn_backFromCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

    }
}
