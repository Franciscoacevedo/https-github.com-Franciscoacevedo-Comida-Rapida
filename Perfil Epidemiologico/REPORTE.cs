using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perfil_Epidemiologico
{
    public partial class REPORTE : Form
    {
        public REPORTE()
        {
            InitializeComponent();
        }

#pragma warning disable CS0169 // The field 'REPORTE.printerSettings' is never used
        private object printerSettings;
#pragma warning restore CS0169 // The field 'REPORTE.printerSettings' is never used

        // private object conn;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog= Francisco; Integrated Security=True");

            // SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;DataBase=Francisco;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec PerfilFA ''";
            cmd.Parameters.AddWithValue("@ERROR", "");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();



            ////conn.Open();
            ////SqlCommand cmd = conn.CreateCommand();
            ////cmd.CommandType = CommandType.Text;
            ////cmd.CommandText = "SELECT * FROM  Generico where NombreDolencia like  ('" + textBox3.Text + "%' )";
            ////cmd.ExecuteNonQuery();
            ////DataTable dt = new DataTable();
            ////SqlDataAdapter da = new SqlDataAdapter(cmd);
            ////da.Fill(dt);
            ////dataGridView1.DataSource = dt;
            ////conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listados p = new Listados();
            this.Close();
            //  Listados p = new Listados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            //printerSettings ps = new PrinterSettings();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }


}







