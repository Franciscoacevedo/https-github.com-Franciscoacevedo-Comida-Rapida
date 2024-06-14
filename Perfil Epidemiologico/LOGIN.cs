using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Perfil_Epidemiologico
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Metodos fa = new Metodos();
        validaciones val = new validaciones();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                //SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog= Francisco; Integrated Security=True");

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4VHVDPH; Initial Catalog= Francisco; Integrated Security=True");

                SqlDataAdapter sda = new SqlDataAdapter("select Count (*) from usuario where nombre='" + textBox1.Text + "' and contraseÑa ='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                //Data Source = DESKTOP - 3BLPQ8M; Initial Catalog = Francisco; Integrated Security = True




                //  string francisco = " CONTRASEñA O NOMBRE SON INCORRECTO";
                {
                    DateTime fecha = DateTime.Today;

                    if (dt.Rows[0][0].ToString() == "1")
                        MessageBox.Show(val.usuariocorecto);

                    else
                    {
                        if (dt.Rows[0][0].ToString() == "0")
                            MessageBox.Show(val.usuarionocorecto);
                        return;
                    }



                    Hide();

                    Listados SS = new Listados();
                    SS.Show();

                }

            }
            catch (FormatException x)
            {
                MessageBox.Show(val.Nombre + x);
            }

            catch (OverflowException xx)
            {

                MessageBox.Show(val.apellido + xx);
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



