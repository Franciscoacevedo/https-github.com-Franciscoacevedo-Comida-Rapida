using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perfil_Epidemiologico
{
    public partial class Form3 : Form
    {
        ReportDocument Cryrpt = new ReportDocument();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog=Francisco; Integrated Security=True");
#pragma warning disable CS0169 // The field 'Form3.sda' is never used
        SqlDataAdapter sda;
#pragma warning restore CS0169 // The field 'Form3.sda' is never used

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog= Francisco; Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec FacturaConDetalle";
            // cmd.Parameters.AddWithValue("@ERROR", "");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            con.Close();


            SqlDataAdapter sda = new SqlDataAdapter("exec FacturaConDetalle ", con);
            DataSet dst = new DataSet();
            sda.Fill(dst, "FacturaConDetalle");
            Cryrpt.Load(@"C:\Francisco\Perfil Epidemiologico\Perfil Epidemiologico\CrystalReport3.rpt");
            //   Cryrpt.Load(@"C:\Users\Francisco Acevedo\OneDrive\Documents\Visual Studio 2015\Projects\WindowsFormsApplication7\WindowsFormsApplication7\Reporte\CrystalReport3.rpt");
            Cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = Cryrpt;

            Cryrpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            Cryrpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
            Cryrpt.PrintToPrinter(1, false, 0, 0);

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
