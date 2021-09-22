using System;

namespace EntidadesPetShop
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int id;        
        private double billetera;
                

        protected Persona(string nombre, string apellido, double billetera)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.billetera = billetera;
        }

        public double Billetera
        {
            get { return billetera; }
            set { billetera = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public abstract double DepositoBilletera();
        public abstract double ExtraccionBilletera();

    }
}
