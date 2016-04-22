using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShiftAccess
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private string GetVersion()
        {
            return "1.0.0.11";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            lblNome.Text = Application.ProductName + " - versão " + this.GetVersion();
            lblCopyright.Text = "\u00a9 Copyright 2016 - Daniel Carneiro Miranda";
        }

        private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:daniel.c.miranda@terra.com.br");
        }
    }
}
