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
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MERT;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void FrmOyGiris_Load(object sender, EventArgs e)
        {
        
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand insertCommand = new SqlCommand("insert into TBLILCE(ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", connection);
            insertCommand.Parameters.AddWithValue("@p1", txtDistrict.Text);
            insertCommand.Parameters.AddWithValue("@p2", txtPartyA.Text);
            insertCommand.Parameters.AddWithValue("@p3", txtPartyB.Text);
            insertCommand.Parameters.AddWithValue("@p4", txtPartyC.Text);
            insertCommand.Parameters.AddWithValue("@p5", txtPartyD.Text);
            insertCommand.Parameters.AddWithValue("@P6", txtPartyE.Text);
            insertCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Oy Girişi Yapıldı !");
            //FORMDAKİ TEXTBOXLARI DÖNÜP OY GİRİŞİ YAPILDIKTAN SONRA İÇERİĞİNİN SİLİNME İŞLEMİ.
            foreach (var textbox in this.Controls)
            {
                if(textbox is TextBox) 
                {
                    ((TextBox)textbox).Text = String.Empty;
                }
            }
        }

        private void graphic_Click(object sender, EventArgs e)
        {
            FrmGrafikler grafikler = new FrmGrafikler();
            grafikler.Show();
             
        }
    }
}
