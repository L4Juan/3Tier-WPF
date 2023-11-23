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
    public partial class adminInterface : Form
    {
        public adminInterface()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            List<Item> items = new List<Item>();
            int numOfItems = Program.businessHandler.GetNumOfItems();
            for (int i = 0; i < numOfItems; i++)
            {
                (string, double, int, string) data = Program.businessHandler.GetItemData(i);
                items.Add(new Item(data.Item1, data.Item2, data.Item3, data.Item4));
            }
            dataGridView_items.DataSource = items;
        }

        private void btn_backFromAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != null)
            {
                if (Program.businessHandler.AddItem(txt_id.Text, txt_price.Text, txt_stock.Text, txt_offers.Text))
                {
                    InitializeDataGridView();
                    MessageBox.Show("Item added succesfuly!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_id.Text = "";
                    txt_price.Text = "";
                    txt_offers.Text = "";
                    txt_stock.Text = "";
                }
                else
                {
                    MessageBox.Show("Unable to add item!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_update.Text == "")
            {
                MessageBox.Show("Update value cannot be null", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string itemId = (string)dataGridView_items.Rows[dataGridView_items.SelectedCells[0].RowIndex].Cells[0].Value;
            int itemIndex = Program.businessHandler.GetItemIndex(itemId);
            (string, double, int, string) item = Program.businessHandler.GetItemData(itemIndex);

            int colIndex = dataGridView_items.SelectedCells[0].ColumnIndex;
            if (colIndex == 0)
            {
                item.Item1 = txt_update.Text;
            }
            else if (colIndex == 1)
            {
                bool valid1 = false;
                bool valid2 = false;
                if (double.TryParse(txt_update.Text, out double value))
                {
                    if (txt_update.Text.Contains(','))
                    {
                        MessageBox.Show("Wrong price format. Please use '.' instead of ','.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return ;
                    }
                }
                try
                {
                    string[] separated = txt_update.Text.Split('.');
                    valid1 = separated.Length < 3;
                    
                    if (separated.Length == 2)
                    {
                        valid2 = separated[1].Length < 3;
                    }
                    else if (separated.Length == 1)
                    {
                        valid2 = true;
                    }
                }catch (Exception ex) {}
                if (double.TryParse(txt_update.Text, out value) && valid1 && valid2) { item.Item2 = value; }
                else
                {
                    MessageBox.Show("Wrong price format", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (colIndex == 2)
            {
                if(int.TryParse(txt_update.Text, out int value)) 
                {
                    item.Item3 = value; 
                }
                else { 
                    MessageBox.Show("Wrong stock format", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else if (colIndex == 3)
            {
                item.Item4 = txt_update.Text;
            }

            if (Program.businessHandler.updateItem(itemIndex, colIndex, item))
            {
                InitializeDataGridView();
                MessageBox.Show("Item updated succesfuly!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_update.Text = "";
            }
            else
            {
                if (colIndex == 0)
                {
                    MessageBox.Show("Unable to update. Make sure id is unique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (colIndex == 3)
                {
                    MessageBox.Show("Unable to update. Make sure offers are valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Unable to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }

     
    }
        
}
