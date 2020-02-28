using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace FinalUTN2020
{
    public partial class frmFinal : Form
    {

        Queue<Cliente> clientesEnEspera;
        MEspecialidad mecanicoEspecialista;
        MGeneral mecanicoGeneral;
        Thread simulacion;
        public frmFinal()
        {
            this.mecanicoGeneral = new MGeneral("Luis", "Salinas");
            this.mecanicoEspecialista = new MEspecialidad("Jorge", "Iglesias", Entidades.Especialidad.Electricista);


            this.mecanicoGeneral.AtencionFinalizada += FinAtencion;
            this.mecanicoEspecialista.AtencionFinalizada += FinAtencion;


            InitializeComponent();
        }


        private void AtenderClientes(IMecanico IMecanico) {
            IMecanico.IniciarAtencion(clientesEnEspera.Dequeue());

        }
        private void btnMecanicaGral_Click(object sender, EventArgs e)
        {
            AtenderClientes(this.mecanicoGeneral);

        }



        private void btnMecanicaEspecifica_Click(object sender, EventArgs e)
        {
            if (clientesEnEspera != null) {
                if (clientesEnEspera.Count > 0)
                {

                    AtenderClientes(this.mecanicoEspecialista);
                }
            }
           
           
        }


        private void FinAtencion(Cliente c, Mecanico m) {

            MessageBox.Show("Finalizo la atencion de {0} ", c.nombre);
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            simulacion = new Thread(MockClientes);
            simulacion.Start();

        }

        private void frmFinal_Closing(object sender, EventArgs e)
        {
            simulacion.Abort();

        }

        public void MockClientes()
        {
            this.clientesEnEspera = new Queue<Cliente>();
            Cliente c = new Cliente("nombre", "apellido");
            this.clientesEnEspera.Enqueue(c);

            if(simulacion.IsAlive)
            {

                Thread.Sleep(1000);


            }


        }
    }
}
