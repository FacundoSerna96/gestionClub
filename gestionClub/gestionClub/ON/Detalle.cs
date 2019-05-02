using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClub.ON
{
    class Detalle
    {
        //Atributos
        private int id;
        private int numFactura;
        private string producto;
        private int cantidad;
        private float importe;


        //Get and Set
        public int Id { get => id; set => id = value; }
        public int NumFactura { get => numFactura; set => numFactura = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Importe { get => importe; set => importe = value; }

        //Constructores

        public Detalle()
        {
            this.id = 0;
            this.numFactura = 0;
            this.producto = "";
            this.cantidad = 0;
            this.importe = 0.0F;
        }

        public Detalle(int id)
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
