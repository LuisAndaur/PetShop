using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPetShop;

namespace PetShop
{
    public partial class Frm_abmVentas : Frm_abmBase
    {
        private int indice = 0;
        List<VentasHistoricas> ventasHistoricas = new List<VentasHistoricas>();
        public Frm_abmVentas()
        {
            InitializeComponent();
        }

        private void Frm_abmVentas_Load(object sender, EventArgs e)
        {
            ventasHistoricas = ComercioPetShop.ListaVentasHistoricas;
            ListarBase();
        }

        public override void ListarBase()
        {
            dgv_Lista.Rows.Clear();
            foreach (VentasHistoricas item in ventasHistoricas)
            {
                int indice = dgv_Lista.Rows.Add();
                dgv_Lista.Rows[indice].Cells[0].Value = item.IdVenta;
                dgv_Lista.Rows[indice].Cells[1].Value = item.Empleado.Nombre;
                dgv_Lista.Rows[indice].Cells[2].Value = item.Cliente.Nombre;
                dgv_Lista.Rows[indice].Cells[3].Value = item.Producto.Nombre;
                dgv_Lista.Rows[indice].Cells[4].Value = item.Cantidad;
                dgv_Lista.Rows[indice].Cells[5].Value = item.PrecioTotal;
            }
        }

        private void dgv_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                txt_Id.Text = dgv_Lista.Rows[indice].Cells[0].Value.ToString();
                txt_Empleado.Text = dgv_Lista.Rows[indice].Cells[1].Value.ToString();
                txt_Cliente.Text = dgv_Lista.Rows[indice].Cells[2].Value.ToString();
                txt_Producto.Text = dgv_Lista.Rows[indice].Cells[3].Value.ToString();
                txt_Cantidad.Text = dgv_Lista.Rows[indice].Cells[4].Value.ToString();
                txt_PrecioFinal.Text = dgv_Lista.Rows[indice].Cells[5].Value.ToString();
            }
        }

        public override void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public override void Limpiar()
        {
            txt_Id.Text = string.Empty;
            txt_Empleado.Text = string.Empty;
            txt_Cliente.Text = string.Empty;
            txt_Producto.Text = string.Empty;
            txt_Cantidad.Text = string.Empty;
            txt_PrecioFinal.Text = string.Empty;
        }

        public override void txt_Editar_Click(object sender, EventArgs e)
        {

        }

        public override void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        public override void btn_Agregar_Click(object sender, EventArgs e)
        {

        }


        private void btn_Ticket_Click(object sender, EventArgs e)
        {
            string[] lineas = {$"Empleado: {txt_Empleado.Text}\nCliente: {txt_Cliente.Text}\nProducto: {txt_Producto.Text}\nCantidad: {txt_Cantidad.Text}\nPrecio final: ${txt_PrecioFinal.Text}" };
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append(ComercioPetShop.Nombre);
            //stringBuilder.Append(" " + ComercioPetShop.Cuit.ToString());
            //stringBuilder.AppendLine(" " + ComercioPetShop.Direccion);
            //stringBuilder.AppendFormat($" numero: {txt_Id} Fecha {DateTime.Now.ToLongDateString()}");

            //stringBuilder.AppendLine($"Precio final:  ${txt_PrecioFinal}");
            //string[] detalles = new[] { stringBuilder.ToString() };
            using (StreamWriter outputFile = new StreamWriter("D:\\TUP\\2do Cuatrimestre 2021\\Programación y Laboratorio 2\\PetShop\\PetShop\\ticketVenta.txt"))
            //{
            //    foreach (string linea in detalles)
            //    {
            //        outputFile.WriteLine(linea);
            //        outputFile.WriteLine(detalles);
            //    }



            foreach (string linea in lineas)
            {
                outputFile.WriteLine(linea);
            }
            MessageBox.Show("Ticket generado con exito");
        }

        
    }
}
