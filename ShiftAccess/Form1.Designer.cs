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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 279);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDestravar);
            this.Controls.Add(this.lblTravar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftAccess | Trava ou destrava o uso da tecla shift no MsAccess";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTravar;
        private System.Windows.Forms.Label lblDestravar;
        private System.Windows.Forms.Label lblResult;
    }
}

