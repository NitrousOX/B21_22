using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B21_22
{
    public partial class Radna_mesta : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B21_22;Integrated Security=True");
       // SqlCommand Provera = new SqlCommand("select * from Radno_Mesto where RadnoMestoID = @p1",conn);
        public Radna_mesta()
        {
            SqlCommand Ucitavanje = new SqlCommand("select RadnoMestoID from Radno_Mesto order by RadnoMestoID", conn);
            InitializeComponent();
            radioButton1.Checked = true;

            conn.Open();
            SqlDataReader rd = Ucitavanje.ExecuteReader();
            while(rd.Read())
            {
                comboBox1.Items.Add(rd.GetInt32(0).ToString());
            }
            conn.Close();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;

            comboBox1.Enabled = true;
            comboBox1.SelectedIndex = 0;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox1.Text = null;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand Unos = new SqlCommand("insert into Radno_Mesto values(@p1,@p2,@p3,@p4,@p5)", conn);
            SqlCommand Brisanje = new SqlCommand("delete from Radno_Mesto where RadnoMestoID = @p1", conn);
            SqlCommand Izmena = new SqlCommand("update Radno_Mesto set  Naziv = @p2, Opis =@p3, PocetnaPLata = @p4, NajvisaPlata =@p5 where RadnoMestoID = @p1 ", conn);
            SqlCommand Rednibr = new SqlCommand("select MAX(RadnoMestoID) from Radno_Mesto", conn);

            try
            {
                if(radioButton1.Checked)
                {
                    int ID = 0;
                    if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text))
                        throw new Exception("Morate uneti sve parametere");
                    for (int i = 0; i < textBox3.Text.Length; i++)
                        if (!Char.IsDigit(textBox3.Text[i]))
                        {
                            textBox3.Text = null;
                            throw new Exception("Mora biti broj plata");
                        }
                    for (int i = 0; i < textBox4.Text.Length; i++)
                        if (!Char.IsDigit(textBox4.Text[i]))
                        {
                            textBox4.Text = null;
                            throw new Exception("Mora biti broj plata");
                        }

                    conn.Open();
                    ID = (Int32)Rednibr.ExecuteScalar() +1;
                    conn.Close();
                    comboBox1.Text = ID.ToString();

                    Unos.Parameters.AddWithValue("@p1",ID);
                    Unos.Parameters.AddWithValue("@p2",textBox1.Text);
                    Unos.Parameters.AddWithValue("@p3",textBox2.Text);
                    Unos.Parameters.AddWithValue("@p4",Convert.ToInt32(textBox3.Text));
                    Unos.Parameters.AddWithValue("@p5", Convert.ToInt32(textBox4.Text));

                    conn.Open();
                    Unos.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste upisali");
                    ID++;
                    conn.Close();


                }
                else if(radioButton2.Checked)
                {
                    Brisanje.Parameters.AddWithValue("@p1",comboBox1.Text);
                    conn.Open();
                    Brisanje.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste obrisali");
                    conn.Close();

                    comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
                }
                else
                {
                    if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text))
                        throw new Exception("Morate uneti sve parametere");
                    for (int i = 0; i < textBox3.Text.Length; i++)
                        if (!Char.IsDigit(textBox3.Text[i]))
                        {
                            textBox3.Text = null;
                            throw new Exception("Mora biti broj plata");
                        }
                    for (int i = 0; i < textBox4.Text.Length; i++)
                        if (!Char.IsDigit(textBox4.Text[i]))
                        {
                            textBox4.Text = null;
                            throw new Exception("Mora biti broj plata");
                        }

                    Izmena.Parameters.AddWithValue("@p1", comboBox1.Text);
                    Izmena.Parameters.AddWithValue("@p2", textBox1.Text);
                    Izmena.Parameters.AddWithValue("@p3", textBox2.Text);
                    Izmena.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox3.Text));
                    Izmena.Parameters.AddWithValue("@p5", Convert.ToInt32(textBox4.Text));

                    conn.Open();
                    Izmena.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste izmenili");
                    conn.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand Provera = new SqlCommand("select * from Radno_Mesto where RadnoMestoID = @p1", conn);
            try
            {
                Provera.Parameters.AddWithValue("@p1", Convert.ToInt32(comboBox1.Text));
                conn.Open();
                SqlDataReader rd = Provera.ExecuteReader();
                rd.Read();
                textBox1.Text = rd.GetString(1);
                textBox2.Text = rd.GetString(2);
                textBox3.Text = rd.GetInt32(3).ToString();
                textBox4.Text = rd.GetInt32(4).ToString();
                conn.Close();
            }
            catch (Exception ex) { };
        }
    }
}
