namespace Repository_Toolkit_Konzept
{
    partial class FormCheckout
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
            repoChoose = new System.Windows.Forms.GroupBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            repoChoose.SuspendLayout();
            SuspendLayout();
            // 
            // repoChoose
            // 
            repoChoose.Controls.Add(comboBox1);
            repoChoose.Location = new System.Drawing.Point(605, 28);
            repoChoose.Margin = new System.Windows.Forms.Padding(2);
            repoChoose.Name = "repoChoose";
            repoChoose.Padding = new System.Windows.Forms.Padding(2);
            repoChoose.Size = new System.Drawing.Size(300, 71);
            repoChoose.TabIndex = 0;
            repoChoose.TabStop = false;
            repoChoose.Text = "Repository wählen:";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Archiv" });
            comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            comboBox1.BackColor = System.Drawing.Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Archiv", "Test-Repository (DEBUG)" });
            comboBox1.Location = new System.Drawing.Point(20, 31);
            comboBox1.Margin = new System.Windows.Forms.Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(257, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new System.Drawing.Point(80, 119);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(825, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paket und Version wählen:";
            // 
            // FormCheckout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(986, 562);
            Controls.Add(groupBox1);
            Controls.Add(repoChoose);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FormCheckout";
            Text = "FormCheckout";
            repoChoose.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox repoChoose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}