using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tekstil
{
    public partial class KişiyeUlaş : Form
    {
        public KişiyeUlaş()
        {
            InitializeComponent();
        }

        private void BtnKisiOlustur_Click(object sender, EventArgs e)
        {
            KisiOlustur kisiOlustur = new KisiOlustur();
            this.Hide();
            kisiOlustur.Show();
        }

        private void BtnKisiAra_Click(object sender, EventArgs e)
        {
            KisiDetay kisiDetay = new KisiDetay();
            kisiDetay.isim = CmbKisiler.Text;
            this.Hide(); 
            kisiDetay.Show();
        }

        private void KişiyeUlaş_Load(object sender, EventArgs e)
        {
            // Dosya dizini yolunu belirleyin
            string path = @"C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\";

            // Tüm .xlsx dosyalarını bulun
            string[] fileEntries = Directory.GetFiles(path, "*.xlsx"); 

            foreach (string fileName in fileEntries)
            {
                CmbKisiler.Items.Add(Path.GetFileNameWithoutExtension(fileName));
            }

        }
    }
}
