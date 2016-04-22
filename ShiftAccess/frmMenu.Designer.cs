namespace ShiftAccess
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTravar = new System.Windows.Forms.Label();
            this.lblDestravar = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.menuGeral = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTravar
            // 
            this.lblTravar.AllowDrop = true;
            this.lblTravar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTravar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTravar.Location = new System.Drawing.Point(76, 33);
            this.lblTravar.Name = "lblTravar";
            this.lblTravar.Size = new System.Drawing.Size(359, 63);
            this.lblTravar.TabIndex = 0;
            this.lblTravar.Text = "Travar";
            this.lblTravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTravar.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblTravar_DragDrop);
            this.lblTravar.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblTravar_DragEnter);
            this.lblTravar.DragLeave += new System.EventHandler(this.lblTravar_DragLeave);
            // 
            // lblDestravar
            // 
            this.lblDestravar.AllowDrop = true;
            this.lblDestravar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestravar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestravar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDestravar.Location = new System.Drawing.Point(76, 141);
            this.lblDestravar.Name = "lblDestravar";
            this.lblDestravar.Size = new System.Drawing.Size(359, 63);
            this.lblDestravar.TabIndex = 1;
            this.lblDestravar.Text = "Destravar";
            this.lblDestravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDestravar.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDestravar_DragDrop);
            this.lblDestravar.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDestravar_DragEnter);
            this.lblDestravar.DragLeave += new System.EventHandler(this.lblDestravar_DragLeave);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(0, 232);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(512, 30);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuGeral
            // 
            this.menuGeral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuAjuda});
            this.menuGeral.Location = new System.Drawing.Point(0, 0);
            this.menuGeral.Name = "menuGeral";
            this.menuGeral.Size = new System.Drawing.Size(511, 24);
            this.menuGeral.TabIndex = 3;
            this.menuGeral.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuSair.Size = new System.Drawing.Size(135, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(24, 20);
            this.mnuAjuda.Text = "?";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(113, 22);
            this.mnuSobre.Text = "Sobre...";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 279);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDestravar);
            this.Controls.Add(this.lblTravar);
            this.Controls.Add(this.menuGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuGeral;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftAccess | Trava ou destrava o uso da tecla shift no MsAccess";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuGeral.ResumeLayout(false);
            this.menuGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTravar;
        private System.Windows.Forms.Label lblDestravar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.MenuStrip menuGeral;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
    }
}

