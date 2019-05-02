using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionClub.Forms
{
    public partial class ModuloClientes : Form
    {
        public ModuloClientes()
        {
            InitializeComponent();          
        }

        private void ModuloClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestion_Clubes_DataBaseDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.gestion_Clubes_DataBaseDataSet.cliente);
            toolStripStatusLabel1.Alignment = ToolStripItemAlignment.Right;
        }

        private void explorarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuloProductos mp = new ModuloProductos();
            mp.ShowDialog();
        }

        private void explorarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuloFacturas mf = new ModuloFacturas();
            mf.ShowDialog();
        }

        private void explorarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuloPedido mpe = new ModuloPedido();
            mpe.ShowDialog();
        }

        private void sobreGestionClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/spider.exe");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Configuracion conf = new Configuracion();
            conf.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
