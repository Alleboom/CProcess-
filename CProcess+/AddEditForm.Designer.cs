namespace CProcess_
{
    partial class AddEditForm
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.butBrowse = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(13, 13);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(322, 22);
            this.textName.TabIndex = 0;
            this.textName.Text = "Name";
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(13, 42);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(322, 22);
            this.textLocation.TabIndex = 1;
            this.textLocation.Text = "Location";
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(341, 42);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(75, 23);
            this.butBrowse.TabIndex = 2;
            this.butBrowse.Text = "Browse";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(342, 13);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 3;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 84);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butBrowse);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.textName);
            this.Name = "AddEditForm";
            this.Text = "Add/Edit Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.Button butAdd;
    }
}