using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using EntidadesPetShop;

namespace PetShop
{
    public partial class Frm_Vender : Form
    {
        public Frm_Vender()
        {
            InitializeComponent();
        }

        private void btn_Ticket_Click(object sender, EventArgs e)
        {
            //string[] lineas = { $"Empleado: {lbl_NombreEmpleado.Text}\nCliente: {lbl_NombreCliente.Text}\nProducto: {txt_NombreProducto.Text}\nCantidad: {npd_Cantidad.Text}\nPrecio final: ${lbl_PrecioFinal.Text}" };
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(ComercioPetShop.Nombre);
            stringBuilder.Append(" " + ComercioPetShop.Cuit.ToString());
            stringBuilder.AppendLine(" " + ComercioPetShop.Direccion);
            stringBuilder.AppendFormat($" numero:  Fecha: {DateTime.Now.ToLongDateString()}");

            stringBuilder.AppendLine($"Precio final:  ${lbl_PrecioFinal}");
            //string[] detalles = new[] { stringBuilder.ToString() };
            using (StreamWriter outputFile = new StreamWriter("D:\\TUP\\2do Cuatrimestre 2021\\Programación y Laboratorio 2\\PetShop\\PetShop\\ticketVenta.txt"))
                //{
                //    foreach (string linea in detalles)
                //    {
                //        outputFile.WriteLine(linea);
                //        outputFile.WriteLine(detalles);
                //    }

                outputFile.WriteLine(stringBuilder.ToString());

            //foreach (string linea in lineas)
            //    {
            //        outputFile.WriteLine(linea);
            //    }
            MessageBox.Show("Ticket generado con exito");
        }
    }
}
