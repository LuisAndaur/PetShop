﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPetShop;

namespace PetShop
{
    public partial class Frm_abmBase : Form
    {
        public Frm_abmBase()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
            this.TransparencyKey = Color.LightGray;
        }

        public virtual void ListarBase()
        {
            
        }

        public virtual void txt_Editar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        

        public virtual void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btn_Limpiar_Click(object sender, EventArgs e)
        {

        }

        public virtual void Limpiar()
        {

        }

        public virtual void btn_Listar_Click(object sender, EventArgs e)
        {

        }

    }
}
