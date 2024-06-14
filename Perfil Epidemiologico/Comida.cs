//using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Perfil_Epidemiologico
{

    public partial class Comida : Form
    {
        ReportDocument Cryrpt = new ReportDocument();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog=Francisco; Integrated Security=True");
#pragma warning disable CS0169 // The field 'Comida.sda' is never used
        SqlDataAdapter sda;
#pragma warning restore CS0169 // The field 'Comida.sda' is never used



        public Comida()
        {
            //       textBox1.KeyPress += textBox1_KeyPress;

            InitializeComponent();
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            Total.Enabled = false;
            Monto.KeyPress += Monto_KeyPress;
            Numero.KeyPress += Numero_KeyPress;
            //Button4.Click += BorrarButton_Click;





            //  button4.Click += button4_Click;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog= Francisco; Integrated Security=True");
        Metodos p = new Metodos();

        double sumaNumeros = 0;
        private void button1_Click(object sender, EventArgs e)
        {


            double numero = double.Parse(Numero.Text);

            // Sumar el número al total
            sumaNumeros += numero;

            // Mostrar la suma en el TextBox "textBox1"
            Total.Text = sumaNumeros.ToString();

            // Crear el ListViewItem con el valor del TextBox "Monto" como primer elemento
            // y el valor del TextBox "Numero" como segundo elemento
            ListViewItem lista = new ListViewItem(Monto.Text);
            lista.SubItems.Add(Numero.Text);

            lista.SubItems.Add(IDFACTURA.Text);


            ///ListViewItem lis= new ListViewItem(checkBox1.Text);
            //lis.SubItems.Add(checkBox1.Text);

            // Agregar el ListViewItem a la ListViewYOUYI
            listView1.Items.Add(lista);
            //  ListViewItem lista = new ListViewItem(Monto.Text);


            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Comida values ('" + Monto.Text + "','" + Numero.Text + "','" + Total.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + checkBox2.Checked + "','" + checkBox3.Checked + "','" + IDFACTURA.Text + "','" + checkBox1.Checked + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

            Total.Enabled = false;
        }


        private void validar()
        {

            if (Monto.Text != string.Empty && Numero.Text != string.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if (button2.Text != string.Empty)
            {

                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }


        }
        private void Comida_Load(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select isnull(max(cast(ID as int )),0)+1 from comida");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            IDFACTURA.Text = dt.Rows[0][0].ToString();
            conn.Close();




        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Monto.Clear();
            this.Numero.Clear();
            this.Total.Clear();
            this.textBox2.Clear();

            listView1.Items.Clear();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ///    DateTime FECHA = dateTimePicker1.Value;

            //     label7.Text = FECHA.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;


            }
            else
            {
                checkBox1.Enabled = true;
                //checkBox2.Enabled = true;
            }
        }

        private void IDFACTURA_TextChanged(object sender, EventArgs e)
        {
            IDFACTURA.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Total.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Form3 SS = new Form3();
            SS.Show();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog= Francisco; Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Exec FacturaConDetalle";
            ///   cmd.Parameters.AddWithValue("@ERROR", "");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            con.Close();



            SqlDataAdapter sda = new SqlDataAdapter("exec FacturaConDetalle ", con);
            DataSet dst = new DataSet();
            sda.Fill(dst, "FacturaConDetalle");
            //Cryrpt.Load(@"C:\Francisco\Perfil Epidemiologico\Perfil Epidemiologico\CrystalReport2.rpt");
            Cryrpt.Load(@"C:\Francisco\Perfil Epidemiologico\Perfil Epidemiologico\CrystalReport3.rpt");
            // Cryrpt.Load(@"C:\Users\Francisco Acevedo\OneDrive\Documents\Visual Studio 2015\Projects\WindowsFormsApplication7\WindowsFormsApplication7\Reporte\CrystalReport3.rpt");
            Cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = Cryrpt;

            //  Cryrpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            Cryrpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            Cryrpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
            Cryrpt.PrintToPrinter(1, false, 0, 0);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///  Cryrpt.PrintToPrinter(1, false, 0, 0);
            //   MessageBox.Show("Impresión completa.");


            Comida ABRIR = new Comida();
            ABRIR.Show();

            Form3 p = new Form3();
            this.Close();
        }
        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point);


        }


        private void EliminarRegistro_Click(object sender, EventArgs e)
        {
            // Verificar si hay elementos seleccionados en el ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Iterar a través de los elementos seleccionados en el ListView
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    // Obtener la descripción del ListViewItem
                    string descripcion = item.SubItems[0].Text; // Suponiendo que la descripción está en la primera columna del ListView

                    // Eliminar el elemento seleccionado del ListView
                    listView1.Items.Remove(item);

                    // Eliminar la fila correspondiente de la base de datos
                    EliminarRegistroBaseDatos(descripcion);
                }
                // listView1.Items.Clear();
                this.Total.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.");
            }

        }

        private void EliminarRegistroBaseDatos(string descripcion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog=Francisco; Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Comida WHERE descripcion = @descripcion";

                    // Asignar el parámetro para la consulta SQL
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);

                    // Ejecutar la consulta SQL para eliminar el registro
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro de la base de datos: " + ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(listView1.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 150, 125);
        }

        private void Monto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control (por ejemplo, retroceso), se ignora la pulsación de tecla
                e.Handled = true;
            }
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un dígito ni una tecla de control (por ejemplo, retroceso), se ignora la pulsación de tecla
                e.Handled = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    internal class crystalReportViewer1
    {
        public static ReportDocument ReportSource { get; internal set; }

        internal static void RefreshReport()
        {


        }
    }


}








