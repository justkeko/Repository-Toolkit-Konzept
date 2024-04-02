namespace Repository_Toolkit_Konzept
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            LeftDock = new System.Windows.Forms.Panel();
            ExtraFuncHolder = new System.Windows.Forms.Panel();
            btnPatch = new System.Windows.Forms.Button();
            btnHelp = new System.Windows.Forms.Button();
            btnBrowser = new System.Windows.Forms.Button();
            btnVersionDelete = new System.Windows.Forms.Button();
            btnCheckin = new System.Windows.Forms.Button();
            btnCheckout = new System.Windows.Forms.Button();
            ColorBar = new System.Windows.Forms.Panel();
            ImageHolder = new System.Windows.Forms.Panel();
            RepoToolkit = new System.Windows.Forms.Label();
            Dp_Logo = new System.Windows.Forms.PictureBox();
            DpLogo = new System.Windows.Forms.ImageList(components);
            tooltipBrowser = new System.Windows.Forms.ToolTip(components);
            tooltipHelp = new System.Windows.Forms.ToolTip(components);
            tooltipPatch = new System.Windows.Forms.ToolTip(components);
            panelDesktop = new System.Windows.Forms.Panel();
            LeftDock.SuspendLayout();
            ExtraFuncHolder.SuspendLayout();
            ImageHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dp_Logo).BeginInit();
            SuspendLayout();
            // 
            // LeftDock
            // 
            LeftDock.BackColor = System.Drawing.Color.LightGray;
            LeftDock.Controls.Add(ExtraFuncHolder);
            LeftDock.Controls.Add(btnVersionDelete);
            LeftDock.Controls.Add(btnCheckin);
            LeftDock.Controls.Add(btnCheckout);
            LeftDock.Controls.Add(ColorBar);
            LeftDock.Controls.Add(ImageHolder);
            LeftDock.Dock = System.Windows.Forms.DockStyle.Left;
            LeftDock.Location = new System.Drawing.Point(0, 0);
            LeftDock.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            LeftDock.Name = "LeftDock";
            LeftDock.Size = new System.Drawing.Size(246, 1005);
            LeftDock.TabIndex = 0;
            // 
            // ExtraFuncHolder
            // 
            ExtraFuncHolder.Controls.Add(btnPatch);
            ExtraFuncHolder.Controls.Add(btnHelp);
            ExtraFuncHolder.Controls.Add(btnBrowser);
            ExtraFuncHolder.Location = new System.Drawing.Point(0, 935);
            ExtraFuncHolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ExtraFuncHolder.Name = "ExtraFuncHolder";
            ExtraFuncHolder.Size = new System.Drawing.Size(246, 65);
            ExtraFuncHolder.TabIndex = 1;
            // 
            // btnPatch
            // 
            btnPatch.Dock = System.Windows.Forms.DockStyle.Left;
            btnPatch.FlatAppearance.BorderSize = 0;
            btnPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPatch.Font = new System.Drawing.Font("Candara", 11.25F);
            btnPatch.Image = (System.Drawing.Image)resources.GetObject("btnPatch.Image");
            btnPatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPatch.Location = new System.Drawing.Point(162, 0);
            btnPatch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnPatch.Name = "btnPatch";
            btnPatch.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            btnPatch.Size = new System.Drawing.Size(81, 65);
            btnPatch.TabIndex = 7;
            btnPatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tooltipPatch.SetToolTip(btnPatch, " ");
            btnPatch.UseVisualStyleBackColor = true;
            btnPatch.Click += btnPatch_Click;
            btnPatch.Leave += btnPatch_Leave;
            // 
            // btnHelp
            // 
            btnHelp.Dock = System.Windows.Forms.DockStyle.Left;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHelp.Font = new System.Drawing.Font("Candara", 11.25F);
            btnHelp.Image = (System.Drawing.Image)resources.GetObject("btnHelp.Image");
            btnHelp.Location = new System.Drawing.Point(81, 0);
            btnHelp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 11, 0);
            btnHelp.Size = new System.Drawing.Size(81, 65);
            btnHelp.TabIndex = 6;
            btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tooltipHelp.SetToolTip(btnHelp, " ");
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            btnHelp.Leave += btnHelp_Leave;
            // 
            // btnBrowser
            // 
            btnBrowser.Dock = System.Windows.Forms.DockStyle.Left;
            btnBrowser.FlatAppearance.BorderSize = 0;
            btnBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBrowser.Font = new System.Drawing.Font("Candara", 11.25F);
            btnBrowser.Image = (System.Drawing.Image)resources.GetObject("btnBrowser.Image");
            btnBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBrowser.Location = new System.Drawing.Point(0, 0);
            btnBrowser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            btnBrowser.Size = new System.Drawing.Size(81, 65);
            btnBrowser.TabIndex = 5;
            btnBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tooltipBrowser.SetToolTip(btnBrowser, " ");
            btnBrowser.UseVisualStyleBackColor = true;
            // 
            // btnVersionDelete
            // 
            btnVersionDelete.Dock = System.Windows.Forms.DockStyle.Top;
            btnVersionDelete.FlatAppearance.BorderSize = 0;
            btnVersionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVersionDelete.Font = new System.Drawing.Font("Candara", 11.25F);
            btnVersionDelete.Image = (System.Drawing.Image)resources.GetObject("btnVersionDelete.Image");
            btnVersionDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnVersionDelete.Location = new System.Drawing.Point(0, 485);
            btnVersionDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnVersionDelete.Name = "btnVersionDelete";
            btnVersionDelete.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            btnVersionDelete.Size = new System.Drawing.Size(246, 155);
            btnVersionDelete.TabIndex = 7;
            btnVersionDelete.Text = "Paket löschen";
            btnVersionDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVersionDelete.UseVisualStyleBackColor = true;
            btnVersionDelete.Click += btnVersionDelete_Click;
            btnVersionDelete.Leave += btnVersionDelete_Leave;
            // 
            // btnCheckin
            // 
            btnCheckin.Dock = System.Windows.Forms.DockStyle.Top;
            btnCheckin.FlatAppearance.BorderSize = 0;
            btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckin.Font = new System.Drawing.Font("Candara", 11.25F);
            btnCheckin.Image = (System.Drawing.Image)resources.GetObject("btnCheckin.Image");
            btnCheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCheckin.Location = new System.Drawing.Point(0, 330);
            btnCheckin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnCheckin.Name = "btnCheckin";
            btnCheckin.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            btnCheckin.Size = new System.Drawing.Size(246, 155);
            btnCheckin.TabIndex = 6;
            btnCheckin.Text = "Paket-Checkin";
            btnCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCheckin.UseVisualStyleBackColor = true;
            btnCheckin.Click += btnCheckin_Click;
            btnCheckin.Leave += btnCheckin_Leave;
            // 
            // btnCheckout
            // 
            btnCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckout.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCheckout.Image = (System.Drawing.Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCheckout.Location = new System.Drawing.Point(0, 175);
            btnCheckout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            btnCheckout.Size = new System.Drawing.Size(246, 155);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "Paket-Checkout";
            btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            btnCheckout.Leave += btnCheckout_Leave;
            // 
            // ColorBar
            // 
            ColorBar.BackColor = System.Drawing.Color.FromArgb(177, 19, 28);
            ColorBar.ForeColor = System.Drawing.SystemColors.ControlText;
            ColorBar.Location = new System.Drawing.Point(0, 993);
            ColorBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ColorBar.Name = "ColorBar";
            ColorBar.Size = new System.Drawing.Size(244, 12);
            ColorBar.TabIndex = 1;
            // 
            // ImageHolder
            // 
            ImageHolder.Controls.Add(RepoToolkit);
            ImageHolder.Controls.Add(Dp_Logo);
            ImageHolder.Dock = System.Windows.Forms.DockStyle.Top;
            ImageHolder.Location = new System.Drawing.Point(0, 0);
            ImageHolder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            ImageHolder.Name = "ImageHolder";
            ImageHolder.Size = new System.Drawing.Size(246, 175);
            ImageHolder.TabIndex = 1;
            // 
            // RepoToolkit
            // 
            RepoToolkit.AutoSize = true;
            RepoToolkit.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            RepoToolkit.Location = new System.Drawing.Point(31, 110);
            RepoToolkit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            RepoToolkit.Name = "RepoToolkit";
            RepoToolkit.Padding = new System.Windows.Forms.Padding(9, 5, 0, 0);
            RepoToolkit.Size = new System.Drawing.Size(190, 33);
            RepoToolkit.TabIndex = 1;
            RepoToolkit.Text = "Repository-Toolkit";
            RepoToolkit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dp_Logo
            // 
            Dp_Logo.Image = Properties.Resources._2560px_Dataport_Logo_svg;
            Dp_Logo.Location = new System.Drawing.Point(19, 5);
            Dp_Logo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Dp_Logo.Name = "Dp_Logo";
            Dp_Logo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            Dp_Logo.Size = new System.Drawing.Size(207, 100);
            Dp_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Dp_Logo.TabIndex = 0;
            Dp_Logo.TabStop = false;
            // 
            // DpLogo
            // 
            DpLogo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            DpLogo.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("DpLogo.ImageStream");
            DpLogo.TransparentColor = System.Drawing.Color.Transparent;
            DpLogo.Images.SetKeyName(0, "2560px-Dataport_Logo.svg.png");
            // 
            // tooltipBrowser
            // 
            tooltipBrowser.AutomaticDelay = 100;
            tooltipBrowser.AutoPopDelay = 5000;
            tooltipBrowser.InitialDelay = 100;
            tooltipBrowser.ReshowDelay = 20;
            tooltipBrowser.Tag = "";
            tooltipBrowser.ToolTipTitle = "Archiv-Browser";
            // 
            // tooltipHelp
            // 
            tooltipHelp.AutomaticDelay = 100;
            tooltipHelp.AutoPopDelay = 5000;
            tooltipHelp.InitialDelay = 100;
            tooltipHelp.ReshowDelay = 20;
            tooltipHelp.ToolTipTitle = "Hilfecenter";
            // 
            // tooltipPatch
            // 
            tooltipPatch.AutomaticDelay = 100;
            tooltipPatch.AutoPopDelay = 5000;
            tooltipPatch.InitialDelay = 100;
            tooltipPatch.ReshowDelay = 20;
            tooltipPatch.ToolTipTitle = "Patchnotes";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDesktop.Location = new System.Drawing.Point(246, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new System.Drawing.Size(1425, 1005);
            panelDesktop.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1671, 1005);
            Controls.Add(panelDesktop);
            Controls.Add(LeftDock);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1693, 1061);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1693, 1061);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += Main_Load;
            LeftDock.ResumeLayout(false);
            ExtraFuncHolder.ResumeLayout(false);
            ImageHolder.ResumeLayout(false);
            ImageHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dp_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel LeftDock;
        private System.Windows.Forms.ImageList DpLogo;
        private System.Windows.Forms.Panel ImageHolder;
        private System.Windows.Forms.PictureBox Dp_Logo;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnVersionDelete;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label RepoToolkit;
        private System.Windows.Forms.Panel ExtraFuncHolder;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel ColorBar;
        private System.Windows.Forms.ToolTip tooltipBrowser;
        private System.Windows.Forms.ToolTip tooltipHelp;
        private System.Windows.Forms.ToolTip tooltipPatch;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

