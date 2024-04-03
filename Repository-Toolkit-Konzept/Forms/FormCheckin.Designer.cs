namespace Repository_Toolkit_Konzept
{
    partial class FormCheckin
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
            BoxOptionen = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            comboBox4 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            comboBox3 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            BoxUmgebung = new System.Windows.Forms.GroupBox();
            Left = new System.Windows.Forms.Panel();
            cbEntw = new System.Windows.Forms.CheckBox();
            cbTest = new System.Windows.Forms.CheckBox();
            cbProd = new System.Windows.Forms.CheckBox();
            cbStvmv = new System.Windows.Forms.CheckBox();
            Right = new System.Windows.Forms.Panel();
            cbSCCM = new System.Windows.Forms.CheckBox();
            BoxInfo = new System.Windows.Forms.GroupBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            label7 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            btnReset = new System.Windows.Forms.Button();
            btnCheck_in = new System.Windows.Forms.Button();
            BoxOptionen.SuspendLayout();
            BoxUmgebung.SuspendLayout();
            Left.SuspendLayout();
            Right.SuspendLayout();
            BoxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // BoxOptionen
            // 
            BoxOptionen.Controls.Add(label4);
            BoxOptionen.Controls.Add(comboBox4);
            BoxOptionen.Controls.Add(label3);
            BoxOptionen.Controls.Add(comboBox3);
            BoxOptionen.Controls.Add(label2);
            BoxOptionen.Controls.Add(comboBox2);
            BoxOptionen.Controls.Add(label1);
            BoxOptionen.Controls.Add(comboBox1);
            BoxOptionen.Location = new System.Drawing.Point(176, 28);
            BoxOptionen.Name = "BoxOptionen";
            BoxOptionen.Size = new System.Drawing.Size(293, 259);
            BoxOptionen.TabIndex = 1;
            BoxOptionen.TabStop = false;
            BoxOptionen.Text = "Paket-Optionen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 15);
            label4.TabIndex = 7;
            label4.Text = "Paketversion wählen:";
            // 
            // comboBox4
            // 
            comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(17, 208);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(253, 23);
            comboBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 137);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Paket wählen:";
            // 
            // comboBox3
            // 
            comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(17, 155);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(253, 23);
            comboBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Ordner wählen:";
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(17, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(253, 23);
            comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Option wählen:";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(17, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(253, 23);
            comboBox1.TabIndex = 0;
            // 
            // BoxUmgebung
            // 
            BoxUmgebung.Controls.Add(Left);
            BoxUmgebung.Controls.Add(Right);
            BoxUmgebung.Location = new System.Drawing.Point(176, 319);
            BoxUmgebung.Name = "BoxUmgebung";
            BoxUmgebung.Size = new System.Drawing.Size(293, 150);
            BoxUmgebung.TabIndex = 2;
            BoxUmgebung.TabStop = false;
            BoxUmgebung.Text = "Umgebungen";
            // 
            // Left
            // 
            Left.Controls.Add(cbEntw);
            Left.Controls.Add(cbTest);
            Left.Controls.Add(cbProd);
            Left.Controls.Add(cbStvmv);
            Left.Location = new System.Drawing.Point(63, 43);
            Left.Name = "Left";
            Left.Size = new System.Drawing.Size(88, 76);
            Left.TabIndex = 6;
            // 
            // cbEntw
            // 
            cbEntw.AutoSize = true;
            cbEntw.Dock = System.Windows.Forms.DockStyle.Top;
            cbEntw.Location = new System.Drawing.Point(0, 57);
            cbEntw.Name = "cbEntw";
            cbEntw.Size = new System.Drawing.Size(88, 19);
            cbEntw.TabIndex = 0;
            cbEntw.Text = "DCSENTW";
            cbEntw.UseVisualStyleBackColor = true;
            // 
            // cbTest
            // 
            cbTest.AutoSize = true;
            cbTest.Dock = System.Windows.Forms.DockStyle.Top;
            cbTest.Location = new System.Drawing.Point(0, 38);
            cbTest.Name = "cbTest";
            cbTest.Size = new System.Drawing.Size(88, 19);
            cbTest.TabIndex = 1;
            cbTest.Text = "DCSTEST";
            cbTest.UseVisualStyleBackColor = true;
            // 
            // cbProd
            // 
            cbProd.AutoSize = true;
            cbProd.Dock = System.Windows.Forms.DockStyle.Top;
            cbProd.Location = new System.Drawing.Point(0, 19);
            cbProd.Name = "cbProd";
            cbProd.Size = new System.Drawing.Size(88, 19);
            cbProd.TabIndex = 2;
            cbProd.Text = "DCSPROD";
            cbProd.UseVisualStyleBackColor = true;
            // 
            // cbStvmv
            // 
            cbStvmv.AutoSize = true;
            cbStvmv.Dock = System.Windows.Forms.DockStyle.Top;
            cbStvmv.Location = new System.Drawing.Point(0, 0);
            cbStvmv.Name = "cbStvmv";
            cbStvmv.Size = new System.Drawing.Size(88, 19);
            cbStvmv.TabIndex = 3;
            cbStvmv.Text = "DCSSTVMV";
            cbStvmv.UseVisualStyleBackColor = true;
            // 
            // Right
            // 
            Right.Controls.Add(cbSCCM);
            Right.Location = new System.Drawing.Point(157, 43);
            Right.Name = "Right";
            Right.Size = new System.Drawing.Size(92, 76);
            Right.TabIndex = 7;
            // 
            // cbSCCM
            // 
            cbSCCM.AutoSize = true;
            cbSCCM.Dock = System.Windows.Forms.DockStyle.Top;
            cbSCCM.Location = new System.Drawing.Point(0, 0);
            cbSCCM.Name = "cbSCCM";
            cbSCCM.Size = new System.Drawing.Size(92, 19);
            cbSCCM.TabIndex = 4;
            cbSCCM.Text = "SCCM";
            cbSCCM.UseVisualStyleBackColor = true;
            // 
            // BoxInfo
            // 
            BoxInfo.Controls.Add(checkBox1);
            BoxInfo.Controls.Add(label7);
            BoxInfo.Controls.Add(textBox3);
            BoxInfo.Controls.Add(label6);
            BoxInfo.Controls.Add(textBox2);
            BoxInfo.Controls.Add(label5);
            BoxInfo.Controls.Add(textBox1);
            BoxInfo.Location = new System.Drawing.Point(508, 28);
            BoxInfo.Name = "BoxInfo";
            BoxInfo.Size = new System.Drawing.Size(331, 441);
            BoxInfo.TabIndex = 3;
            BoxInfo.TabStop = false;
            BoxInfo.Text = "Information zum Paket";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(30, 391);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(142, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "In E-Mail aufnehmen?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(30, 321);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(117, 15);
            label7.TabIndex = 5;
            label7.Text = "Version der Software:";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(30, 344);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(271, 23);
            textBox3.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(30, 101);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 15);
            label6.TabIndex = 3;
            label6.Text = "Bemerkung :";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(30, 124);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(271, 172);
            textBox2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(30, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(155, 15);
            label5.TabIndex = 1;
            label5.Text = "Auftragsnummer / Incident:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(30, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(271, 23);
            textBox1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            btnReset.FlatAppearance.BorderSize = 2;
            btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReset.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            btnReset.ForeColor = System.Drawing.Color.Red;
            btnReset.Location = new System.Drawing.Point(175, 502);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(294, 44);
            btnReset.TabIndex = 4;
            btnReset.Text = "Zurücksetzen";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCheck_in
            // 
            btnCheck_in.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            btnCheck_in.FlatAppearance.BorderSize = 2;
            btnCheck_in.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            btnCheck_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            btnCheck_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheck_in.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            btnCheck_in.ForeColor = System.Drawing.Color.ForestGreen;
            btnCheck_in.Location = new System.Drawing.Point(508, 502);
            btnCheck_in.Name = "btnCheck_in";
            btnCheck_in.Size = new System.Drawing.Size(331, 44);
            btnCheck_in.TabIndex = 5;
            btnCheck_in.Text = "CHECK IN";
            btnCheck_in.UseVisualStyleBackColor = true;
            btnCheck_in.Click += btnCheck_in_Click;
            // 
            // FormCheckin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(986, 562);
            Controls.Add(btnCheck_in);
            Controls.Add(btnReset);
            Controls.Add(BoxInfo);
            Controls.Add(BoxUmgebung);
            Controls.Add(BoxOptionen);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "FormCheckin";
            Text = "FormCheckin";
            BoxOptionen.ResumeLayout(false);
            BoxOptionen.PerformLayout();
            BoxUmgebung.ResumeLayout(false);
            Left.ResumeLayout(false);
            Left.PerformLayout();
            Right.ResumeLayout(false);
            Right.PerformLayout();
            BoxInfo.ResumeLayout(false);
            BoxInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox BoxOptionen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox BoxUmgebung;
        private System.Windows.Forms.GroupBox BoxInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox cbSCCM;
        private System.Windows.Forms.CheckBox cbStvmv;
        private System.Windows.Forms.CheckBox cbProd;
        private System.Windows.Forms.CheckBox cbTest;
        private System.Windows.Forms.CheckBox cbEntw;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCheck_in;
        private System.Windows.Forms.Panel Left;
        private System.Windows.Forms.Panel Right;
    }
}