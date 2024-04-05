namespace Repository_Toolkit_Konzept
{
    partial class FormVersionDelete
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new System.Drawing.Point(186, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(576, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Option wählen:";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Paket";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Paketdateien", "Paketversion", "Paket" });
            comboBox1.Location = new System.Drawing.Point(82, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(419, 23);
            comboBox1.TabIndex = 0;
            // 
            // FormVersionDelete
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(986, 562);
            Controls.Add(groupBox1);
            Name = "FormVersionDelete";
            Text = "FormVersionDelete";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}