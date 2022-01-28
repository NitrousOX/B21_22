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
    public partial class Projekti : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B21_22;Integrated Security=True");
        public Projekti()
        {
            int godina=0, mesec=0, dan=0;
            SqlCommand Ucitavanje = new SqlCommand("select ProjekatID,Naziv,DATEDIFF(YEAR,DatumPocetka,GETDATE()) as Godina from Projekat", conn);
            InitializeComponent();
            conn.Open();
            SqlDataReader rd = Ucitavanje.ExecuteReader();

            godina = DateTime.Now.Year;
            mesec = DateTime.Now.Month;
            dan = DateTime.Now.Day;

            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(rd.GetInt32(0).ToString());
                item.SubItems.Add(rd.GetString(1));
                item.SubItems.Add(rd.GetInt32(2).ToString());
              /*  item.SubItems.Add();
               item.SubItems.Add();*/
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand Unos = new SqlCommand("select Radnik.RadnikID, Radnik.Ime,Radnik.Prezime from Radnik join Angazman on Angazman.RadnikID = Radnik.RadnikID join Projekat on Projekat.ProjekatID = Angazman.ProjekatID where Radnik.RadnikID = @p1", conn);

            DataSet ds = new DataSet();
            DataRowView drv;
            

            Unos.Parameters.AddWithValue("@p1",);
            conn.Open();

            conn.Close();
        }
    }
}
