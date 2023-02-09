using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullanıcıAdı.Text == "admin" && TxtSifre.Text == "123")
            {
                KişiyeUlaş kişiyeUlaş = new KişiyeUlaş();
                this.Hide();
                kişiyeUlaş.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
        }
    }
}
