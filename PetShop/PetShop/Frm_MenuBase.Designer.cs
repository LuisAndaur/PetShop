
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuBase));
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Home = new System.Windows.Forms.Button();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_CambiarUsuario = new System.Windows.Forms.Button();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.lbl_UsuarioActivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Clientes.FlatAppearance.BorderSize = 2;
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clientes.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clientes.Location = new System.Drawing.Point(-2, 180);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(128, 35);
            this.btn_Clientes.TabIndex = 4;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fecha.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Fecha.Location = new System.Drawing.Point(292, 10);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(609, 25);
            this.lbl_Fecha.TabIndex = 2;
            this.lbl_Fecha.Text = "Fecha";
            this.lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hora.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.Location = new System.Drawing.Point(996, 10);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(186, 25);
            this.lbl_Hora.TabIndex = 3;
            this.lbl_Hora.Text = "Hora";
            this.lbl_Hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Home.FlatAppearance.BorderSize = 2;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Home.Location = new System.Drawing.Point(-2, 70);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(128, 35);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Contenedor.Location = new System.Drawing.Point(147, 49);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(1035, 630);
            this.pnl_Contenedor.TabIndex = 5;
            // 
            // btn_Productos
            // 
            this.btn_Productos.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Productos.FlatAppearance.BorderSize = 2;
            this.btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Productos.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Productos.Location = new System.Drawing.Point(-2, 235);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(128, 35);
            this.btn_Productos.TabIndex = 6;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Ventas.FlatAppearance.BorderSize = 2;
            this.btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ventas.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ventas.Location = new System.Drawing.Point(-2, 345);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(128, 35);
            this.btn_Ventas.TabIndex = 7;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = true;
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Empleados.FlatAppearance.BorderSize = 2;
            this.btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleados.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Empleados.Location = new System.Drawing.Point(-2, 290);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(128, 35);
            this.btn_Empleados.TabIndex = 8;
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.UseVisualStyleBackColor = true;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Cerrar.FlatAppearance.BorderSize = 2;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cerrar.Location = new System.Drawing.Point(-2, 644);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(128, 35);
            this.btn_Cerrar.TabIndex = 9;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_CambiarUsuario
            // 
            this.btn_CambiarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_CambiarUsuario.FlatAppearance.BorderSize = 2;
            this.btn_CambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CambiarUsuario.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CambiarUsuario.Location = new System.Drawing.Point(-2, 590);
            this.btn_CambiarUsuario.Name = "btn_CambiarUsuario";
            this.btn_CambiarUsuario.Size = new System.Drawing.Size(128, 35);
            this.btn_CambiarUsuario.TabIndex = 10;
            this.btn_CambiarUsuario.Text = "Cambiar usuario";
            this.btn_CambiarUsuario.UseVisualStyleBackColor = true;
            this.btn_CambiarUsuario.Click += new System.EventHandler(this.btn_CambiarUsuario_Click);
            // 
            // btn_Vender
            // 
            this.btn_Vender.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Vender.FlatAppearance.BorderSize = 2;
            this.btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vender.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Vender.Location = new System.Drawing.Point(-2, 125);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(128, 35);
            this.btn_Vender.TabIndex = 11;
            this.btn_Vender.Text = "Vender";
            this.btn_Vender.UseVisualStyleBackColor = true;
            this.btn_Vender.Click += new System.EventHandler(this.btn_Vender_Click);
            // 
            // lbl_UsuarioActivo
            // 
            this.lbl_UsuarioActivo.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UsuarioActivo.Location = new System.Drawing.Point(12, 10);
            this.lbl_UsuarioActivo.Name = "lbl_UsuarioActivo";
            this.lbl_UsuarioActivo.Size = new System.Drawing.Size(260, 25);
            this.lbl_UsuarioActivo.TabIndex = 12;
            this.lbl_UsuarioActivo.Text = "Usuario activo: ";
            this.lbl_UsuarioActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_MenuBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 691);
            this.Controls.Add(this.lbl_UsuarioActivo);
            this.Controls.Add(this.btn_Vender);
            this.Controls.Add(this.btn_CambiarUsuario);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Empleados);
            this.Controls.Add(this.btn_Ventas);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.btn_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MenuBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MenuBase_FormClosing);
            this.Load += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel pnl_Contenedor;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Hora;
        protected System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Cerrar;
        public System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Button btn_CambiarUsuario;
        private System.Windows.Forms.Button btn_Vender;
        public System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Label lbl_UsuarioActivo;
    }
}

