
namespace PetShop
{
    partial class Frm_MenuBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.lbl_TituloMenuPrincipal = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Home = new System.Windows.Forms.Button();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(450, 27);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(114, 35);
            this.btn_Clientes.TabIndex = 0;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // lbl_TituloMenuPrincipal
            // 
            this.lbl_TituloMenuPrincipal.AutoSize = true;
            this.lbl_TituloMenuPrincipal.Location = new System.Drawing.Point(12, 9);
            this.lbl_TituloMenuPrincipal.Name = "lbl_TituloMenuPrincipal";
            this.lbl_TituloMenuPrincipal.Size = new System.Drawing.Size(88, 15);
            this.lbl_TituloMenuPrincipal.TabIndex = 1;
            this.lbl_TituloMenuPrincipal.Text = "Usuario activo: ";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(12, 37);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(38, 15);
            this.lbl_Fecha.TabIndex = 2;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(12, 68);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(33, 15);
            this.lbl_Hora.TabIndex = 3;
            this.lbl_Hora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(317, 27);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(114, 35);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Location = new System.Drawing.Point(112, 68);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(988, 541);
            this.pnl_Contenedor.TabIndex = 5;
            // 
            // Frm_MenuBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_TituloMenuPrincipal);
            this.Controls.Add(this.btn_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MenuBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel pnl_Contenedor;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Hora;
        protected System.Windows.Forms.Label lbl_TituloMenuPrincipal;
        protected System.Windows.Forms.Timer timer1;
    }
}

