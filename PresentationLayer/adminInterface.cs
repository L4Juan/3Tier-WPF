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
                string operation = Program.businessHandler.AddItem(txt_id.Text, txt_price.Text, txt_stock.Text, txt_offers.Text);
                if (operation == "success")
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
                    if (operation == "id")
                    {
                        MessageBox.Show("Id allready exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (operation == "price")
                    { 
                        MessageBox.Show("Wrong price format. Make sure you use '.' instead of ','.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (operation == "stock")
                    {
                        MessageBox.Show("Wrong stock format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (operation == "offers") 
                    {
                        MessageBox.Show("Wrong offers format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    MessageBox.Show("Unable to add item!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }
        /*
        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult d = DialogResult.No;
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
                d = MessageBox.Show($"Sure you want to change item id from '{item.Item1}' to '{txt_update.Text}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                        return;
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
                }catch {}
                if (double.TryParse(txt_update.Text, out value) && valid1 && valid2) 
                {
                    d = MessageBox.Show($"Sure you want to change price from '{item.Item2}' to '{value}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    item.Item2 = value; 
                }
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
                    d = MessageBox.Show($"Sure you want to change stock for '{item.Item1}' from '{item.Item3}' to '{value}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    item.Item3 = value; 
                }
                else { 
                    MessageBox.Show("Wrong stock format", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else if (colIndex == 3)
            {
                d = MessageBox.Show($"Sure you want to change offers for '{item.Item1}' from '{item.Item4}' to '{txt_update.Text}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                item.Item4 = txt_update.Text;
            }

            
                
            if (d == DialogResult.No)
            {
                return;
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
        */
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_items.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rows selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult d = MessageBox.Show("Are you sure you want to delete ALL selected items?", "ConfirmationRequiered", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView_items.SelectedRows.Count; i++)
                {
                    int rowIndex = dataGridView_items.SelectedRows[i].Index;
                    string itemID = (string)dataGridView_items.Rows[rowIndex].Cells[0].Value;
                    Program.businessHandler.DeleteItem(itemID);
                }
                InitializeDataGridView();
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //check for low stock items and generate warning messages
            //check for out of stock items and order from warehouse
            string[] outOfStockItems = Program.businessHandler.OutOfStockItems();
            if (outOfStockItems.Length > 0)
            {
                DialogResult s = MessageBox.Show($"Next items are out of stock: {string.Join(", ",outOfStockItems)}\nWould you like to restock with warehouse?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (s == DialogResult.Yes)
                {
                    Program.businessHandler.ReStock();
                    InitializeDataGridView();
                }
            }
        }

        private void dataGridView_CellEdit(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult d = DialogResult.No;
            if (dataGridView_items.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
            {
                MessageBox.Show("Update value cannot be null", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            //string itemId = (string)dataGridView_items.Rows[e.RowIndex].Cells[0].Value;
            int itemIndex = e.RowIndex;
            (string, double, int, string) item = Program.businessHandler.GetItemData(itemIndex);

            string newValue = dataGridView_items.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();



            int colIndex = dataGridView_items.SelectedCells[0].ColumnIndex;
            if (colIndex == 0)
            {
                if (item.Item1.ToString() == dataGridView_items.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                {
                    return;
                }

                d = MessageBox.Show($"Sure you want to change item id from '{item.Item1}' to '{newValue}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                item.Item1 = newValue;
            }
            else if (colIndex == 1)
            {
                if (item.Item1.ToString() == dataGridView_items.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                {
                    return;
                }

                
                bool valid1 = false;
                bool valid2 = false;
                if (double.TryParse(newValue, out double value))
                {
                    if (newValue.Contains(','))
                    {
                        MessageBox.Show("Wrong price format. Please use '.' instead of ','.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                try
                {
                    string[] separated = newValue.Split('.');
                    valid1 = separated.Length < 3;

                    if (separated.Length == 2)
                    {
                        valid2 = separated[1].Length < 3;
                    }
                    else if (separated.Length == 1)
                    {
                        valid2 = true;
                    }
                }
                catch { }
                if (double.TryParse(newValue, out value) && valid1 && valid2)
                {
                    d = MessageBox.Show($"Sure you want to change price for '{item.Item2}' from '{item.Item2}' to '{newValue}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    item.Item2 = value;
                }
                else
                {
                    MessageBox.Show("Wrong price format", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (colIndex == 2)
            {
                
                if (int.TryParse(newValue, out int value))
                {
                    d = MessageBox.Show($"Sure you want to change stock for '{item.Item1}' from '{item.Item3}' to '{newValue}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    item.Item3 = value;
                }
                else
                {
                    MessageBox.Show("Wrong stock format", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else if (colIndex == 3)
            {
                d = MessageBox.Show($"Sure you want to change offers for '{item.Item1}' from '{item.Item4}' to '{newValue}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                item.Item4 = newValue;
            }



            if (d == DialogResult.No)
            {
                return;
            }
            if (Program.businessHandler.updateItem(itemIndex, colIndex, item))
            {
                InitializeDataGridView();
                MessageBox.Show("Item updated succesfuly!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newValue = "";
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
            InitializeDataGridView();
        }

    }
}
