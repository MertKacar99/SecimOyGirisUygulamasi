using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabanli_Parti_Secim_Grafik_Istatistik_Projesi
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=MERT;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand select = new SqlCommand("select ILCEAD FROM TBLILCE",connection);
            SqlDataReader reader= select.ExecuteReader();
            while(reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            connection.Close();
            //Grafiğe Sonuçları getirme işlemi.
            connection.Open ();
            SqlCommand sum = new SqlCommand("select sum(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) FROM TBLILCE",connection);
            SqlDataReader readerParty = sum.ExecuteReader();
            while (readerParty.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ",readerParty[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", readerParty[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", readerParty[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", readerParty[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", readerParty[4]);
            }
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand selectForPorgress = new SqlCommand("select * from TBLILCE where ILCEAD=@Y1",connection);
            selectForPorgress.Parameters.AddWithValue("@Y1", comboBox1.Text);
            SqlDataReader sqlDataReader = selectForPorgress.ExecuteReader();
            while (sqlDataReader.Read())
            {
                progressBar1.Value = int.Parse(sqlDataReader[2].ToString());
                progressBar2.Value = int.Parse(sqlDataReader[3].ToString());
                progressBar3.Value = int.Parse(sqlDataReader[4].ToString());
                progressBar4.Value = int.Parse(sqlDataReader[5].ToString());
                progressBar5.Value = int.Parse(sqlDataReader[6].ToString());

                lblAParti.Text = sqlDataReader[2].ToString();
                lblBParti.Text = sqlDataReader[3].ToString();
                lblCPARTİ.Text = sqlDataReader[4].ToString();
                lblDParti.Text = sqlDataReader[5].ToString();
                lblEParti.Text = sqlDataReader[6].ToString();

            }
            connection.Close(); 
        }
    }
}
