﻿namespace ReadFiles
{
    partial class ReaderApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.isEncrypted = new System.Windows.Forms.CheckBox();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.enableSecurity = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenFile);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(660, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 133);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(849, 423);
            this.textBox2.TabIndex = 2;
            // 
            // isEncrypted
            // 
            this.isEncrypted.AutoSize = true;
            this.isEncrypted.Location = new System.Drawing.Point(75, 98);
            this.isEncrypted.Name = "isEncrypted";
            this.isEncrypted.Size = new System.Drawing.Size(90, 17);
            this.isEncrypted.TabIndex = 3;
            this.isEncrypted.Text = "EncryptedFile";
            this.isEncrypted.UseVisualStyleBackColor = true;
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(236, 98);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(121, 21);
            this.roleBox.TabIndex = 4;
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.RoleChanged);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(422, 105);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(61, 13);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "Current role";
            // 
            // enableSecurity
            // 
            this.enableSecurity.AutoSize = true;
            this.enableSecurity.Location = new System.Drawing.Point(574, 98);
            this.enableSecurity.Name = "enableSecurity";
            this.enableSecurity.Size = new System.Drawing.Size(100, 17);
            this.enableSecurity.TabIndex = 6;
            this.enableSecurity.Text = "Enable Security";
            this.enableSecurity.UseVisualStyleBackColor = true;
            // 
            // ReaderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 601);
            this.Controls.Add(this.enableSecurity);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.isEncrypted);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "ReaderApp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox isEncrypted;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.CheckBox enableSecurity;
    }
}

