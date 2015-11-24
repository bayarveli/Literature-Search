using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace Literature_Search
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<string> s_dosyalar = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Klasor_Sec_Click(object sender, EventArgs e)
        {
            lb_Dosyalar.Items.Clear();
            s_dosyalar.Clear();

            DialogResult result = fbr_Dosya_Tarayici_Diyalog.ShowDialog();
            

            string dosya_uzantisi;
            string dosya_adi;

            if (result == DialogResult.OK)
            {
                if (chb_pdf.Checked == false &&
                    chb_txt.Checked == false &&
                    chb_doc.Checked == false)
                {
                    chb_pdf.Checked = true;
                    MessageBox.Show("Seçim yapılmadığı için, varsayılan dosya tipi .pdf olarak seçilmiştir.");
                }
                
                tb_Secilen_Dosya_Yolu.Text = fbr_Dosya_Tarayici_Diyalog.SelectedPath;

                string[] s_dosya_yollari = Directory.GetFiles(fbr_Dosya_Tarayici_Diyalog.SelectedPath);

                for (int i = 0; i < s_dosya_yollari.Length; i++)
                {
                    dosya_uzantisi = Path.GetExtension(s_dosya_yollari[i]);
                    dosya_adi = Path.GetFileName(s_dosya_yollari[i]);

                    if (chb_pdf.Checked == true && dosya_uzantisi == ".pdf")
                    {

                        s_dosyalar.Add(dosya_adi);
                    }
                    
                    if (chb_txt.Checked == true && dosya_uzantisi == ".txt")
                    {
                        s_dosyalar.Add(dosya_adi);
                    }
                    
                    if (chb_doc.Checked == true && (dosya_uzantisi == ".doc" || dosya_uzantisi == ".docx"))
                    {
                        s_dosyalar.Add(dosya_adi);
                    }       
                }
                
                lb_Dosyalar.Items.AddRange(s_dosyalar.ToArray());
            }
            else
            {
                MessageBox.Show("Seçilen dosya yolu geçersizdir.");
            }
        }

        private void btn_Excele_Aktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            for (int i = 0; i < lb_Dosyalar.Items.Count; i++)
            {
                xlWorkSheet.Cells[i + 2, 2] = lb_Dosyalar.Items[i].ToString();
                
                //Dosyaya hyperlink at
                xlWorkSheet.Hyperlinks.Add(xlWorkSheet.Cells[i + 2, 2], tb_Secilen_Dosya_Yolu.Text + "/" + lb_Dosyalar.Items[i].ToString());
            }
            
            string kaydedilecek_dosya_yolu = fbr_Dosya_Tarayici_Diyalog.SelectedPath + "/literatur.xls";

            xlWorkBook.SaveAs(kaydedilecek_dosya_yolu, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
