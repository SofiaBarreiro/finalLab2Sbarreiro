using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class MGeneral : Mecanico, IMecanico
    {


        protected override void Atender()
        {
            Random nuevoRandom = new Random();
            Thread.Sleep(nuevoRandom.Next(1500, 2200));
            //this.FinalizarAtencion();

        }
       

        public MGeneral(string nombre, string apellido)
            :base(nombre, apellido)
        {

        }



        public void IniciarAtencion(Cliente c)
        {
            Thread hilo = new Thread(Atender);
            hilo.Start();
        }

    }
}
