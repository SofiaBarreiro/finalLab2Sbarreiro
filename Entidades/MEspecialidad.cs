using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{

    public enum Especialidad
    {
        Electricista,
        Chapista,
    }
    public class MEspecialidad : Mecanico, IMecanico
    {
        Especialidad especialidad;

        protected override void Atender()
        {
        }


        public void IniciarAtencion(Cliente c) {

            Thread hilo = new Thread(Atender);
            hilo.Start();

        }

       

        public MEspecialidad(string nombre, string apellido, Entidades.Especialidad especialidad)
            :base(nombre, apellido)
        {
            this.especialidad = especialidad;


        }
    }
}
