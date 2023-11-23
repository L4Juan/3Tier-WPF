namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string pwd = txt_pwd.Text;
            Program.businessHandler = new BusinessLayer.HandlerBusiness(id, pwd);
            if (Program.businessHandler.getUserType() == "admin")
            {
                Hide();
                new adminInterface().Show();
            }
            else if (Program.businessHandler.getUserType() == "customer")
            {
                Hide();
                new customerInterface().Show();
            }
            else
            {
                MessageBox.Show("Incorrect log in datails!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}