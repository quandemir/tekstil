using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;

namespace Tekstil
{
    public partial class KisiOlustur : Form
    {
        public KisiOlustur()
        {
            InitializeComponent();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {

            Excel.Application excel = new Excel.Application();

            Workbook workbook = excel.Workbooks.Add();
            Worksheet worksheet = workbook.ActiveSheet;

            worksheet.Cells[1, "A"] = "id";
            worksheet.Cells[1, "B"] = "Mal Türü";
            worksheet.Cells[1, "C"] = "Renk";
            worksheet.Cells[1, "D"] = "Metre/Kg";
            worksheet.Cells[1, "E"] = "Kaç Atkı";
            worksheet.Cells[1, "F"] = "Atkı Fiyatı";
            worksheet.Cells[1, "G"] = "Fiyat";
            worksheet.Cells[1, "H"] = "Tarih";
            worksheet.Cells[1, "I"] = "Ek Açıklama";
            worksheet.Cells[1, "J"] = "Net Para";
            worksheet.Cells[1, "K"] = "Kullanılabilirlik";
            



           

            string filePath = @"C:\Users\kande\OneDrive\Masaüstü\Tekstil\veri tabanı\";
            string fileName = TxtOlusturAd.Text + ".xlsx";

            if (File.Exists(filePath + fileName))
            {
                MessageBox.Show("Bu dosya zaten mevcut");
            }
            else
            {
                workbook.SaveAs(filePath + fileName);
                MessageBox.Show("Dosya başarıyla oluşturuldu");

            }


            //workbook.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + TxtOlusturAd.Text + ".xlsx");
            excel.Quit();
        }

        private void KisiOlustur_Load(object sender, EventArgs e)
        {

        }
    }
}
