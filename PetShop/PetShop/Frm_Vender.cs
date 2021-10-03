﻿using System;
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
        private int indice = 0;
        private int auxIdProducto = -1;
        private int auxIdCliente = -1;
        private double iva = 0.21;
        private double acumuladorVenta = 0;
        private double acumuladorVentaConIva = 0;
        Empleado empleadoActivo = new Empleado();        
        List<Cliente> clientes = new List<Cliente>();
        List<Producto> productos = new List<Producto>();
        List<VentasHistoricas> ventasHistoricas = new List<VentasHistoricas>();
        List<Producto> carrito = new List<Producto>();
        List<decimal> cantidad = new List<decimal>();
        public Frm_Vender()
        {
            InitializeComponent();
        }

        public Frm_Vender(Empleado empleadoActivo) : this()
        {
            this.empleadoActivo = empleadoActivo;
        }

        private void Frm_Vender_Load(object sender, EventArgs e)
        {
            lbl_NombreComercio.Text = ComercioPetShop.Nombre;
            lbl_NombreDireccion.Text = ComercioPetShop.Direccion;
            lbl_NombreRazonSoc.Text = ComercioPetShop.RazonSocial;
            lbl_NumCuit.Text = ComercioPetShop.Cuit.ToString();
            lbl_NombreEmpleado.Text = empleadoActivo.Nombre;
            lbl_numFecha.Text = DateTime.Now.ToShortDateString();
            clientes = ComercioPetShop.ListaClientes;
            productos = ComercioPetShop.ListaProductos;
            ventasHistoricas = ComercioPetShop.ListaVentasHistoricas;
            ListarBases();
        }

        public void ListarBases()
        {
            dgv_ListaClientes.Rows.Clear();
            dgv_ListaProductos.Rows.Clear();
            foreach (Cliente item in clientes)
            {
                indice = dgv_ListaClientes.Rows.Add();
                dgv_ListaClientes .Rows[indice].Cells[0].Value = item.Id;
                dgv_ListaClientes.Rows[indice].Cells[1].Value = item.Nombre;
                dgv_ListaClientes.Rows[indice].Cells[2].Value = item.Dni;
            }

            foreach (Producto item in productos)
            {
                indice = dgv_ListaProductos.Rows.Add();
                dgv_ListaProductos.Rows[indice].Cells[0].Value = item.IdProducto;
                dgv_ListaProductos.Rows[indice].Cells[1].Value = item.Nombre;
                dgv_ListaProductos.Rows[indice].Cells[2].Value = item.Categoria;
                dgv_ListaProductos.Rows[indice].Cells[3].Value = item.Precio;
            }
        }

        private void dgv_ListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                lbl_NombreCliente.Text = dgv_ListaClientes.Rows[indice].Cells[1].Value.ToString();
                auxIdCliente = int.Parse(dgv_ListaClientes.Rows[indice].Cells[0].Value.ToString());
            }
        }

        private void dgv_Facturacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void dgv_ListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                txt_NombreProducto.Text = dgv_ListaProductos.Rows[indice].Cells[1].Value.ToString();
                txt_Precio.Text = dgv_ListaProductos.Rows[indice].Cells[3].Value.ToString();
                auxIdProducto = int.Parse(dgv_ListaProductos.Rows[indice].Cells[0].Value.ToString());
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_NombreCliente.Text) && !string.IsNullOrEmpty(txt_NombreProducto.Text) && npd_Cantidad.Value > 0)
            {

                foreach (Producto item in productos)
                {
                    if (item.IdProducto == auxIdProducto)
                    {
                        if (item.Stock >= npd_Cantidad.Value)
                        {
                            indice = dgv_Facturacion.Rows.Add();
                            dgv_Facturacion.Rows[indice].Cells[0].Value = item.IdProducto;
                            dgv_Facturacion.Rows[indice].Cells[1].Value = npd_Cantidad.Value;
                            dgv_Facturacion.Rows[indice].Cells[2].Value = item.Nombre;
                            dgv_Facturacion.Rows[indice].Cells[3].Value = item.Descripcion;
                            dgv_Facturacion.Rows[indice].Cells[4].Value = item.Precio;
                            dgv_Facturacion.Rows[indice].Cells[5].Value = (item.Precio * (double)npd_Cantidad.Value).ToString("N2");
                            acumuladorVenta += item.Precio * (double)npd_Cantidad.Value;
                            acumuladorVentaConIva += item.Precio * (double)npd_Cantidad.Value;
                            carrito += ComercioPetShop.ObtenerProducto(auxIdProducto);
                            cantidad.Add(npd_Cantidad.Value);

                            lbl_PrecioFinal.Text = acumuladorVenta.ToString("N2");
                            acumuladorVentaConIva += (acumuladorVentaConIva *= iva);
                            lbl_masIva.Text = acumuladorVentaConIva.ToString("N2");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No hay stock", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Elegir cliente y/o producto y cargar cantidad", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {            
            if (indice > -1 && indice < dgv_Facturacion.RowCount)
            {
                dgv_Facturacion.Rows.RemoveAt(indice);
                carrito.RemoveAt(indice);
                cantidad.RemoveAt(indice);

                foreach (Producto item in productos)
                {
                    if (item.IdProducto == auxIdProducto)
                    {
                        double aux = 0;
                        acumuladorVenta -= item.Precio * (double)npd_Cantidad.Value;
                        aux = item.Precio * (double)npd_Cantidad.Value;
                        acumuladorVentaConIva -= (aux *= iva);
                        acumuladorVentaConIva -= item.Precio * (double)npd_Cantidad.Value;
                    }
                }
                lbl_PrecioFinal.Text = acumuladorVenta.ToString("N2");                
                lbl_masIva.Text = acumuladorVentaConIva.ToString("N2");
            }
            else
            {
                MessageBox.Show("Seleccione el producto de la factura que desea eliminar", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            if (dgv_Facturacion.RowCount > 0 && ComercioPetShop.ObtenerCliente(auxIdCliente).Saldo > acumuladorVenta)
            {                
                ventasHistoricas += VentasHistoricas.CargarVenta(empleadoActivo, ComercioPetShop.ObtenerCliente(auxIdCliente), carrito, cantidad, lbl_numFecha.Text, acumuladorVenta);                
                MessageBox.Show("Venta exitosa!");
            }
            else
            {
                MessageBox.Show("El carrito esta vacío o su saldo es insuficiente para realizar la compra");
            }
        }




        private void Limpiar()
        {
            lbl_NombreCliente.Text = string.Empty;
            txt_NombreProducto.Text = string.Empty;
            txt_Precio.Text = string.Empty;
            npd_Cantidad.Value = 0;
            lbl_PrecioFinal.Text = "0.00";
            dgv_Facturacion.Rows.Clear();
            lbl_masIva.Text = string.Empty;
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



    //        dgv_Facturacion.Rows[indice].Cells[0].Value = item.IdProducto;
    //        dgv_Facturacion.Rows[indice].Cells[1].Value = npd_Cantidad.Value;
    //        dgv_Facturacion.Rows[indice].Cells[2].Value = item.Nombre;
    //        dgv_Facturacion.Rows[indice].Cells[3].Value = item.Descripcion;
    //        dgv_Facturacion.Rows[indice].Cells[4].Value = item.Precio;
    //        dgv_Facturacion.Rows[indice].Cells[5].Value = (item.Precio * (double)npd_Cantidad.Value).ToString("N2");
    //        acumuladorVenta += item.Precio * (double)npd_Cantidad.Value;
    //    }
    //}
    //lbl_PrecioFinal.Text = acumuladorVenta.ToString("N2");


        }

        
    }
}
