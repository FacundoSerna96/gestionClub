using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClub.ON
{
    class Factura
    {
        //Atributos
        private int id;
        private int num;
        private string cliente;
        private DateTime fecha;
        private string estado;

        //Get and Set
        public int Id { get => id; set => id = value; }
        public int Num { get => num; set => num = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }

        //Constructore
        public Factura(int id)
        {
            this.id = 0;
            this.num = 0;
            this.cliente = "";
            this.fecha = new DateTime();
            this.estado = "";
        }
        public Factura()
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
