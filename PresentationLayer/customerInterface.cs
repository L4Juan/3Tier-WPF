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
            InitialiseCustomerGridView();
            
        }
        private void btn_backFromCustomer_Click(object sender, EventArgs e)
        {
            Close();
            new Form1().Show();

            
        }
        private void InitialiseCustomerGridView()
        {
            try
            {
                dataGridView_customer.Columns.Remove(dataGridView_customer.Columns[""]);
            }
            catch { }
            List<Customer> items = new List<Customer>();
            int numOfItems = Program.businessHandler.GetNumOfCustomers();
            for (int i = 0; i < numOfItems; i++)
            {
                (string, int, bool) data = Program.businessHandler.GetCustomerData(i);
                items.Add(new Customer(data.Item1, data.Item2, data.Item3));
            }
            dataGridView_customer.DataSource = items;
            dataGridView_customer.Columns[0].ReadOnly = true;

            dataGridView_customer.Columns[2].ReadOnly = true;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            buttonColumn.HeaderText = "";
            buttonColumn.Text = "Call";
            buttonColumn.UseColumnTextForButtonValue = true;

            dataGridView_customer.Columns.Add(buttonColumn);
        }

        private void dataGridView_CellEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == null)
            {
                InitialiseCustomerGridView();
                MessageBox.Show("Cell cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newValue = (string)dataGridView_customer.Rows[e.RowIndex].Cells["Loyalty"].Value;
            string id = (string)dataGridView_customer.Rows[e.RowIndex].Cells["Id"].Value;
            //change loyalty 
            if (int.TryParse(newValue, out int value))
            {
                if (value >= 0 && value <= 3)
                {
                    Program.businessHandler.UpdateCustomer(id, newValue);
                    InitialiseCustomerGridView();

                }
                else
                {
                    InitialiseCustomerGridView();
                    MessageBox.Show("Loyalty num can only be from 1 to 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                InitialiseCustomerGridView();
                MessageBox.Show("Loyalty num must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            
        }

        private void dataGridView_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_customer.Columns[""].Index)
            {
                string id = (string)dataGridView_customer.Rows[e.RowIndex].Cells["Id"].Value;
                Program.businessHandler.UpdateCustomer(id, "true");
                InitialiseCustomerGridView();
                MessageBox.Show("Enabling approval has been requested.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
