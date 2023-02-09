using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.IO;

namespace Tekstil
{
    public partial class KisiDetay : Form
    {
        public KisiDetay()
        {
            InitializeComponent();
        }
        public string isim;
        private void KisiDetay_Load(object sender, EventArgs e)
        {
            TxtAtkıFiyatı.Text =" 130";
            TxtTarih.Text = DateTime.Now.ToShortDateString();
            label1.Text = isim;
            veriler();
           
        }


       // OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\"+isim+".xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'");


        public void veriler()
        {
            
           string fileName = ""+isim+".xlsx";
            //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\"+fileName+";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';";
            //OleDbConnection baglanti = new OleDbConnection(connectionString);
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\" + isim + ".xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'");
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Sayfa1$] where [Kullanılabilirlik]=1", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int rowcount=dt.Rows.Count;
            Txtid.Text=(rowcount).ToString();
            dataGridView1.DataSource = dt;
        }
        public void kutucuklarbos()
        {
            TxtMalTuru.Text = "";
            TxtRenk.Text = "";
            TxtMetre.Text = "";
            TxtKacAtkı.Text = "";
            TxtAtkıFiyatı.Text = "";
            TxtFiyat.Text = "";
            RchAçıklama.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string fileName = "" + isim + ".xlsx";
            // string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\"+fileName+";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';";
            // OleDbConnection baglanti = new OleDbConnection(connectionString);

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\"+isim+".xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'");
            baglanti.Open();
            OleDbCommand komut=new OleDbCommand("insert into [Sayfa1$] ([id],[Mal Türü],[Renk],[Metre/Kg],[Kaç Atkı],[Atkı Fiyatı],[Fiyat],[Tarih],[Ek Açıklama],[Net Para],[Kullanılabilirlik]) values (@p1,@2,@3,@4,@5,@6,@7,@8,@p9,@10,@11)",baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Sayfa1$] where [Kullanılabilirlik]=1", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int rowcount = dt.Rows.Count;
            int x = rowcount+ 1;
            komut.Parameters.AddWithValue("@p1", x);
            komut.Parameters.AddWithValue("@p2", TxtMalTuru.Text);
            komut.Parameters.AddWithValue("@p3", TxtRenk.Text);
            komut.Parameters.AddWithValue("@p4", TxtMetre.Text);
            komut.Parameters.AddWithValue("@p5", TxtKacAtkı.Text);
            komut.Parameters.AddWithValue("@p6", TxtAtkıFiyatı.Text);
            komut.Parameters.AddWithValue("@p7", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@p8", TxtTarih.Text);
            komut.Parameters.AddWithValue("@p9", RchAçıklama.Text);
            float metre = float.Parse(TxtMetre.Text);
            float fiyat = float.Parse(TxtFiyat.Text);
            komut.Parameters.AddWithValue("@p10",(metre*fiyat).ToString());
            komut.Parameters.AddWithValue("@p11",1);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("EKLENDİ", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            kutucuklarbos();
            veriler();
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = (dataGridView1.Rows[secilen].Cells[0].Value).ToString();
            TxtMalTuru.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtRenk.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtMetre.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtKacAtkı.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtAtkıFiyatı.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtFiyat.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtTarih.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            RchAçıklama.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtNetPara.Text= dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            string fileName = "" + isim + ".xlsx";
            //  string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\kande\\OneDrive\\Masaüstü\\Tekstil\\veri tabanı\\" + fileName + ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';";
            //OleDbConnection baglanti = new OleDbConnection(connectionString);
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\" + isim + ".xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'");

            baglanti.Open();
            OleDbCommand komut=new OleDbCommand("update [Sayfa1$] set [Mal Türü]=@p1,[Renk]=@p2,[Metre/kg]=@p3,[Kaç Atkı]=@p4,[Atkı Fiyatı]=@p5,[Fiyat]=@p6,[Tarih]=@p7,[Ek Açıklama]=@p8,[Net Para]=@p9 where [id]=@10",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtMalTuru.Text);
            komut.Parameters.AddWithValue("@p2", TxtRenk.Text);
            komut.Parameters.AddWithValue("@p3", TxtMetre.Text);
            komut.Parameters.AddWithValue("@p4", TxtKacAtkı.Text);
            komut.Parameters.AddWithValue("@p5", TxtAtkıFiyatı.Text);
            komut.Parameters.AddWithValue("@p6", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@p7", TxtTarih.Text);
            komut.Parameters.AddWithValue("@p8", RchAçıklama.Text);
            float metre = float.Parse(TxtMetre.Text);
            float fiyat = float.Parse(TxtFiyat.Text);
            komut.Parameters.AddWithValue("@p9", (metre * fiyat).ToString());
            komut.Parameters.AddWithValue("@p10", Txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("bilgiler güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            kutucuklarbos();
            veriler();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string fileName = "" + isim + ".xlsx";
            // string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\osman.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';";
            //OleDbConnection baglanti = new OleDbConnection(connectionString);
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\" + isim + ".xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'");

            baglanti.Open();
            OleDbCommand komut=new OleDbCommand("update [Sayfa1$] set [Kullanılabilirlik]=@p1 where [id]=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", 0);
            komut.Parameters.AddWithValue("@p2",Txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("bilgi silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            kutucuklarbos();
            veriler();

        }

        
    }
}
