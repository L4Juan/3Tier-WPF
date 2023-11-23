namespace PresentationLayer
{
    partial class customerInterface
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
            this.btn_backFromCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_backFromCustomer
            // 
            this.btn_backFromCustomer.Location = new System.Drawing.Point(12, 12);
            this.btn_backFromCustomer.Name = "btn_backFromCustomer";
            this.btn_backFromCustomer.Size = new System.Drawing.Size(75, 23);
            this.btn_backFromCustomer.TabIndex = 0;
            this.btn_backFromCustomer.Text = "Home";
            this.btn_backFromCustomer.UseVisualStyleBackColor = true;
            this.btn_backFromCustomer.Click += new System.EventHandler(this.btn_backFromCustomer_Click);
            // 
            // customerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_backFromCustomer);
            this.Name = "customerInterface";
            this.Text = "customerInterface";
            this.ResumeLayout(false);

        }

        #endregion

    
        private Button btn_backFromCustomer;
    }
}