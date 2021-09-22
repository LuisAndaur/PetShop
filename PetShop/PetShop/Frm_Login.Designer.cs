
namespace PetShop
{
    partial class Frm_Login
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
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Administrador = new System.Windows.Forms.Button();
            this.lbl_TextoAutocompletar = new System.Windows.Forms.Label();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.lbl_ErrorLogin = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(114, 118);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Ingrese usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(265, 23);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(114, 167);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.PlaceholderText = "Ingrese contraseña";
            this.txt_Password.Size = new System.Drawing.Size(265, 23);
            this.txt_Password.TabIndex = 2;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(114, 221);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(265, 23);
            this.btn_Ingresar.TabIndex = 3;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_Administrador
            // 
            this.btn_Administrador.Location = new System.Drawing.Point(12, 350);
            this.btn_Administrador.Name = "btn_Administrador";
            this.btn_Administrador.Size = new System.Drawing.Size(130, 23);
            this.btn_Administrador.TabIndex = 4;
            this.btn_Administrador.Text = "Administrador";
            this.btn_Administrador.UseVisualStyleBackColor = true;
            // 
            // lbl_TextoAutocompletar
            // 
            this.lbl_TextoAutocompletar.AutoSize = true;
            this.lbl_TextoAutocompletar.Location = new System.Drawing.Point(12, 321);
            this.lbl_TextoAutocompletar.Name = "lbl_TextoAutocompletar";
            this.lbl_TextoAutocompletar.Size = new System.Drawing.Size(274, 15);
            this.lbl_TextoAutocompletar.TabIndex = 4;
            this.lbl_TextoAutocompletar.Text = "*Seleccione un tipo de usuario para autocompletar";
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.Location = new System.Drawing.Point(156, 350);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(130, 23);
            this.btn_Empleado.TabIndex = 5;
            this.btn_Empleado.Text = "Empleado";
            this.btn_Empleado.UseVisualStyleBackColor = true;
            // 
            // lbl_ErrorLogin
            // 
            this.lbl_ErrorLogin.AutoSize = true;
            this.lbl_ErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorLogin.Location = new System.Drawing.Point(114, 265);
            this.lbl_ErrorLogin.Name = "lbl_ErrorLogin";
            this.lbl_ErrorLogin.Size = new System.Drawing.Size(0, 15);
            this.lbl_ErrorLogin.TabIndex = 6;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(175, 57);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(150, 25);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Pet Shop Piluso";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 385);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_ErrorLogin);
            this.Controls.Add(this.btn_Empleado);
            this.Controls.Add(this.lbl_TextoAutocompletar);
            this.Controls.Add(this.btn_Administrador);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Pet Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Administrador;
        private System.Windows.Forms.Label lbl_TextoAutocompletar;
        private System.Windows.Forms.Button btn_Empleado;
        private System.Windows.Forms.Label lbl_ErrorLogin;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}