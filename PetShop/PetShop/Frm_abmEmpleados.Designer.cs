
namespace PetShop
{
    partial class Frm_abmEmpleados
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
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_iD = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.txt_Cuil = new System.Windows.Forms.TextBox();
            this.lbl_Cuil = new System.Windows.Forms.Label();
            this.cmb_Rol = new System.Windows.Forms.ComboBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.gpb_Lista.SuspendLayout();
            this.gpb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(801, 584);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Location = new System.Drawing.Point(707, 584);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(890, 584);
            // 
            // gpb_Lista
            // 
            this.gpb_Lista.Controls.Add(this.dgv_Lista);
            this.gpb_Lista.Text = "Lista de empleados";
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Controls.Add(this.lbl_Rol);
            this.gpb_Datos.Controls.Add(this.cmb_Rol);
            this.gpb_Datos.Controls.Add(this.txt_Cuil);
            this.gpb_Datos.Controls.Add(this.lbl_Cuil);
            this.gpb_Datos.Controls.Add(this.txt_Dni);
            this.gpb_Datos.Controls.Add(this.lbl_Dni);
            this.gpb_Datos.Controls.Add(this.txt_Apellido);
            this.gpb_Datos.Controls.Add(this.lbl_Apellido);
            this.gpb_Datos.Controls.Add(this.txt_Nombre);
            this.gpb_Datos.Controls.Add(this.lbl_Nombre);
            this.gpb_Datos.Controls.Add(this.txt_Id);
            this.gpb_Datos.Controls.Add(this.LBL_iD);
            this.gpb_Datos.Text = "Datos de empleados";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(707, 555);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(801, 555);
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.dni,
            this.Cuil,
            this.Sueldo});
            this.dgv_Lista.Location = new System.Drawing.Point(6, 22);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.RowTemplate.Height = 25;
            this.dgv_Lista.Size = new System.Drawing.Size(632, 593);
            this.dgv_Lista.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 90;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // Cuil
            // 
            this.Cuil.HeaderText = "Cuil";
            this.Cuil.Name = "Cuil";
            this.Cuil.Width = 110;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // LBL_iD
            // 
            this.LBL_iD.AutoSize = true;
            this.LBL_iD.Location = new System.Drawing.Point(46, 62);
            this.LBL_iD.Name = "LBL_iD";
            this.LBL_iD.Size = new System.Drawing.Size(18, 15);
            this.LBL_iD.TabIndex = 0;
            this.LBL_iD.Text = "ID";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(46, 80);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(287, 23);
            this.txt_Id.TabIndex = 1;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(46, 145);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(287, 23);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(46, 127);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(46, 211);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(287, 23);
            this.txt_Apellido.TabIndex = 5;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(46, 193);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(46, 282);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(287, 23);
            this.txt_Dni.TabIndex = 7;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(46, 264);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_Dni.TabIndex = 6;
            this.lbl_Dni.Text = "DNI";
            // 
            // txt_Cuil
            // 
            this.txt_Cuil.Location = new System.Drawing.Point(46, 355);
            this.txt_Cuil.Name = "txt_Cuil";
            this.txt_Cuil.Size = new System.Drawing.Size(287, 23);
            this.txt_Cuil.TabIndex = 9;
            // 
            // lbl_Cuil
            // 
            this.lbl_Cuil.AutoSize = true;
            this.lbl_Cuil.Location = new System.Drawing.Point(46, 337);
            this.lbl_Cuil.Name = "lbl_Cuil";
            this.lbl_Cuil.Size = new System.Drawing.Size(28, 15);
            this.lbl_Cuil.TabIndex = 8;
            this.lbl_Cuil.Text = "Cuil";
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Location = new System.Drawing.Point(46, 415);
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Size = new System.Drawing.Size(287, 23);
            this.cmb_Rol.TabIndex = 10;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(46, 397);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(24, 15);
            this.lbl_Rol.TabIndex = 11;
            this.lbl_Rol.Text = "Rol";
            // 
            // Frm_abmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Name = "Frm_abmEmpleados";
            this.Text = "Frm_abmEmpleados";
            this.gpb_Lista.ResumeLayout(false);
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.TextBox txt_Cuil;
        private System.Windows.Forms.Label lbl_Cuil;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label LBL_iD;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.ComboBox cmb_Rol;
    }
}