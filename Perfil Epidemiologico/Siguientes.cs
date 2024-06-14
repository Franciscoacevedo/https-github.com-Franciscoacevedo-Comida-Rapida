using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perfil_Epidemiologico
{
    public partial class Siguientes : Form
    {
        public Siguientes()
        {
            InitializeComponent();
        }

        Metodos fa = new Metodos();
        validaciones val = new validaciones();
        //qlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;DataBase=Francisco;Integrated Security=SSPI");
        private void Siguientes_Load(object sender, EventArgs e)
        {

            {



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog= Francisco; Integrated Security=True");
            //Data Source=.\\SQLEXPRESS;DataBase=Francisco;Integrated Security=SSPI

            try

            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into PERFILEPIDEMIOLOGICO1 values  ('" + comboBox7.Text + "','" + comboBox8.Text + "','" + comboBox9.Text
                    + "','" + comboBox10.Text + "','" + comboBox12.Text + "','" + comboBox13.Text + "','" + comboBox14.Text + "','" + comboBox1.Text + "','"
                    + comboBox2.Text +
               "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + checkBox8.Checked + "','" + checkBox7.Checked + "','"
               + checkBox6.Checked + "','" + checkBox5.Checked + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "','" + checkBox3.Checked + "','" + checkBox4.Checked + "','" +
                checkBox9.Checked + "','" + checkBox10.Checked + "','"
                + checkBox11.Checked + "','" + checkBox12.Checked + "','" + checkBox13.Checked +
                  "','" + checkBox14.Checked + "','" + checkBox15.Checked + "','" + checkBox16.Checked + "','" + checkBox21.Checked + "','" + checkBox20.Checked + "','" + checkBox19.Checked +
          "','" + checkBox18.Checked + "','" + checkBox17.Checked + "','" + checkBox26.Checked + "','" + checkBox25.Checked + "','" + checkBox24.Checked + "','" + checkBox23.Checked + "','"
                     + checkBox22.Checked + "','" + checkBox31.Checked + "','" + checkBox30.Checked + "','" + checkBox29.Checked + "','" + checkBox28.Checked + "','" + checkBox27.Checked + "')";
                cmd.ExecuteNonQuery();
                conn.Close();



                fa.embarazo = comboBox7.Text; fa.chequeomedicoM = comboBox1.Text;


                fa.chequeomedicoDuranteEmbarazo = comboBox2.Text;


                fa.vaginal = comboBox7.Text;


                fa.cesarea = comboBox8.Text;


                fa.multiples = comboBox9.Text;


                fa.embarazoM = comboBox12.Text;


                fa.diabetesG = comboBox13.Text;


                fa.anticonceptivo = comboBox14.Text;


                fa.chequeomedicoE = comboBox3.Text;


                fa.chequeomedicoV = comboBox4.Text;


                fa.chequeomedicoC = comboBox5.Text;


                fa.chequeomedicodiab = comboBox6.Text;


                //    PerfilEpidemiologico ss = new PerfilEpidemiologico();
                ///  ss.Show();

                if (checkBox8.Checked == true)
                    if (checkBox7.Checked == true)
                        if (checkBox6.Checked == true)
                            if (checkBox5.Checked == true)
                                if (checkBox1.Checked == true)
                                    if (checkBox2.Checked == true)
                                        if (checkBox3.Checked == true)
                                            if (checkBox4.Checked == true)
                                                if (checkBox9.Checked == true)
                                                    if (checkBox10.Checked == true)
                                                        if (checkBox11.Checked == true)
                                                            if (checkBox12.Checked == true)
                                                                if (checkBox13.Checked == true)
                                                                    if (checkBox14.Checked == true)
                                                                        if (checkBox15.Checked == true)
                                                                            if (checkBox16.Checked == true)
                                                                                if (checkBox21.Checked == true)
                                                                                    if (checkBox20.Checked == true)
                                                                                        if (checkBox19.Checked == true)
                                                                                            if (checkBox18.Checked == true)
                                                                                                if (checkBox17.Checked == true)
                                                                                                    if (checkBox26.Checked == true)
                                                                                                        if (checkBox25.Checked == true)
                                                                                                            if (checkBox24.Checked == true)
                                                                                                                if (checkBox23.Checked == true)
                                                                                                                    if (checkBox22.Checked == true)
                                                                                                                        if (checkBox31.Checked == true)
                                                                                                                            if (checkBox30.Checked == true)
                                                                                                                                if (checkBox29.Checked == true)
                                                                                                                                    if (checkBox28.Checked == true)
                                                                                                                                        if (checkBox27.Checked == true)

                                                                                                                                            checkBox1.ThreeState = true;

                Hide();



                MessageBox.Show(val.INF);
                Hide();
                Listados m = new Listados();
                m.Show();

            }
            catch
            {
                MessageBox.Show(" Ocurre un error");
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}








