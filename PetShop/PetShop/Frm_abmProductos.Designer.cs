
namespace PetShop
{
    partial class Frm_abmProductos
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
            this.Categoria = new System.Windows.Forms.ColumnHeader();
            this.Precio = new System.Windows.Forms.ColumnHeader();
            this.Descripción = new System.Windows.Forms.ColumnHeader();
            this.Marca = new System.Windows.Forms.ColumnHeader();
            this.Stock = new System.Windows.Forms.ColumnHeader();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_Lista.SuspendLayout();
            this.gpb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(813, 584);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Location = new System.Drawing.Point(719, 584);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(907, 584);
            // 
            // gpb_Lista
            // 
            this.gpb_Lista.Controls.Add(this.dgv_Lista);
            this.gpb_Lista.Size = new System.Drawing.Size(680, 621);
            this.gpb_Lista.Text = "Lista de Productos";
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_Datos.Location = new System.Drawing.Point(689, 6);
            this.gpb_Datos.Size = new System.Drawing.Size(340, 530);
            this.gpb_Datos.Text = "Datos del producto";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(719, 555);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(813, 555);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Location = new System.Drawing.Point(11, 109);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(206, 53);
            // 
            // lbl_Id
            // 
            this.lbl_Id.Location = new System.Drawing.Point(206, 34);
            // 
            // cmb_Enumerado
            // 
            this.cmb_Enumerado.Location = new System.Drawing.Point(166, 127);
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Location = new System.Drawing.Point(166, 109);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(11, 127);
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(11, 194);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Location = new System.Drawing.Point(11, 176);
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(166, 194);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Location = new System.Drawing.Point(166, 176);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(11, 268);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Location = new System.Drawing.Point(11, 250);
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(11, 378);
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.Location = new System.Drawing.Point(11, 360);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(24, 487);
            this.txt_Apellido.Visible = false;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.Location = new System.Drawing.Point(24, 469);
            this.lbl_Apellido.Visible = false;
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(22, 487);
            this.txt_Sueldo.Visible = false;
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.Location = new System.Drawing.Point(19, 469);
            this.lbl_Sueldo.Visible = false;
            // 
            // txt_Cuil
            // 
            this.txt_Cuil.Location = new System.Drawing.Point(22, 487);
            this.txt_Cuil.Visible = false;
            // 
            // lbl_Cuil
            // 
            this.lbl_Cuil.Location = new System.Drawing.Point(22, 469);
            this.lbl_Cuil.Visible = false;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(21, 483);
            this.txt_Dni.Visible = false;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.Location = new System.Drawing.Point(21, 465);
            this.lbl_Dni.Visible = false;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.Location = new System.Drawing.Point(24, 469);
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
            this.Nombre.Width = 90;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 80;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Precio.Width = 70;
            // 
            // Descripción
            // 
            this.Descripción.Text = "Descripción";
            this.Descripción.Width = 200;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 80;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgv_Lista.Location = new System.Drawing.Point(6, 22);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.RowTemplate.Height = 25;
            this.dgv_Lista.Size = new System.Drawing.Size(670, 593);
            this.dgv_Lista.TabIndex = 1;
            this.dgv_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 220;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // Frm_abmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Name = "Frm_abmProductos";
            this.Text = "Frm_abmProductos";
            this.Load += new System.EventHandler(this.Frm_abmProductos_Load);
            this.gpb_Lista.ResumeLayout(false);
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Descripción;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}