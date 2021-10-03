
namespace PetShop
{
    partial class Frm_Home
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
            this.lbl_Caja = new System.Windows.Forms.Label();
            this.lbl_ImporteCaja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Caja
            // 
            this.lbl_Caja.AutoSize = true;
            this.lbl_Caja.Location = new System.Drawing.Point(87, 362);
            this.lbl_Caja.Name = "lbl_Caja";
            this.lbl_Caja.Size = new System.Drawing.Size(73, 15);
            this.lbl_Caja.TabIndex = 0;
            this.lbl_Caja.Text = "Importe caja";
            // 
            // lbl_ImporteCaja
            // 
            this.lbl_ImporteCaja.AutoSize = true;
            this.lbl_ImporteCaja.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ImporteCaja.Location = new System.Drawing.Point(87, 387);
            this.lbl_ImporteCaja.Name = "lbl_ImporteCaja";
            this.lbl_ImporteCaja.Size = new System.Drawing.Size(39, 54);
            this.lbl_ImporteCaja.TabIndex = 1;
            this.lbl_ImporteCaja.Text = "/";
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Controls.Add(this.lbl_ImporteCaja);
            this.Controls.Add(this.lbl_Caja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Home";
            this.Opacity = 0D;
            this.Text = "Frm_Home";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Caja;
        private System.Windows.Forms.Label lbl_ImporteCaja;
    }
}