
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Eliminar.FlatAppearance.BorderSize = 2;
            this.btn_Eliminar.Location = new System.Drawing.Point(845, 574);
            // 
            // txt_Editar
            // 
            this.txt_Editar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txt_Editar.FlatAppearance.BorderSize = 2;
            this.txt_Editar.Location = new System.Drawing.Point(756, 574);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Agregar.FlatAppearance.BorderSize = 2;
            this.btn_Agregar.Location = new System.Drawing.Point(934, 574);
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
            this.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Limpiar.FlatAppearance.BorderSize = 2;
            this.btn_Limpiar.Location = new System.Drawing.Point(667, 574);
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
            this.dgv_Lista.AllowUserToDeleteRows = false;
            this.dgv_Lista.AllowUserToResizeColumns = false;
            this.dgv_Lista.AllowUserToResizeRows = false;
            this.dgv_Lista.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lapsus Pro (theguybrush.com)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Rol,
            this.Nombre,
            this.Apellido,
            this.dni,
            this.Cuil,
            this.Sueldo});
            this.dgv_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Lista.EnableHeadersVisualStyles = false;
            this.dgv_Lista.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_Lista.Location = new System.Drawing.Point(3, 17);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Lista.RowHeadersVisible = false;
            this.dgv_Lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_Lista.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Lista.RowTemplate.Height = 25;
            this.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Lista.Size = new System.Drawing.Size(638, 601);
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
            this.btn_Aumentar.Click += new System.EventHandler(this.btn_Aumentar_Click);
            // 
            // txt_Porcentaje
            // 
            this.txt_Porcentaje.Location = new System.Drawing.Point(160, 463);
            this.txt_Porcentaje.Name = "txt_Porcentaje";
            this.txt_Porcentaje.Size = new System.Drawing.Size(100, 21);
            this.txt_Porcentaje.TabIndex = 30;
            // 
            // lbl_Porcentaje
            // 
            this.lbl_Porcentaje.AutoSize = true;
            this.lbl_Porcentaje.Location = new System.Drawing.Point(160, 445);
            this.lbl_Porcentaje.Name = "lbl_Porcentaje";
            this.lbl_Porcentaje.Size = new System.Drawing.Size(59, 13);
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