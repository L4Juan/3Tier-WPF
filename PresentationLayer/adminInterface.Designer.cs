﻿namespace PresentationLayer
{
    partial class adminInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_offers = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.btn_backFromAdmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_messages = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(577, 79);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 0;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(577, 108);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 23);
            this.txt_price.TabIndex = 1;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(577, 137);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 23);
            this.txt_stock.TabIndex = 2;
            // 
            // txt_offers
            // 
            this.txt_offers.Location = new System.Drawing.Point(577, 166);
            this.txt_offers.Name = "txt_offers";
            this.txt_offers.Size = new System.Drawing.Size(100, 23);
            this.txt_offers.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(602, 195);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "stock :";
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Location = new System.Drawing.Point(12, 66);
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.RowTemplate.Height = 25;
            this.dataGridView_items.Size = new System.Drawing.Size(435, 319);
            this.dataGridView_items.TabIndex = 6;
            this.dataGridView_items.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEdit);
            // 
            // btn_backFromAdmin
            // 
            this.btn_backFromAdmin.Location = new System.Drawing.Point(12, 12);
            this.btn_backFromAdmin.Name = "btn_backFromAdmin";
            this.btn_backFromAdmin.Size = new System.Drawing.Size(75, 23);
            this.btn_backFromAdmin.TabIndex = 7;
            this.btn_backFromAdmin.Text = "Home";
            this.btn_backFromAdmin.UseVisualStyleBackColor = true;
            this.btn_backFromAdmin.Click += new System.EventHandler(this.btn_backFromAdmin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "offers :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "select row(s) to delete item (s)  ";
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(330, 400);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteItem.TabIndex = 16;
            this.btn_deleteItem.Text = "delete item";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(602, 378);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 17;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "You can update items by changing them in the table";
            // 
            // btn_messages
            // 
            this.btn_messages.Location = new System.Drawing.Point(517, 317);
            this.btn_messages.Name = "btn_messages";
            this.btn_messages.Size = new System.Drawing.Size(75, 23);
            this.btn_messages.TabIndex = 19;
            this.btn_messages.Text = "Messages";
            this.btn_messages.UseVisualStyleBackColor = true;
            this.btn_messages.Click += new System.EventHandler(this.btn_messages_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(598, 317);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(79, 23);
            this.btn_customers.TabIndex = 20;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // adminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_messages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_deleteItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_backFromAdmin);
            this.Controls.Add(this.dataGridView_items);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_offers);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_id);
            this.Name = "adminInterface";
            this.Text = "adminInterface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private TextBox txt_id;
        private TextBox txt_stock;
        private TextBox txt_price;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView_items;
        private Button btn_backFromAdmin;
        private Label label4;
        private TextBox txt_offers;
        private Button btn_add;
        private Button btn_update;
        private TextBox txt_update;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_deleteItem;
        private Button btn_refresh;
        private Button btn_messages;
        private Button btn_customers;
    }
}