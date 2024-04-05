namespace Repository_Toolkit_Konzept
{
    partial class FormPatch
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
            lblPatchnotes = new System.Windows.Forms.Label();
            lblTrennlinie = new System.Windows.Forms.Label();
            PatchBackground = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // lblPatchnotes
            // 
            lblPatchnotes.AutoSize = true;
            lblPatchnotes.Font = new System.Drawing.Font("Segoe UI", 19F);
            lblPatchnotes.Location = new System.Drawing.Point(118, 53);
            lblPatchnotes.Name = "lblPatchnotes";
            lblPatchnotes.Size = new System.Drawing.Size(148, 36);
            lblPatchnotes.TabIndex = 0;
            lblPatchnotes.Text = "Patchnotes:";
            // 
            // lblTrennlinie
            // 
            lblTrennlinie.AutoSize = true;
            lblTrennlinie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblTrennlinie.Location = new System.Drawing.Point(118, 89);
            lblTrennlinie.Name = "lblTrennlinie";
            lblTrennlinie.Size = new System.Drawing.Size(387, 15);
            lblTrennlinie.TabIndex = 1;
            lblTrennlinie.Text = "____________________________________________________________________________";
            // 
            // PatchBackground
            // 
            PatchBackground.BackColor = System.Drawing.Color.Gainsboro;
            PatchBackground.Location = new System.Drawing.Point(118, 129);
            PatchBackground.Name = "PatchBackground";
            PatchBackground.Size = new System.Drawing.Size(757, 387);
            PatchBackground.TabIndex = 2;
            // 
            // FormPatch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(986, 562);
            Controls.Add(PatchBackground);
            Controls.Add(lblPatchnotes);
            Controls.Add(lblTrennlinie);
            Name = "FormPatch";
            Text = "FormPatches";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPatchnotes;
        private System.Windows.Forms.Label lblTrennlinie;
        private System.Windows.Forms.Panel PatchBackground;
    }
}