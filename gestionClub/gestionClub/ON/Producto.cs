using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClub.ON
{
    class Producto
    {
        //Atributos
        private int id;
        private string nombre;
        private bool acumulaStock;
        private int stock;
        private float precioCompra;
        private float precioVenta;

        //Get and Set
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool AcumulaStock { get => acumulaStock; set => acumulaStock = value; }
        public int Stock { get => stock; set => stock = value; }
        public float PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public float PrecioVenta { get => precioVenta; set => precioVenta = value; }

        //Constructores
        public Producto(int id)
        {

        }

        public Producto()
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
