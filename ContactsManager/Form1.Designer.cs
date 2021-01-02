namespace ContactsManager
{
    partial class Form1
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
            this.ContactsSearchFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContactsSearchFormButton
            // 
            this.ContactsSearchFormButton.Location = new System.Drawing.Point(301, 149);
            this.ContactsSearchFormButton.Name = "ContactsSearchFormButton";
            this.ContactsSearchFormButton.Size = new System.Drawing.Size(192, 95);
            this.ContactsSearchFormButton.TabIndex = 0;
            this.ContactsSearchFormButton.Text = "Contacts Search";
            this.ContactsSearchFormButton.UseVisualStyleBackColor = true;
            this.ContactsSearchFormButton.Click += new System.EventHandler(this.ContactsSearchFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 431);
            this.Controls.Add(this.ContactsSearchFormButton);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ContactsSearchFormButton;
    }
}

