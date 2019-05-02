using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionClub.ON
{
    class Cliente
    {
        //Atributos
        private int id;
        private string nombre;
        private bool activo;
        private int numLibreta;
        private DateTime fechaNacimiento;
        private string tutor1;
        private string tutor2;
        private string diciplina;
        private string graduacion;
        private string tel1;
        private string tel2;
        private string direccion;
        private string email;
        private byte fichaMedica;
        private byte fichaInscripcion;



        //Get and Set
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Activo { get => activo; set => activo = value; }
        public int NumLibreta { get => numLibreta; set => numLibreta = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Tutor1 { get => tutor1; set => tutor1 = value; }
        public string Tutor2 { get => tutor2; set => tutor2 = value; }
        public string Diciplina { get => diciplina; set => diciplina = value; }
        public string Graduacion { get => graduacion; set => graduacion = value; }
        public string Tel1 { get => tel1; set => tel1 = value; }
        public string Tel2 { get => tel2; set => tel2 = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public byte FichaMedica { get => fichaMedica; set => fichaMedica = value; }
        public byte FichaInscripcion { get => fichaInscripcion; set => fichaInscripcion = value; }


        //Constructores
        public Cliente()
        {
            this.id = 0;
            this.nombre = "";
            this.activo = false;
            this.numLibreta = 0;
            this.fechaNacimiento = new DateTime(1990, 04, 30);
            this.tutor1 = "";
            this.tutor2 = "";
            this.diciplina = "";
            this.graduacion = "";
            this.tel1 = "";
            this.tel2 = "";
            this.direccion = "";
            this.email = "";
            this.fichaInscripcion = new byte();
            this.fichaInscripcion = new byte();
        }

        public Cliente(int id)
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
