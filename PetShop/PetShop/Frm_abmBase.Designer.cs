
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
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
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
            this.gpb_Datos.Location = new System.Drawing.Point(652, 5);
            this.gpb_Datos.Name = "gpb_Datos";
            this.gpb_Datos.Size = new System.Drawing.Size(379, 530);
            this.gpb_Datos.TabIndex = 27;
            this.gpb_Datos.TabStop = false;
            this.gpb_Datos.Text = "Datos ";
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
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // Frm_abmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.txt_Editar);
            this.Controls.Add(this.gpb_Datos);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.gpb_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_abmBase";
            this.Text = "Frm_ABM";
            this.Load += new System.EventHandler(this.Frm_ABM_Load);
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
    }
}