using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {


        public int turno;
        private static int ultimoTurnoDado;


        public Cliente Turno
        {
            get { return this; }
        }

        static Cliente()
        {
            Cliente.ultimoTurnoDado = 0;
            
        }
        public Cliente(string nombre, string apellido)
            :base(nombre, apellido)
        {
            Cliente.ultimoTurnoDado = 0;

        }
        public Cliente(string nombre, string apellido, int turno)
           : base(nombre, apellido)
        {

            
            this.turno = Cliente.ultimoTurnoDado + 1;

        }

        public string toString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat("Turno Nº {0} {1} {2}\n", this.Turno, this.apellido, this.nombre);

            return cadena.ToString();

        }



    }
}
