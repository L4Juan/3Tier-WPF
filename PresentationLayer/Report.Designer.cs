namespace PresentationLayer
{
    partial class Report
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
            this.listBox_orders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_orders
            // 
            this.listBox_orders.FormattingEnabled = true;
            this.listBox_orders.ItemHeight = 15;
            this.listBox_orders.Location = new System.Drawing.Point(62, 53);
            this.listBox_orders.Name = "listBox_orders";
            this.listBox_orders.Size = new System.Drawing.Size(510, 304);
            this.listBox_orders.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_orders);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox_orders;
    }
}