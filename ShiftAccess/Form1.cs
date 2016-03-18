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

        private void lblTravar_DragEnter(object sender, DragEventArgs e)
        {
            lblTravar.BackColor = SystemColors.GradientInactiveCaption;
            EvDragEnter(e);
        }

        private void lblTravar_DragDrop(object sender, DragEventArgs e)
        {
            AllowByPassKey(false, e);
            lblTravar.BackColor = SystemColors.Control;
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

        private bool existeProp(string propriedade, Database db)
        {

            if (db.Properties.GetType().GetType().GetMember(propriedade) != null)
            {
                return true;
            }

            return false;
        }

        private void AllowByPassKey(bool valor, DragEventArgs e)
        {
            string[] caminho = (string[])(e.Data.GetData(DataFormats.FileDrop));
            var dbe = new DBEngine();
            Database db = null;
            try
            {
                db = dbe.OpenDatabase(caminho[0]);
                //db.GetType().GetProperty("AllowByPassKey");
                if (existeProp("AllowByPassKey", db) == true)
                    db.Properties.Delete("AllowBypassKey");
                var prop = db.CreateProperty("AllowByPassKey", 1, valor);
                db.Properties.Append(prop);
                if (valor == false)
                {
                    lblResult.BackColor = SystemColors.GradientInactiveCaption;
                    lblResult.Text = "\"" + caminho[0] + "\"" + " travado!";
                }
                else if (valor == true)
                {
                    lblResult.BackColor = SystemColors.GradientInactiveCaption;
                    lblResult.Text = "\"" + caminho[0] + "\"" + " destravado!";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (db != null)
                    db.Close();
            }
        }

        private void lblDestravar_DragEnter(object sender, DragEventArgs e)
        {
            lblDestravar.BackColor = SystemColors.GradientInactiveCaption;
            EvDragEnter(e);
        }

        private void lblDestravar_DragDrop(object sender, DragEventArgs e)
        {
            AllowByPassKey(true, e);
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
    }
}
