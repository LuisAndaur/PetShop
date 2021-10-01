
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
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Aumentar = new System.Windows.Forms.Button();
            this.txt_Porcentaje = new System.Windows.Forms.TextBox();
            this.lbl_Porcentaje = new System.Windows.Forms.Label();
            this.gpb_Lista.SuspendLayout();
            this.gpb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Stock)).BeginInit();
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
            this.gpb_Datos.Controls.Add(this.lbl_Porcentaje);
            this.gpb_Datos.Controls.Add(this.txt_Porcentaje);
            this.gpb_Datos.Controls.Add(this.btn_Aumentar);
            this.gpb_Datos.Text = "Datos de empleados";
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Id, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Id, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Nombre, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Nombre, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Categoria, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.cmb_Enumerado, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Precio, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Precio, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Marca, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Marca, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Descripcion, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Descripcion, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Stock, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Apellido, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Apellido, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Dni, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Dni, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Cuil, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Cuil, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Sueldo, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Sueldo, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Rol, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.nud_Stock, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.btn_Aumentar, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Porcentaje, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Porcentaje, 0);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(707, 555);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(206, 53);
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Location = new System.Drawing.Point(34, 473);
            this.lbl_Categoria.Visible = false;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(34, 491);
            this.txt_Precio.Visible = false;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Location = new System.Drawing.Point(34, 473);
            this.lbl_Precio.Visible = false;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(34, 491);
            this.txt_Marca.Visible = false;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Location = new System.Drawing.Point(34, 473);
            this.lbl_Marca.Visible = false;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(34, 491);
            this.txt_Descripcion.Size = new System.Drawing.Size(319, 26);
            this.txt_Descripcion.Visible = false;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Location = new System.Drawing.Point(34, 473);
            this.lbl_Descripcion.Visible = false;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.Location = new System.Drawing.Point(34, 473);
            this.lbl_Stock.Visible = false;
            // 
            // nud_Stock
            // 
            this.nud_Stock.Location = new System.Drawing.Point(31, 491);
            this.nud_Stock.Visible = false;
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Rol,
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
            this.dgv_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.Width = 80;
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
            this.Apellido.Width = 90;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.Width = 90;
            // 
            // Cuil
            // 
            this.Cuil.HeaderText = "Cuil";
            this.Cuil.Name = "Cuil";
            this.Cuil.Width = 90;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Width = 90;
            // 
            // btn_Aumentar
            // 
            this.btn_Aumentar.Location = new System.Drawing.Point(275, 462);
            this.btn_Aumentar.Name = "btn_Aumentar";
            this.btn_Aumentar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aumentar.TabIndex = 29;
            this.btn_Aumentar.Text = "Aumentar";
            this.btn_Aumentar.UseVisualStyleBackColor = true;
            // 
            // txt_Porcentaje
            // 
            this.txt_Porcentaje.Location = new System.Drawing.Point(160, 463);
            this.txt_Porcentaje.Name = "txt_Porcentaje";
            this.txt_Porcentaje.Size = new System.Drawing.Size(100, 23);
            this.txt_Porcentaje.TabIndex = 30;
            // 
            // lbl_Porcentaje
            // 
            this.lbl_Porcentaje.AutoSize = true;
            this.lbl_Porcentaje.Location = new System.Drawing.Point(160, 445);
            this.lbl_Porcentaje.Name = "lbl_Porcentaje";
            this.lbl_Porcentaje.Size = new System.Drawing.Size(63, 15);
            this.lbl_Porcentaje.TabIndex = 31;
            this.lbl_Porcentaje.Text = "Porcentaje";
            // 
            // Frm_abmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Name = "Frm_abmEmpleados";
            this.Text = "Frm_abmEmpleados";
            this.Load += new System.EventHandler(this.Frm_abmEmpleados_Load);
            this.gpb_Lista.ResumeLayout(false);
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.Label lbl_Porcentaje;
        private System.Windows.Forms.TextBox txt_Porcentaje;
        private System.Windows.Forms.Button btn_Aumentar;
    }
}