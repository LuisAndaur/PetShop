﻿
namespace PetShop
{
    partial class Frm_Vender
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
            this.gpb_Clientes = new System.Windows.Forms.GroupBox();
            this.dgv_ListaClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_Productos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_Facturacion = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gpb_Detalle = new System.Windows.Forms.GroupBox();
            this.lbl_NumCuit = new System.Windows.Forms.Label();
            this.lbl_Cuit = new System.Windows.Forms.Label();
            this.lbl_NombreDireccion = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_NombreRazonSoc = new System.Windows.Forms.Label();
            this.lbl_RazonSocial = new System.Windows.Forms.Label();
            this.lbl_NombreComercio = new System.Windows.Forms.Label();
            this.lbl_Comercio = new System.Windows.Forms.Label();
            this.lbl_Empleado = new System.Windows.Forms.Label();
            this.lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.lbl_PrecioFinal = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.npd_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Importe = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Vender = new System.Windows.Forms.Button();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_Ticket = new System.Windows.Forms.Button();
            this.lbl_numFecha = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaClientes)).BeginInit();
            this.gpb_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpb_Facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gpb_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npd_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_Clientes
            // 
            this.gpb_Clientes.Controls.Add(this.dgv_ListaClientes);
            this.gpb_Clientes.Location = new System.Drawing.Point(2, 5);
            this.gpb_Clientes.Name = "gpb_Clientes";
            this.gpb_Clientes.Size = new System.Drawing.Size(286, 297);
            this.gpb_Clientes.TabIndex = 0;
            this.gpb_Clientes.TabStop = false;
            this.gpb_Clientes.Text = "Lista de clientes";
            // 
            // dgv_ListaClientes
            // 
            this.dgv_ListaClientes.AllowUserToAddRows = false;
            this.dgv_ListaClientes.AllowUserToDeleteRows = false;
            this.dgv_ListaClientes.AllowUserToOrderColumns = true;
            this.dgv_ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.DNI});
            this.dgv_ListaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListaClientes.Location = new System.Drawing.Point(3, 19);
            this.dgv_ListaClientes.Name = "dgv_ListaClientes";
            this.dgv_ListaClientes.ReadOnly = true;
            this.dgv_ListaClientes.RowTemplate.Height = 25;
            this.dgv_ListaClientes.Size = new System.Drawing.Size(280, 275);
            this.dgv_ListaClientes.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // gpb_Productos
            // 
            this.gpb_Productos.Controls.Add(this.dataGridView1);
            this.gpb_Productos.Location = new System.Drawing.Point(295, 5);
            this.gpb_Productos.Name = "gpb_Productos";
            this.gpb_Productos.Size = new System.Drawing.Size(384, 297);
            this.gpb_Productos.TabIndex = 1;
            this.gpb_Productos.TabStop = false;
            this.gpb_Productos.Text = "Lista de productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Categoria,
            this.Descripcion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(378, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // gpb_Facturacion
            // 
            this.gpb_Facturacion.Controls.Add(this.dataGridView2);
            this.gpb_Facturacion.Location = new System.Drawing.Point(5, 308);
            this.gpb_Facturacion.Name = "gpb_Facturacion";
            this.gpb_Facturacion.Size = new System.Drawing.Size(674, 319);
            this.gpb_Facturacion.TabIndex = 2;
            this.gpb_Facturacion.TabStop = false;
            this.gpb_Facturacion.Text = "Facturación";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Cant,
            this.Producto,
            this.dataGridViewTextBoxColumn5,
            this.Precio,
            this.Total});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(668, 297);
            this.dataGridView2.TabIndex = 0;
            // 
            // gpb_Detalle
            // 
            this.gpb_Detalle.Controls.Add(this.lbl_NumCuit);
            this.gpb_Detalle.Controls.Add(this.lbl_Cuit);
            this.gpb_Detalle.Controls.Add(this.lbl_NombreDireccion);
            this.gpb_Detalle.Controls.Add(this.lbl_Direccion);
            this.gpb_Detalle.Controls.Add(this.lbl_NombreRazonSoc);
            this.gpb_Detalle.Controls.Add(this.lbl_RazonSocial);
            this.gpb_Detalle.Controls.Add(this.lbl_NombreComercio);
            this.gpb_Detalle.Controls.Add(this.lbl_Comercio);
            this.gpb_Detalle.Location = new System.Drawing.Point(685, 5);
            this.gpb_Detalle.Name = "gpb_Detalle";
            this.gpb_Detalle.Size = new System.Drawing.Size(345, 128);
            this.gpb_Detalle.TabIndex = 3;
            this.gpb_Detalle.TabStop = false;
            this.gpb_Detalle.Text = "Detalle de factura";
            // 
            // lbl_NumCuit
            // 
            this.lbl_NumCuit.AutoSize = true;
            this.lbl_NumCuit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NumCuit.Location = new System.Drawing.Point(198, 91);
            this.lbl_NumCuit.Name = "lbl_NumCuit";
            this.lbl_NumCuit.Size = new System.Drawing.Size(14, 19);
            this.lbl_NumCuit.TabIndex = 9;
            this.lbl_NumCuit.Text = "/";
            // 
            // lbl_Cuit
            // 
            this.lbl_Cuit.AutoSize = true;
            this.lbl_Cuit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cuit.Location = new System.Drawing.Point(194, 72);
            this.lbl_Cuit.Name = "lbl_Cuit";
            this.lbl_Cuit.Size = new System.Drawing.Size(34, 19);
            this.lbl_Cuit.TabIndex = 8;
            this.lbl_Cuit.Text = "Cuit";
            // 
            // lbl_NombreDireccion
            // 
            this.lbl_NombreDireccion.AutoSize = true;
            this.lbl_NombreDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreDireccion.Location = new System.Drawing.Point(198, 46);
            this.lbl_NombreDireccion.Name = "lbl_NombreDireccion";
            this.lbl_NombreDireccion.Size = new System.Drawing.Size(14, 19);
            this.lbl_NombreDireccion.TabIndex = 7;
            this.lbl_NombreDireccion.Text = "/";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Direccion.Location = new System.Drawing.Point(194, 27);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(65, 19);
            this.lbl_Direccion.TabIndex = 6;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_NombreRazonSoc
            // 
            this.lbl_NombreRazonSoc.AutoSize = true;
            this.lbl_NombreRazonSoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreRazonSoc.Location = new System.Drawing.Point(25, 91);
            this.lbl_NombreRazonSoc.Name = "lbl_NombreRazonSoc";
            this.lbl_NombreRazonSoc.Size = new System.Drawing.Size(14, 19);
            this.lbl_NombreRazonSoc.TabIndex = 5;
            this.lbl_NombreRazonSoc.Text = "/";
            // 
            // lbl_RazonSocial
            // 
            this.lbl_RazonSocial.AutoSize = true;
            this.lbl_RazonSocial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_RazonSocial.Location = new System.Drawing.Point(21, 72);
            this.lbl_RazonSocial.Name = "lbl_RazonSocial";
            this.lbl_RazonSocial.Size = new System.Drawing.Size(83, 19);
            this.lbl_RazonSocial.TabIndex = 4;
            this.lbl_RazonSocial.Text = "Razon social";
            // 
            // lbl_NombreComercio
            // 
            this.lbl_NombreComercio.AutoSize = true;
            this.lbl_NombreComercio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreComercio.Location = new System.Drawing.Point(25, 46);
            this.lbl_NombreComercio.Name = "lbl_NombreComercio";
            this.lbl_NombreComercio.Size = new System.Drawing.Size(14, 19);
            this.lbl_NombreComercio.TabIndex = 3;
            this.lbl_NombreComercio.Text = "/";
            // 
            // lbl_Comercio
            // 
            this.lbl_Comercio.AutoSize = true;
            this.lbl_Comercio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Comercio.Location = new System.Drawing.Point(21, 27);
            this.lbl_Comercio.Name = "lbl_Comercio";
            this.lbl_Comercio.Size = new System.Drawing.Size(67, 19);
            this.lbl_Comercio.TabIndex = 2;
            this.lbl_Comercio.Text = "Comercio";
            // 
            // lbl_Empleado
            // 
            this.lbl_Empleado.AutoSize = true;
            this.lbl_Empleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Empleado.Location = new System.Drawing.Point(710, 159);
            this.lbl_Empleado.Name = "lbl_Empleado";
            this.lbl_Empleado.Size = new System.Drawing.Size(72, 19);
            this.lbl_Empleado.TabIndex = 0;
            this.lbl_Empleado.Text = "Empleado:";
            // 
            // lbl_NombreEmpleado
            // 
            this.lbl_NombreEmpleado.AutoSize = true;
            this.lbl_NombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreEmpleado.Location = new System.Drawing.Point(780, 159);
            this.lbl_NombreEmpleado.Name = "lbl_NombreEmpleado";
            this.lbl_NombreEmpleado.Size = new System.Drawing.Size(14, 19);
            this.lbl_NombreEmpleado.TabIndex = 1;
            this.lbl_NombreEmpleado.Text = "/";
            // 
            // lbl_PrecioFinal
            // 
            this.lbl_PrecioFinal.AutoSize = true;
            this.lbl_PrecioFinal.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PrecioFinal.Location = new System.Drawing.Point(872, 442);
            this.lbl_PrecioFinal.Name = "lbl_PrecioFinal";
            this.lbl_PrecioFinal.Size = new System.Drawing.Size(126, 54);
            this.lbl_PrecioFinal.TabIndex = 2;
            this.lbl_PrecioFinal.Text = "$0.00";
            this.lbl_PrecioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cliente.Location = new System.Drawing.Point(710, 196);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(51, 19);
            this.lbl_Cliente.TabIndex = 3;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // npd_Cantidad
            // 
            this.npd_Cantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npd_Cantidad.Location = new System.Drawing.Point(915, 327);
            this.npd_Cantidad.Name = "npd_Cantidad";
            this.npd_Cantidad.Size = new System.Drawing.Size(91, 25);
            this.npd_Cantidad.TabIndex = 4;
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreCliente.Location = new System.Drawing.Point(771, 196);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(14, 19);
            this.lbl_NombreCliente.TabIndex = 5;
            this.lbl_NombreCliente.Text = "/";
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Producto.Location = new System.Drawing.Point(705, 235);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(65, 19);
            this.lbl_Producto.TabIndex = 6;
            this.lbl_Producto.Text = "Producto";
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NombreProducto.Location = new System.Drawing.Point(710, 257);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(296, 25);
            this.txt_NombreProducto.TabIndex = 7;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Precio.Location = new System.Drawing.Point(710, 306);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(46, 19);
            this.lbl_Precio.TabIndex = 8;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Importe
            // 
            this.lbl_Importe.AutoSize = true;
            this.lbl_Importe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Importe.Location = new System.Drawing.Point(713, 465);
            this.lbl_Importe.Name = "lbl_Importe";
            this.lbl_Importe.Size = new System.Drawing.Size(85, 25);
            this.lbl_Importe.TabIndex = 9;
            this.lbl_Importe.Text = "Importe";
            this.lbl_Importe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cantidad.Location = new System.Drawing.Point(915, 299);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(64, 19);
            this.lbl_Cantidad.TabIndex = 10;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Precio.Location = new System.Drawing.Point(710, 328);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(174, 25);
            this.txt_Precio.TabIndex = 11;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(713, 375);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(91, 35);
            this.btn_Agregar.TabIndex = 12;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(814, 375);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(91, 35);
            this.btn_Limpiar.TabIndex = 13;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(915, 375);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(91, 35);
            this.btn_Eliminar.TabIndex = 14;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Vender
            // 
            this.btn_Vender.Location = new System.Drawing.Point(713, 508);
            this.btn_Vender.Name = "btn_Vender";
            this.btn_Vender.Size = new System.Drawing.Size(285, 67);
            this.btn_Vender.TabIndex = 15;
            this.btn_Vender.Text = "Vender";
            this.btn_Vender.UseVisualStyleBackColor = true;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Fecha.Location = new System.Drawing.Point(883, 159);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(44, 19);
            this.lbl_Fecha.TabIndex = 17;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // btn_Ticket
            // 
            this.btn_Ticket.Location = new System.Drawing.Point(713, 585);
            this.btn_Ticket.Name = "btn_Ticket";
            this.btn_Ticket.Size = new System.Drawing.Size(285, 32);
            this.btn_Ticket.TabIndex = 18;
            this.btn_Ticket.Text = "Generar Ticket";
            this.btn_Ticket.UseVisualStyleBackColor = true;
            this.btn_Ticket.Click += new System.EventHandler(this.btn_Ticket_Click);
            // 
            // lbl_numFecha
            // 
            this.lbl_numFecha.AutoSize = true;
            this.lbl_numFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_numFecha.Location = new System.Drawing.Point(883, 178);
            this.lbl_numFecha.Name = "lbl_numFecha";
            this.lbl_numFecha.Size = new System.Drawing.Size(44, 19);
            this.lbl_numFecha.TabIndex = 19;
            this.lbl_numFecha.Text = "Fecha";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cant";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 210;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Frm_Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Controls.Add(this.lbl_numFecha);
            this.Controls.Add(this.btn_Ticket);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.btn_Vender);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.gpb_Detalle);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.lbl_NombreEmpleado);
            this.Controls.Add(this.gpb_Facturacion);
            this.Controls.Add(this.lbl_Empleado);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.gpb_Productos);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.gpb_Clientes);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_PrecioFinal);
            this.Controls.Add(this.lbl_Importe);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.npd_Cantidad);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.lbl_NombreCliente);
            this.Controls.Add(this.lbl_Producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Vender";
            this.Text = "Frm_Vender";
            this.gpb_Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaClientes)).EndInit();
            this.gpb_Productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpb_Facturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gpb_Detalle.ResumeLayout(false);
            this.gpb_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npd_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Clientes;
        private System.Windows.Forms.DataGridView dgv_ListaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.GroupBox gpb_Productos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.GroupBox gpb_Facturacion;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gpb_Detalle;
        private System.Windows.Forms.Label lbl_PrecioFinal;
        private System.Windows.Forms.Label lbl_NombreEmpleado;
        private System.Windows.Forms.Label lbl_Empleado;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.NumericUpDown npd_Cantidad;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_Importe;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Comercio;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Vender;
        private System.Windows.Forms.Label lbl_NumCuit;
        private System.Windows.Forms.Label lbl_Cuit;
        private System.Windows.Forms.Label lbl_NombreDireccion;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_NombreRazonSoc;
        private System.Windows.Forms.Label lbl_RazonSocial;
        private System.Windows.Forms.Label lbl_NombreComercio;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Button btn_Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lbl_numFecha;
    }
}