using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionClub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestion_Clubes_DataBaseDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.gestion_Clubes_DataBaseDataSet1.cliente);

        }
    }
}
