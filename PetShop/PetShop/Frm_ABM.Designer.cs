
namespace PetShop
{
    partial class Frm_ABM
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
            this.dgv_Tabla = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_Editar = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_Billetera = new System.Windows.Forms.TextBox();
            this.lbl_Billetera = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Tabla
            // 
            this.dgv_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tabla.Location = new System.Drawing.Point(12, 12);
            this.dgv_Tabla.Name = "dgv_Tabla";
            this.dgv_Tabla.RowTemplate.Height = 25;
            this.dgv_Tabla.Size = new System.Drawing.Size(446, 386);
            this.dgv_Tabla.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(544, 338);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(197, 34);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Location = new System.Drawing.Point(19, 417);
            this.txt_Editar.Name = "txt_Editar";
            this.txt_Editar.Size = new System.Drawing.Size(131, 23);
            this.txt_Editar.TabIndex = 2;
            this.txt_Editar.Text = "Editar";
            this.txt_Editar.UseVisualStyleBackColor = true;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(598, 28);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(94, 15);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "Datos del cliente";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(507, 87);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(507, 106);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(252, 23);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(507, 173);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(252, 23);
            this.txt_Apellido.TabIndex = 7;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(507, 154);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_Apellido.TabIndex = 6;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txt_Billetera
            // 
            this.txt_Billetera.Location = new System.Drawing.Point(507, 243);
            this.txt_Billetera.Name = "txt_Billetera";
            this.txt_Billetera.Size = new System.Drawing.Size(252, 23);
            this.txt_Billetera.TabIndex = 9;
            // 
            // lbl_Billetera
            // 
            this.lbl_Billetera.AutoSize = true;
            this.lbl_Billetera.Location = new System.Drawing.Point(507, 224);
            this.lbl_Billetera.Name = "lbl_Billetera";
            this.lbl_Billetera.Size = new System.Drawing.Size(49, 15);
            this.lbl_Billetera.TabIndex = 8;
            this.lbl_Billetera.Text = "Billetera";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(171, 417);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(131, 23);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Frm_ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 489);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txt_Billetera);
            this.Controls.Add(this.lbl_Billetera);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_Editar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dgv_Tabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM";
            this.Text = "Frm_ABM";
            this.Load += new System.EventHandler(this.Frm_ABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Tabla;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button txt_Editar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_Billetera;
        private System.Windows.Forms.Label lbl_Billetera;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}