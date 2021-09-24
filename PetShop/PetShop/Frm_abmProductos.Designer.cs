
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
            this.gpb_Lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(822, 572);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Location = new System.Drawing.Point(728, 572);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(911, 572);
            // 
            // gpb_Lista
            // 
            this.gpb_Lista.Location = new System.Drawing.Point(3, 6);
            this.gpb_Lista.Size = new System.Drawing.Size(686, 621);
            this.gpb_Lista.Text = "Lista de Productos";
            // 
            // lvw_Lista
            // 
            this.lvw_Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre,
            this.Categoria,
            this.Precio,
            this.Descripción,
            this.Marca,
            this.Stock});
            this.lvw_Lista.Location = new System.Drawing.Point(12, 21);
            this.lvw_Lista.Size = new System.Drawing.Size(662, 591);
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Location = new System.Drawing.Point(695, 6);
            this.gpb_Datos.Size = new System.Drawing.Size(336, 621);
            this.gpb_Datos.Text = "Datos del producto";
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
            // Frm_abmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Name = "Frm_abmProductos";
            this.Text = "Frm_abmProductos";
            this.gpb_Lista.ResumeLayout(false);
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
    }
}