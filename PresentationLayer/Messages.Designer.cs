namespace PresentationLayer
{
    partial class Messages
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
            this.listBox_messages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_messages
            // 
            this.listBox_messages.FormattingEnabled = true;
            this.listBox_messages.ItemHeight = 15;
            this.listBox_messages.Location = new System.Drawing.Point(39, 30);
            this.listBox_messages.Name = "listBox_messages";
            this.listBox_messages.Size = new System.Drawing.Size(718, 364);
            this.listBox_messages.TabIndex = 0;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_messages);
            this.Name = "Messages";
            this.Text = "Messages";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox_messages;
    }
}