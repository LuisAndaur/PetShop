
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.gpb_Lista = new System.Windows.Forms.GroupBox();
            this.lvw_Lista = new System.Windows.Forms.ListView();
            this.gpb_Datos = new System.Windows.Forms.GroupBox();
            this.gpb_Lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(140, 505);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(83, 23);
            this.btn_Eliminar.TabIndex = 25;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_Editar
            // 
            this.txt_Editar.Location = new System.Drawing.Point(46, 505);
            this.txt_Editar.Name = "txt_Editar";
            this.txt_Editar.Size = new System.Drawing.Size(83, 23);
            this.txt_Editar.TabIndex = 24;
            this.txt_Editar.Text = "Editar";
            this.txt_Editar.UseVisualStyleBackColor = true;
            this.txt_Editar.Click += new System.EventHandler(this.txt_Editar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(229, 505);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(83, 23);
            this.btn_Guardar.TabIndex = 23;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // gpb_Lista
            // 
            this.gpb_Lista.Controls.Add(this.lvw_Lista);
            this.gpb_Lista.Location = new System.Drawing.Point(12, 12);
            this.gpb_Lista.Name = "gpb_Lista";
            this.gpb_Lista.Size = new System.Drawing.Size(378, 265);
            this.gpb_Lista.TabIndex = 26;
            this.gpb_Lista.TabStop = false;
            this.gpb_Lista.Text = "Lista de ";
            // 
            // lvw_Lista
            // 
            this.lvw_Lista.HideSelection = false;
            this.lvw_Lista.Location = new System.Drawing.Point(20, 28);
            this.lvw_Lista.Name = "lvw_Lista";
            this.lvw_Lista.Size = new System.Drawing.Size(352, 237);
            this.lvw_Lista.TabIndex = 0;
            this.lvw_Lista.UseCompatibleStateImageBehavior = false;
            this.lvw_Lista.View = System.Windows.Forms.View.Details;
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Location = new System.Drawing.Point(12, 301);
            this.gpb_Datos.Name = "gpb_Datos";
            this.gpb_Datos.Size = new System.Drawing.Size(371, 160);
            this.gpb_Datos.TabIndex = 27;
            this.gpb_Datos.TabStop = false;
            this.gpb_Datos.Text = "Datos ";
            // 
            // Frm_abmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 630);
            this.Controls.Add(this.txt_Editar);
            this.Controls.Add(this.gpb_Datos);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.gpb_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_abmBase";
            this.Text = "Frm_ABM";
            this.Load += new System.EventHandler(this.Frm_ABM_Load);
            this.gpb_Lista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button txt_Editar;
        public System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.GroupBox gpb_Lista;
        public System.Windows.Forms.ListView lvw_Lista;
        public System.Windows.Forms.GroupBox gpb_Datos;
    }
}