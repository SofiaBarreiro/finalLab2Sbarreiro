using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Mecanico : Persona
    {


        private Cliente clienteActual;
        protected static Random tiempoAleatorio;
        public delegate void FinAtencionCliente(Cliente x, Mecanico y);
        public event FinAtencionCliente AtencionFinalizada;


        public Cliente AtenderA
        {
            set { this.clienteActual = value; }
        }




        public virtual string EstaAtendiendoA
        {
            get { return this.clienteActual.ToString(); }
        }

        protected abstract void Atender();

        public void FinalizarAtencion(Cliente c)
        {
            this.AtencionFinalizada(c, null);
            this.clienteActual = null;


        }


        static Mecanico()
        {
           Mecanico.tiempoAleatorio = new Random();

        }


        public Mecanico(string nombre, string apellido)
            :base(nombre, apellido)
        {


        }


    }
}
