
namespace PetShop
{
    partial class Frm_abmBase
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_Editar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.gpb_Lista = new System.Windows.Forms.GroupBox();
            this.gpb_Datos = new System.Windows.Forms.GroupBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.txt_Sueldo = new System.Windows.Forms.TextBox();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.txt_Cuil = new System.Windows.Forms.TextBox();
            this.lbl_Cuil = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.cmb_Enumerado = new System.Windows.Forms.ComboBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.gpb_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(813, 575);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(83, 23);
            this.btn_Eliminar.TabIndex = 25;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Location = new System.Drawing.Point(719, 575);
            this.txt_Editar.Name = "txt_Editar";
            this.txt_Editar.Size = new System.Drawing.Size(83, 23);
            this.txt_Editar.TabIndex = 24;
            this.txt_Editar.Text = "Editar";
            this.txt_Editar.UseVisualStyleBackColor = true;
            this.txt_Editar.Click += new System.EventHandler(this.txt_Editar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(902, 575);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(83, 23);
            this.btn_Agregar.TabIndex = 23;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // gpb_Lista
            // 
            this.gpb_Lista.Location = new System.Drawing.Point(2, 5);
            this.gpb_Lista.Name = "gpb_Lista";
            this.gpb_Lista.Size = new System.Drawing.Size(644, 621);
            this.gpb_Lista.TabIndex = 26;
            this.gpb_Lista.TabStop = false;
            this.gpb_Lista.Text = "Lista de ";
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Controls.Add(this.lbl_Rol);
            this.gpb_Datos.Controls.Add(this.txt_Sueldo);
            this.gpb_Datos.Controls.Add(this.lbl_Sueldo);
            this.gpb_Datos.Controls.Add(this.txt_Cuil);
            this.gpb_Datos.Controls.Add(this.lbl_Cuil);
            this.gpb_Datos.Controls.Add(this.txt_Dni);
            this.gpb_Datos.Controls.Add(this.lbl_Dni);
            this.gpb_Datos.Controls.Add(this.txt_Apellido);
            this.gpb_Datos.Controls.Add(this.lbl_Apellido);
            this.gpb_Datos.Controls.Add(this.txt_Stock);
            this.gpb_Datos.Controls.Add(this.lbl_Stock);
            this.gpb_Datos.Controls.Add(this.txt_Descripcion);
            this.gpb_Datos.Controls.Add(this.lbl_Descripcion);
            this.gpb_Datos.Controls.Add(this.txt_Marca);
            this.gpb_Datos.Controls.Add(this.lbl_Marca);
            this.gpb_Datos.Controls.Add(this.txt_Precio);
            this.gpb_Datos.Controls.Add(this.lbl_Precio);
            this.gpb_Datos.Controls.Add(this.cmb_Enumerado);
            this.gpb_Datos.Controls.Add(this.lbl_Categoria);
            this.gpb_Datos.Controls.Add(this.txt_Nombre);
            this.gpb_Datos.Controls.Add(this.lbl_Nombre);
            this.gpb_Datos.Controls.Add(this.txt_Id);
            this.gpb_Datos.Controls.Add(this.lbl_Id);
            this.gpb_Datos.Location = new System.Drawing.Point(652, 5);
            this.gpb_Datos.Name = "gpb_Datos";
            this.gpb_Datos.Size = new System.Drawing.Size(379, 530);
            this.gpb_Datos.TabIndex = 27;
            this.gpb_Datos.TabStop = false;
            this.gpb_Datos.Text = "Datos ";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(186, 109);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(24, 15);
            this.lbl_Rol.TabIndex = 24;
            this.lbl_Rol.Text = "Rol";
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(31, 407);
            this.txt_Sueldo.Name = "txt_Sueldo";
            this.txt_Sueldo.Size = new System.Drawing.Size(319, 23);
            this.txt_Sueldo.TabIndex = 21;
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Location = new System.Drawing.Point(33, 386);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(43, 15);
            this.lbl_Sueldo.TabIndex = 20;
            this.lbl_Sueldo.Text = "Sueldo";
            // 
            // txt_Cuil
            // 
            this.txt_Cuil.Location = new System.Drawing.Point(33, 338);
            this.txt_Cuil.Name = "txt_Cuil";
            this.txt_Cuil.Size = new System.Drawing.Size(317, 23);
            this.txt_Cuil.TabIndex = 19;
            // 
            // lbl_Cuil
            // 
            this.lbl_Cuil.AutoSize = true;
            this.lbl_Cuil.Location = new System.Drawing.Point(33, 317);
            this.lbl_Cuil.Name = "lbl_Cuil";
            this.lbl_Cuil.Size = new System.Drawing.Size(28, 15);
            this.lbl_Cuil.TabIndex = 18;
            this.lbl_Cuil.Text = "Cuil";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(31, 268);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(319, 23);
            this.txt_Dni.TabIndex = 17;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(33, 250);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_Dni.TabIndex = 16;
            this.lbl_Dni.Text = "DNI";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(31, 194);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(319, 23);
            this.txt_Apellido.TabIndex = 15;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(31, 176);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_Apellido.TabIndex = 14;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(31, 378);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(135, 23);
            this.txt_Stock.TabIndex = 13;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(31, 360);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(36, 15);
            this.lbl_Stock.TabIndex = 12;
            this.lbl_Stock.Text = "Stock";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(31, 268);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(319, 67);
            this.txt_Descripcion.TabIndex = 11;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(31, 250);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(69, 15);
            this.lbl_Descripcion.TabIndex = 10;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(186, 194);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(164, 23);
            this.txt_Marca.TabIndex = 9;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(186, 176);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(40, 15);
            this.lbl_Marca.TabIndex = 8;
            this.lbl_Marca.Text = "Marca";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(31, 194);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(135, 23);
            this.txt_Precio.TabIndex = 7;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(31, 176);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(40, 15);
            this.lbl_Precio.TabIndex = 6;
            this.lbl_Precio.Text = "Precio";
            // 
            // cmb_Enumerado
            // 
            this.cmb_Enumerado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Enumerado.FormattingEnabled = true;
            this.cmb_Enumerado.Location = new System.Drawing.Point(186, 127);
            this.cmb_Enumerado.Name = "cmb_Enumerado";
            this.cmb_Enumerado.Size = new System.Drawing.Size(164, 23);
            this.cmb_Enumerado.TabIndex = 5;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(186, 109);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(58, 15);
            this.lbl_Categoria.TabIndex = 4;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(31, 127);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(135, 23);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(31, 109);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(226, 53);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(124, 23);
            this.txt_Id.TabIndex = 1;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(226, 34);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(18, 15);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(719, 546);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(83, 23);
            this.btn_Limpiar.TabIndex = 28;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(813, 546);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(83, 23);
            this.btn_Listar.TabIndex = 29;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            // 
            // Frm_abmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.txt_Editar);
            this.Controls.Add(this.gpb_Datos);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.gpb_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_abmBase";
            this.Opacity = 0D;
            this.Text = "Frm_ABM";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button txt_Editar;
        public System.Windows.Forms.Button btn_Agregar;
        public System.Windows.Forms.GroupBox gpb_Lista;
        public System.Windows.Forms.GroupBox gpb_Datos;
        public System.Windows.Forms.Button btn_Limpiar;
        public System.Windows.Forms.Button btn_Listar;
        public System.Windows.Forms.Label lbl_Nombre;
        public System.Windows.Forms.TextBox txt_Id;
        public System.Windows.Forms.Label lbl_Id;
        public System.Windows.Forms.ComboBox cmb_Enumerado;
        public System.Windows.Forms.Label lbl_Categoria;
        public System.Windows.Forms.TextBox txt_Nombre;
        public System.Windows.Forms.TextBox txt_Precio;
        public System.Windows.Forms.Label lbl_Precio;
        public System.Windows.Forms.TextBox txt_Marca;
        public System.Windows.Forms.Label lbl_Marca;
        public System.Windows.Forms.TextBox txt_Descripcion;
        public System.Windows.Forms.Label lbl_Descripcion;
        public System.Windows.Forms.TextBox txt_Stock;
        public System.Windows.Forms.Label lbl_Stock;
        public System.Windows.Forms.TextBox txt_Apellido;
        public System.Windows.Forms.Label lbl_Apellido;
        public System.Windows.Forms.TextBox txt_Sueldo;
        public System.Windows.Forms.Label lbl_Sueldo;
        public System.Windows.Forms.TextBox txt_Cuil;
        public System.Windows.Forms.Label lbl_Cuil;
        public System.Windows.Forms.TextBox txt_Dni;
        public System.Windows.Forms.Label lbl_Dni;
        public System.Windows.Forms.Label lbl_Rol;
    }
}