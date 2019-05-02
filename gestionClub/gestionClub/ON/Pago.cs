using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClub.ON
{
    class Pago
    {
        //Atributos
        private int id;
        private string medioPago;
        private string estado;
        private int cuota;
        private int cuotaTotal;
        private float importe;

        //Get and Set
        public int Id { get => id; set => id = value; }
        public string MedioPago { get => medioPago; set => medioPago = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Cuota { get => cuota; set => cuota = value; }
        public int CuotaTotal { get => cuotaTotal; set => cuotaTotal = value; }
        public float Importe { get => importe; set => importe = value; }

        //Constructores
        public Pago()
        {
            this.id = 0;
            this.medioPago = "";
            this.estado = "";
            this.cuota = 0;
            this.cuotaTotal = 0;
            this.importe = 0.0F;
        }

        public Pago(int id)
        {

        }

        //Metodos
        public void cargar(int id)
        {

        }

        public void guardar()
        {

        }

        public void borrar()
        {

        }
    }
}
