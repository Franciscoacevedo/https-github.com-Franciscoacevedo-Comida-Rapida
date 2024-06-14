using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Perfil_Epidemiologico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /*   private void button1_Click_1(object sender, EventArgs e)
           {
               SqlConnection conn = new SqlConnection("Data Source=.\\FRANCISCO;DataBase=francisquito;Integrated Security=SSPI");

               conn.Open();
               SqlCommand cmd = conn.CreateCommand();
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "insert into PERFILEPIDEMIOLOGICO(SUBSIDIADO,) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text
                   + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + label15.Text + "','" + checkBox7.Text + "','" + checkBox6.Text + "','" + checkBox5.Text + "')";
               cmd.ExecuteNonQuery();
               conn.Close();


               ////  this.Hide();
               ////  Siguientes cm =new Siguientes();
               //  cm.Show();


               string nombre; string segundon; string primern; string segundoa; string region; string provincia; string municipio;
               string direccion; string casa; string barrio; string tele1; string tele2; string SUBSIDIADO; string CONTRIBUTIVO; string PENSIONADO;
              string VOLUNTARIO;

               nombre = textBox1.Text; municipio = textBox7.Text; textBox7.Text = municipio;
               textBox1.Text = nombre;

               segundon = textBox2.Text; CONTRIBUTIVO = checkBox7.Text; checkBox7.Text = CONTRIBUTIVO;
               textBox2.Text = segundon;

               primern = textBox3.Text; PENSIONADO = checkBox6.Text; checkBox6.Text = PENSIONADO;
               textBox3.Text = primern; VOLUNTARIO = checkBox5.Text; checkBox5.Text = VOLUNTARIO;

               segundoa = textBox4.Text;
               textBox4.Text = segundoa;

               region = textBox5.Text;
               textBox5.Text = region;

               provincia = textBox6.Text;
               textBox6.Text = provincia;

               direccion = textBox8.Text;
               textBox8.Text = direccion;

               casa = textBox9.Text;
               textBox9.Text = casa;

               barrio = textBox10.Text;
               textBox10.Text = barrio;

               tele1 = textBox11.Text;
               textBox11.Text = tele1;

               tele2 = textBox12.Text;
               textBox12.Text = tele2;


                   SUBSIDIADO = checkBox8.Text;
                  checkBox8.Text = SUBSIDIADO;

               if (checkBox8.Checked == true)
                   SUBSIDIADO = SUBSIDIADO +label15.Text;
            else 
            if (checkBox8.Checked == false)

               if (checkBox7.Checked == true)
                   CONTRIBUTIVO= CONTRIBUTIVO + label16.Text;


               if (checkBox6.Checked == true)
                   PENSIONADO = PENSIONADO + label16.Text;
               if (checkBox5.Checked == true)
                   VOLUNTARIO = VOLUNTARIO + label18.Text;



                   MessageBox.Show("SE GUARDA CORRECTAMENTE");


               dataGridView1.Rows.Add(SUBSIDIADO, CONTRIBUTIVO, PENSIONADO, VOLUNTARIO);

           }
           */
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            {
                {

                    //SqlConnection conn = new SqlConnection("Data Source=.\\FRANCISCO;DataBase=Francisquito;Integrated Security=SSPI");
                    {
                        //  conn.Open();
                        // string sql = "insert into PERFILEPIDEMIOLOGICO (subsidiado) values (@subsidiado)";
                        //SqlCommand cmd = new SqlCommand(sql, conn);
                        //cmd.Parameters.AddWithValue("@subsidiado", checkBox1.ThreeState);
                        //cmd.ExecuteNonQuery();
                        //cmd.CommandText = "insert into facevedo values ('" + checkBox1.Text + "')";

                        //
                        //                       conn.Close();

                        {
                            //                          if (!checkBox1.ThreeState)
                            {
                                //                            checkBox1.ThreeState = true;


                            }


                            //                      else
                            {
                                //                        checkBox1.ThreeState = false;

                            }
                            ////SqlConnection conn = new SqlConnection("Data Source=.\\FRANCISCO;DataBase=Francisquito;Integrated Security=SSPI");

                            //////conn.Open();
                            //////SqlCommand cmd = conn.CreateCommand();
                            //////cmd.CommandType = CommandType.Text;
                            //////cmd.CommandText = "insert into PERFILEPIDEMIOLOGICO values ('" + checkBox8.ThreeState + "')";
                            //////cmd.ExecuteNonQuery();
                            //////conn.Close();

                            //////SqlConnection conn = new SqlConnection("Data Source=.\\FRANCISCO;DataBase=Francisquito;Integrated Security=SSPI");

                            ////conn.Open();
                            ////string sql = "insert into PERFILEPIDEMIOLOGICO (SUBSIDIADO) values (@SUBSIDIADO)";
                            ////SqlCommand cmd = new SqlCommand(sql, conn);
                            ////cmd.Parameters.AddWithValue("@SUBSIDIADO", checkBox8.ThreeState);
                            ////cmd.ExecuteNonQuery();
                            ////conn.Close();


                            ////{
                            ////    if (!checkBox8.ThreeState)
                            ////    {
                            ////        checkBox8.ThreeState = true;


                            ////    }


                            ////    else
                            ////    {
                            ////        checkBox8.ThreeState = false;

                            ////    }


                            this.Hide();
                            //                Siguientes cm = new Siguientes();
                            //                  cm.Show();


                            //string nombre; string segundon; string primern; string segundoa; string region; string provincia; string municipio;
                            //string direccion; string casa; string barrio; string tele1; string tele2; string SUBSIDIADO; string CONTRIBUTIVO; string PENSIONADO;
                            //string VOLUNTARIO;

                            //nombre = textBox1.Text;
                            //textBox1.Text = nombre;

                            //segundon = textBox2.Text;
                            //textBox2.Text = segundon;

                            //primern = textBox3.Text;
                            //textBox3.Text = primern;
                            //segundoa = textBox4.Text;
                            //textBox4.Text = segundoa;

                            //region = textBox5.Text;
                            //textBox5.Text = region;

                            //provincia = textBox6.Text;
                            //textBox6.Text = provincia;

                            //direccion = textBox8.Text;
                            //textBox8.Text = direccion;

                            //casa = textBox9.Text;
                            //textBox9.Text = casa;

                            //barrio = textBox10.Text;
                            //textBox10.Text = barrio;

                            //tele1 = textBox11.Text;
                            //textBox11.Text = tele1;

                            //tele2 = textBox12.Text;
                            //textBox12.Text = tele2;


                            //if (!checkBox8.ThreeState)
                            //{
                            //    checkBox8.ThreeState = true;


                            //}


                            //else
                            //{
                            //    checkBox8.ThreeState = false;

                            //}



                            //     MessageBox.Show("SE GUARDA CORRECTAMENTE");


                            /// dataGridView1.Rows.Add(SUBSIDIADO, CONTRIBUTIVO, PENSIONADO, VOLUNTARIO);
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                {
                    SqlConnection conn = new SqlConnection("Data Source=.\\FRANCISCO;DataBase=francisquito;Integrated Security=SSPI");

                    conn.Open();
                    string sql = "insert into facevedo (checkBox) values (@checkbox)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@checkbox", checkBox1.ThreeState);
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "insert into facevedo values ('" + checkBox1.Text + "')";
                    conn.Close();
                    {
                        if (!checkBox1.ThreeState)
                        {
                            checkBox1.ThreeState = true;

                        }


                        else
                        {
                            checkBox1.ThreeState = false;


                            MessageBox.Show("PASO");
                        }
                    }
                }
            }
        }
    }
}
