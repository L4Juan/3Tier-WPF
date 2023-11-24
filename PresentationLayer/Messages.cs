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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
            listBox_messages.Items.Clear();
            string[] messages = Program.businessHandler.GetMessages();
            listBox_messages.DataSource = messages;
        }
    }
}
