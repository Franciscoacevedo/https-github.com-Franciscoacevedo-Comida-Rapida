using System;
using System.Windows.Forms;

namespace Perfil_Epidemiologico
{
    public partial class Listados : Form
    {
        public Listados()
        {
            InitializeComponent();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Hide();
            REPORTE r = new REPORTE();
            r.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Hide();
            PerfilEpidemiologico j = new PerfilEpidemiologico();
            j.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reporteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            REPORTE j = new REPORTE();
            j.Show();
        }
    }
}
