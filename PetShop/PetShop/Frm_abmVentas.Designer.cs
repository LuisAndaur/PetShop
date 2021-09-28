
namespace PetShop
{
    partial class Frm_abmVentas
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Empleado = new System.Windows.Forms.Label();
            this.txt_Empleado = new System.Windows.Forms.TextBox();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_PrecioFinal = new System.Windows.Forms.TextBox();
            this.lbl_PrecioFinal = new System.Windows.Forms.Label();
            this.btn_Ticket = new System.Windows.Forms.Button();
            this.gpb_Lista.SuspendLayout();
            this.gpb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(808, 585);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Location = new System.Drawing.Point(719, 585);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(897, 585);
            // 
            // gpb_Lista
            // 
            this.gpb_Lista.Controls.Add(this.dgv_Lista);
            this.gpb_Lista.Text = "Lista de ventas";
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Controls.Add(this.txt_PrecioFinal);
            this.gpb_Datos.Controls.Add(this.lbl_PrecioFinal);
            this.gpb_Datos.Controls.Add(this.txt_Cantidad);
            this.gpb_Datos.Controls.Add(this.lbl_Cantidad);
            this.gpb_Datos.Controls.Add(this.txt_Producto);
            this.gpb_Datos.Controls.Add(this.lbl_Producto);
            this.gpb_Datos.Controls.Add(this.txt_Cliente);
            this.gpb_Datos.Controls.Add(this.lbl_Cliente);
            this.gpb_Datos.Controls.Add(this.txt_Empleado);
            this.gpb_Datos.Controls.Add(this.lbl_Empleado);
            this.gpb_Datos.Text = "Detalles de ventas";
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
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Stock, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Apellido, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Apellido, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Dni, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Dni, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Cuil, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Cuil, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Sueldo, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Sueldo, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Rol, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Empleado, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Empleado, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Cliente, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Cliente, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Producto, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Producto, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_Cantidad, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_Cantidad, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.lbl_PrecioFinal, 0);
            this.gpb_Datos.Controls.SetChildIndex(this.txt_PrecioFinal, 0);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(719, 556);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(808, 556);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Location = new System.Drawing.Point(33, 483);
            this.lbl_Nombre.Visible = false;
            // 
            // cmb_Enumerado
            // 
            this.cmb_Enumerado.Location = new System.Drawing.Point(31, 501);
            this.cmb_Enumerado.Visible = false;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Location = new System.Drawing.Point(31, 483);
            this.lbl_Categoria.Visible = false;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(33, 501);
            this.txt_Nombre.Visible = false;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(33, 501);
            this.txt_Precio.Visible = false;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Location = new System.Drawing.Point(36, 483);
            this.lbl_Precio.Visible = false;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(33, 501);
            this.txt_Marca.Visible = false;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Location = new System.Drawing.Point(31, 483);
            this.lbl_Marca.Visible = false;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(31, 501);
            this.txt_Descripcion.Size = new System.Drawing.Size(319, 23);
            this.txt_Descripcion.Visible = false;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Location = new System.Drawing.Point(31, 483);
            this.lbl_Descripcion.Visible = false;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(31, 501);
            this.txt_Stock.Visible = false;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.Location = new System.Drawing.Point(31, 483);
            this.lbl_Stock.Visible = false;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(33, 501);
            this.txt_Apellido.Visible = false;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.Location = new System.Drawing.Point(33, 483);
            this.lbl_Apellido.Visible = false;
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(31, 501);
            this.txt_Sueldo.Visible = false;
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.Location = new System.Drawing.Point(33, 483);
            this.lbl_Sueldo.Visible = false;
            // 
            // txt_Cuil
            // 
            this.txt_Cuil.Location = new System.Drawing.Point(33, 501);
            this.txt_Cuil.Visible = false;
            // 
            // lbl_Cuil
            // 
            this.lbl_Cuil.Location = new System.Drawing.Point(39, 483);
            this.lbl_Cuil.Visible = false;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(31, 501);
            this.txt_Dni.Visible = false;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.Location = new System.Drawing.Point(33, 483);
            this.lbl_Dni.Visible = false;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.Location = new System.Drawing.Point(31, 483);
            this.lbl_Rol.Visible = false;
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
            this.Preciototal});
            this.dgv_Lista.Location = new System.Drawing.Point(6, 22);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.RowTemplate.Height = 25;
            this.dgv_Lista.Size = new System.Drawing.Size(632, 593);
            this.dgv_Lista.TabIndex = 0;
            this.dgv_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Preciototal
            // 
            this.Preciototal.HeaderText = "Precio total";
            this.Preciototal.Name = "Preciototal";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // lbl_Empleado
            // 
            this.lbl_Empleado.AutoSize = true;
            this.lbl_Empleado.Location = new System.Drawing.Point(31, 94);
            this.lbl_Empleado.Name = "lbl_Empleado";
            this.lbl_Empleado.Size = new System.Drawing.Size(60, 15);
            this.lbl_Empleado.TabIndex = 25;
            this.lbl_Empleado.Text = "Empleado";
            // 
            // txt_Empleado
            // 
            this.txt_Empleado.Location = new System.Drawing.Point(31, 113);
            this.txt_Empleado.Name = "txt_Empleado";
            this.txt_Empleado.Size = new System.Drawing.Size(319, 23);
            this.txt_Empleado.TabIndex = 26;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(31, 180);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(319, 23);
            this.txt_Cliente.TabIndex = 28;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(31, 161);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(44, 15);
            this.lbl_Cliente.TabIndex = 27;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // txt_Producto
            // 
            this.txt_Producto.Location = new System.Drawing.Point(33, 250);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(319, 23);
            this.txt_Producto.TabIndex = 30;
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(33, 231);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(56, 15);
            this.lbl_Producto.TabIndex = 29;
            this.lbl_Producto.Text = "Producto";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(33, 327);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(133, 23);
            this.txt_Cantidad.TabIndex = 32;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(33, 308);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(55, 15);
            this.lbl_Cantidad.TabIndex = 31;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_PrecioFinal
            // 
            this.txt_PrecioFinal.Location = new System.Drawing.Point(179, 327);
            this.txt_PrecioFinal.Name = "txt_PrecioFinal";
            this.txt_PrecioFinal.Size = new System.Drawing.Size(171, 23);
            this.txt_PrecioFinal.TabIndex = 34;
            // 
            // lbl_PrecioFinal
            // 
            this.lbl_PrecioFinal.AutoSize = true;
            this.lbl_PrecioFinal.Location = new System.Drawing.Point(179, 308);
            this.lbl_PrecioFinal.Name = "lbl_PrecioFinal";
            this.lbl_PrecioFinal.Size = new System.Drawing.Size(66, 15);
            this.lbl_PrecioFinal.TabIndex = 33;
            this.lbl_PrecioFinal.Text = "Precio final";
            // 
            // btn_Ticket
            // 
            this.btn_Ticket.Location = new System.Drawing.Point(898, 556);
            this.btn_Ticket.Name = "btn_Ticket";
            this.btn_Ticket.Size = new System.Drawing.Size(75, 23);
            this.btn_Ticket.TabIndex = 30;
            this.btn_Ticket.Text = "Ticket";
            this.btn_Ticket.UseVisualStyleBackColor = true;
            this.btn_Ticket.Click += new System.EventHandler(this.btn_Ticket_Click);
            // 
            // Frm_abmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Controls.Add(this.btn_Ticket);
            this.Name = "Frm_abmVentas";
            this.Text = "Frm_abmVentas";
            this.Load += new System.EventHandler(this.Frm_abmVentas_Load);
            this.Controls.SetChildIndex(this.gpb_Lista, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.Controls.SetChildIndex(this.gpb_Datos, 0);
            this.Controls.SetChildIndex(this.txt_Editar, 0);
            this.Controls.SetChildIndex(this.btn_Listar, 0);
            this.Controls.SetChildIndex(this.btn_Limpiar, 0);
            this.Controls.SetChildIndex(this.btn_Ticket, 0);
            this.gpb_Lista.ResumeLayout(false);
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciototal;
        private System.Windows.Forms.Button btn_Ticket;
        public System.Windows.Forms.TextBox txt_PrecioFinal;
        public System.Windows.Forms.Label lbl_PrecioFinal;
        public System.Windows.Forms.TextBox txt_Cantidad;
        public System.Windows.Forms.Label lbl_Cantidad;
        public System.Windows.Forms.TextBox txt_Producto;
        public System.Windows.Forms.Label lbl_Producto;
        public System.Windows.Forms.TextBox txt_Cliente;
        public System.Windows.Forms.Label lbl_Cliente;
        public System.Windows.Forms.TextBox txt_Empleado;
        public System.Windows.Forms.Label lbl_Empleado;
        public System.Windows.Forms.DataGridView dgv_Lista;
    }
}