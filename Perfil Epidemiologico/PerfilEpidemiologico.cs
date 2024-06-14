using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perfil_Epidemiologico
{
    public partial class PerfilEpidemiologico : Form
    {
        public PerfilEpidemiologico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                {
                    Metodos fa = new Metodos();
                    validaciones val = new validaciones();

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3BLPQ8M; Initial Catalog= Francisco; Integrated Security=True");
                    {
                        //Data Source=.\\SQLEXPRESS;DataBase=Francisco;Integrated Security=SSPI"
                        Siguientes CC = new Siguientes();
                        CC.Show();



                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into PERFILEPIDEMIOLOGICO values ('" + textBox1.Text + "','" + textBox2.Text + "','"
                            + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" +
                            textBox7.Text + "','" + textBox8.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox1.Text + "','" + textBox11.Text + "','"
                            + textBox12.Text + "','" + checkBox8.Checked + "','" + checkBox7.Checked + "','" + checkBox6.Checked + "','" + checkBox5.Checked
                             + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "','" + checkBox3.Checked + "','" + checkBox9.Checked + "','" + checkBox4.Checked + "','" +
                             checkBox10.Checked + "','" + checkBox11.Checked + "','" + checkBox12.Checked + "','" + checkBox13.Checked
                        + "','" + checkBox14.Checked + "','" + checkBox15.Checked + "','" + checkBox16.Checked
                        + "','" + checkBox17.Checked + "','" + checkBox18.Checked + "','" + checkBox19.Checked + "','" + checkBox29.Checked + "','" +
                        checkBox20.Checked + "','" + checkBox21.Checked + "','" + checkBox28.Checked + "','" + checkBox27.Checked + "','" +
                        checkBox26.Checked + "','" + checkBox25.Checked
                        + "','" + checkBox24.Checked + "','" + checkBox23.Checked + "','" + checkBox22.Checked + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        // cmd.CommandText = "insert into facevedo values ('" + checkBox1.Text + "')";
                        //  cmd.CommandText = "INSERT INTO facevedo ( checkbox) VALUES (@checkBox1.Text";
                        // cmd.Parameters.AddWithValue("@checkbox", checkBox1.Text);


                        // DOBLE TAB SALE EL MENSAJE ENTERO
                        // MessageBox.Show("Test");

                        Hide();
                        if (checkBox8.Checked == true)
                            if (checkBox7.Checked == true)
                                if (checkBox6.Checked == true)
                                    if (checkBox5.Checked == true)
                                        if (checkBox1.Checked == true)
                                            if (checkBox2.Checked == true)
                                                if (checkBox3.Checked == true)
                                                    if (checkBox9.Checked == true)
                                                        if (checkBox4.Checked == true)
                                                            if (checkBox10.Checked == true)
                                                                if (checkBox11.Checked == true)
                                                                    if (checkBox12.Checked == true)
                                                                        if (checkBox13.Checked == true)
                                                                            if (checkBox14.Checked == true)
                                                                                if (checkBox15.Checked == true)
                                                                                    if (checkBox16.Checked == true)
                                                                                        if (checkBox17.Checked == true)
                                                                                            if (checkBox18.Checked == true)
                                                                                                if (checkBox19.Checked == true)
                                                                                                    if (checkBox20.Checked == true)
                                                                                                        if (checkBox21.Checked == true)
                                                                                                            if (checkBox28.Checked == true)
                                                                                                                if (checkBox27.Checked == true)
                                                                                                                    if (checkBox26.Checked == true)
                                                                                                                        if (checkBox25.Checked == true)
                                                                                                                            if (checkBox24.Checked == true)
                                                                                                                                if (checkBox23.Checked == true)
                                                                                                                                    if (checkBox22.Checked == true)
                                                                                                                                        checkBox1.ThreeState = true;

                    }









                    fa.nombre = textBox1.Text;


                    {

                        if (textBox1.Text.Trim() == "cambo no puede estar vacio")
                            return;
                        {

                            errorProvider1.SetError(textBox1, "");
                            textBox1.Focus();
                            return;

                        }


#pragma warning disable CS0162 // Unreachable code detected
                        fa.segundon = textBox2.Text;
#pragma warning restore CS0162 // Unreachable code detected


                        {

                            if (textBox2.Text == "")
                            {

                                errorProvider1.SetError(textBox2, val.segundonombre);
                                textBox2.Focus();
                                return;

                            }









                            fa.primern = textBox3.Text;

                            {

                                if (string.IsNullOrEmpty(textBox3.Text))
                                {

                                    MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL PRIMER APELLIDO");

                                    PerfilEpidemiologico pj = new PerfilEpidemiologico();

                                    return;

                                }
                                {
                                    fa.segundoa = textBox4.Text;

                                    {

                                        if (string.IsNullOrEmpty(textBox4.Text))
                                        {

                                            MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL SEGUNDO APELLIDO");

                                            return;

                                        }

                                        fa.region = textBox5.Text;

                                        {

                                            if (string.IsNullOrEmpty(textBox5.Text))
                                            {

                                                MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL REGION");

                                                return;

                                            }

                                            fa.provincia = textBox6.Text;

                                            {

                                                if (string.IsNullOrEmpty(textBox6.Text))
                                                {

                                                    MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL PROVINCIA");

                                                    return;


                                                }
                                                fa.direccion = textBox8.Text;


                                                {

                                                    if (string.IsNullOrEmpty(textBox8.Text))
                                                    {

                                                        MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL DIRECCION");

                                                        return;

                                                    }

                                                    fa.casa = maskedTextBox2.Text;

                                                    {

                                                        if (string.IsNullOrEmpty(maskedTextBox2.Text))
                                                        {

                                                            MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL CASA");

                                                            return;



                                                        }



                                                        fa.barrio = maskedTextBox1.Text;

                                                    }


                                                    {

                                                        if (string.IsNullOrEmpty(maskedTextBox1.Text))
                                                        {

                                                            MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL BARRIO");

                                                            return;

                                                        }
                                                        {
                                                            fa.tele1 = textBox11.Text;


                                                        }

                                                        {

                                                            if (string.IsNullOrEmpty(textBox11.Text))
                                                            {

                                                                MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL TELEFONO ");

                                                                return;

                                                            }
                                                            {
                                                                fa.tele2 = textBox12.Text;


                                                            }

                                                            {

                                                                if (string.IsNullOrEmpty(textBox12.Text))
                                                                {

                                                                    MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL TELEFONO2");

                                                                    return;

                                                                }

                                                                fa.municipio = textBox7.Text;

                                                            }

                                                            if (string.IsNullOrEmpty(textBox7.Text))
                                                            {

                                                                MessageBox.Show("DEBE DE COMPLETAR LA INFORMACION DEL MUNICIPIOS VARIOS");
                                                                return;

                                                            }



                                                            dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";


                                                        }

                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }

                    }
                }

                {

                }



            }

            catch (Exception)

            {
                MessageBox.Show("HAY UN ERROR ");
                return;
            }


            {



            }

        }

        private void PerfilEpidemiologico_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
















