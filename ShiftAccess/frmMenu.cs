using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Office.Interop.Access.Dao;

namespace ShiftAccess
{
    public partial class frmPrincipal : System.Windows.Forms.Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Destravar(bool valor, DragEventArgs e)
        {
            var caminho = (string[])e.Data.GetData(DataFormats.FileDrop);

            try
            {
                using (new AllowByPassKey(caminho[0], valor))
                {
                    lblResult.BackColor = SystemColors.GradientInactiveCaption;
                    lblResult.Text = caminho[0] + " " + (valor ? "destravado" : "travado") + "!";
                }
                
            }
            catch (Exception err)
            {

                MessageBox.Show("Erro inesperado ou arquivo inválido!\n\n" + err.Message,
                    null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void EvDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblTravar_DragEnter(object sender, DragEventArgs e)
        {
            lblTravar.BackColor = SystemColors.GradientInactiveCaption;
            EvDragEnter(e);
        }

        private void lblTravar_DragDrop(object sender, DragEventArgs e)
        {
            Destravar(false, e);
            lblTravar.BackColor = SystemColors.Control;
        }

        private void lblDestravar_DragEnter(object sender, DragEventArgs e)
        {
            lblDestravar.BackColor = SystemColors.GradientInactiveCaption;
            EvDragEnter(e);
        }

        private void lblDestravar_DragDrop(object sender, DragEventArgs e)
        {
            Destravar(true, e);
            lblDestravar.BackColor = SystemColors.Control;
        }

        private void lblTravar_DragLeave(object sender, EventArgs e)
        {
            lblTravar.BackColor = SystemColors.Control;
        }

        private void lblDestravar_DragLeave(object sender, EventArgs e)
        {
            lblDestravar.BackColor = SystemColors.Control;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.ShowDialog();
        }

    }
}
