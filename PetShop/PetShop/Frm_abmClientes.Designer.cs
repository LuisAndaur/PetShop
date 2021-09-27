
namespace PetShop
{
    partial class Frm_abmClientes
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
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Apellido = new System.Windows.Forms.ColumnHeader();
            this.dni = new System.Windows.Forms.ColumnHeader();
            this.Cuil = new System.Windows.Forms.ColumnHeader();
            this.Saldo = new System.Windows.Forms.ColumnHeader();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_Lista.SuspendLayout();
            this.gpb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(813, 579);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Location = new System.Drawing.Point(717, 579);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(914, 579);
            // 
            // gpb_Lista
            // 
            this.gpb_Lista.Controls.Add(this.dgv_Lista);
            this.gpb_Lista.Text = "Lista de Clientes";
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Text = "Datos clientes";
            // 
            // cmb_Enumerado
            // 
            this.cmb_Enumerado.Location = new System.Drawing.Point(31, 479);
            this.cmb_Enumerado.Visible = false;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Location = new System.Drawing.Point(31, 461);
            this.lbl_Categoria.Visible = false;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(31, 479);
            this.txt_Precio.Visible = false;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Location = new System.Drawing.Point(31, 461);
            this.lbl_Precio.Visible = false;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(31, 479);
            this.txt_Marca.Visible = false;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Location = new System.Drawing.Point(31, 461);
            this.lbl_Marca.Visible = false;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(31, 479);
            this.txt_Descripcion.Size = new System.Drawing.Size(319, 23);
            this.txt_Descripcion.Visible = false;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Location = new System.Drawing.Point(31, 461);
            this.lbl_Descripcion.Visible = false;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(31, 479);
            this.txt_Stock.Visible = false;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.Location = new System.Drawing.Point(31, 461);
            this.lbl_Stock.Visible = false;
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(31, 479);
            this.txt_Sueldo.Visible = false;
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.Location = new System.Drawing.Point(28, 461);
            this.lbl_Sueldo.Visible = false;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.Location = new System.Drawing.Point(35, 461);
            this.lbl_Rol.Visible = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 80;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 80;
            // 
            // dni
            // 
            this.dni.Text = "DNI";
            this.dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dni.Width = 100;
            // 
            // Cuil
            // 
            this.Cuil.Text = "Cuil";
            this.Cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cuil.Width = 100;
            // 
            // Saldo
            // 
            this.Saldo.Text = "Saldo";
            this.Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Saldo.Width = 80;
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.AllowUserToDeleteRows = false;
            this.dgv_Lista.AllowUserToResizeColumns = false;
            this.dgv_Lista.AllowUserToResizeRows = false;
            this.dgv_Lista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_Lista.Location = new System.Drawing.Point(6, 22);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.ReadOnly = true;
            this.dgv_Lista.RowTemplate.Height = 25;
            this.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Lista.Size = new System.Drawing.Size(632, 593);
            this.dgv_Lista.TabIndex = 1;
            this.dgv_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cuil";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Frm_abmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Name = "Frm_abmClientes";
            this.Text = "Frm_abmClientes";
            this.gpb_Lista.ResumeLayout(false);
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader dni;
        private System.Windows.Forms.ColumnHeader Cuil;
        private System.Windows.Forms.ColumnHeader Saldo;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}