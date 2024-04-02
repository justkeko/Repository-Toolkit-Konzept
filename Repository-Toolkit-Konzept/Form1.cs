using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repository_Toolkit_Konzept
{
    public partial class Main : Form
    {
        private Form currentChildForm;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            LeftDock.Height = btnCheckout.Height;
            LeftDock.Top = btnCheckout.Top;
            btnCheckout.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
            OpenChildForm(new FormCheckout());
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            LeftDock.Height = btnCheckin.Height;
            LeftDock.Top = btnCheckin.Top;
            btnCheckin.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
            OpenChildForm(new FormCheckin());
        }

        private void btnVersionDelete_Click(object sender, EventArgs e)
        {
            LeftDock.Height = btnVersionDelete.Height;
            LeftDock.Top = btnVersionDelete.Top;
            btnVersionDelete.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
            OpenChildForm(new FormVersionDelete());
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            LeftDock.Height = btnPatch.Height;
            LeftDock.Top = btnPatch.Top;
            btnPatch.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
            OpenChildForm(new FormPatch());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            LeftDock.Height = btnHelp.Height;
            LeftDock.Top = btnHelp.Top;
            btnHelp.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
            OpenChildForm(new FormHelp());
        }

        private void btnCheckout_Leave(object sender, EventArgs e)
        {
            btnCheckout.BackColor = Color.FromKnownColor(KnownColor.LightGray);
            currentChildForm.Close();
        }

        private void btnCheckin_Leave(object sender, EventArgs e)
        {
            btnCheckin.BackColor = Color.FromKnownColor(KnownColor.LightGray);
            currentChildForm.Close();
        }

        private void btnVersionDelete_Leave(object sender, EventArgs e)
        {
            btnVersionDelete.BackColor = Color.FromKnownColor(KnownColor.LightGray);
            currentChildForm.Close();
        }

        private void btnPatch_Leave(object sender, EventArgs e)
        {
            btnPatch.BackColor = Color.FromKnownColor(KnownColor.LightGray);
            currentChildForm.Close();
        }

        private void btnHelp_Leave(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.FromKnownColor(KnownColor.LightGray);
            currentChildForm.Close();
        }

    }
}
