namespace Literature_Search
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fbr_Dosya_Tarayici_Diyalog = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_Secilen_Dosya_Yolu = new System.Windows.Forms.TextBox();
            this.btn_Klasor_Sec = new System.Windows.Forms.Button();
            this.lb_Dosyalar = new System.Windows.Forms.ListBox();
            this.chb_pdf = new System.Windows.Forms.CheckBox();
            this.chb_txt = new System.Windows.Forms.CheckBox();
            this.chb_doc = new System.Windows.Forms.CheckBox();
            this.btn_Excele_Aktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Secilen_Dosya_Yolu
            // 
            this.tb_Secilen_Dosya_Yolu.Location = new System.Drawing.Point(131, 15);
            this.tb_Secilen_Dosya_Yolu.Name = "tb_Secilen_Dosya_Yolu";
            this.tb_Secilen_Dosya_Yolu.Size = new System.Drawing.Size(457, 20);
            this.tb_Secilen_Dosya_Yolu.TabIndex = 0;
            // 
            // btn_Klasor_Sec
            // 
            this.btn_Klasor_Sec.Location = new System.Drawing.Point(12, 12);
            this.btn_Klasor_Sec.Name = "btn_Klasor_Sec";
            this.btn_Klasor_Sec.Size = new System.Drawing.Size(113, 24);
            this.btn_Klasor_Sec.TabIndex = 1;
            this.btn_Klasor_Sec.Text = "Klasör Seç";
            this.btn_Klasor_Sec.UseVisualStyleBackColor = true;
            this.btn_Klasor_Sec.Click += new System.EventHandler(this.btn_Klasor_Sec_Click);
            // 
            // lb_Dosyalar
            // 
            this.lb_Dosyalar.FormattingEnabled = true;
            this.lb_Dosyalar.Location = new System.Drawing.Point(13, 91);
            this.lb_Dosyalar.Name = "lb_Dosyalar";
            this.lb_Dosyalar.ScrollAlwaysVisible = true;
            this.lb_Dosyalar.Size = new System.Drawing.Size(575, 225);
            this.lb_Dosyalar.TabIndex = 2;
            // 
            // chb_pdf
            // 
            this.chb_pdf.AutoSize = true;
            this.chb_pdf.Location = new System.Drawing.Point(13, 68);
            this.chb_pdf.Name = "chb_pdf";
            this.chb_pdf.Size = new System.Drawing.Size(44, 17);
            this.chb_pdf.TabIndex = 3;
            this.chb_pdf.Text = ".pdf";
            this.chb_pdf.UseVisualStyleBackColor = true;
            // 
            // chb_txt
            // 
            this.chb_txt.AutoSize = true;
            this.chb_txt.Location = new System.Drawing.Point(63, 68);
            this.chb_txt.Name = "chb_txt";
            this.chb_txt.Size = new System.Drawing.Size(40, 17);
            this.chb_txt.TabIndex = 4;
            this.chb_txt.Text = ".txt";
            this.chb_txt.UseVisualStyleBackColor = true;
            // 
            // chb_doc
            // 
            this.chb_doc.AutoSize = true;
            this.chb_doc.Location = new System.Drawing.Point(109, 68);
            this.chb_doc.Name = "chb_doc";
            this.chb_doc.Size = new System.Drawing.Size(78, 17);
            this.chb_doc.TabIndex = 5;
            this.chb_doc.Text = ".doc/.docx";
            this.chb_doc.UseVisualStyleBackColor = true;
            // 
            // btn_Excele_Aktar
            // 
            this.btn_Excele_Aktar.Location = new System.Drawing.Point(461, 322);
            this.btn_Excele_Aktar.Name = "btn_Excele_Aktar";
            this.btn_Excele_Aktar.Size = new System.Drawing.Size(123, 23);
            this.btn_Excele_Aktar.TabIndex = 6;
            this.btn_Excele_Aktar.Text = "Excel\'e Aktar";
            this.btn_Excele_Aktar.UseVisualStyleBackColor = true;
            this.btn_Excele_Aktar.Click += new System.EventHandler(this.btn_Excele_Aktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 352);
            this.Controls.Add(this.btn_Excele_Aktar);
            this.Controls.Add(this.chb_doc);
            this.Controls.Add(this.chb_txt);
            this.Controls.Add(this.chb_pdf);
            this.Controls.Add(this.lb_Dosyalar);
            this.Controls.Add(this.btn_Klasor_Sec);
            this.Controls.Add(this.tb_Secilen_Dosya_Yolu);
            this.Name = "Form1";
            this.Text = "Literature Search List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbr_Dosya_Tarayici_Diyalog;
        private System.Windows.Forms.TextBox tb_Secilen_Dosya_Yolu;
        private System.Windows.Forms.Button btn_Klasor_Sec;
        private System.Windows.Forms.ListBox lb_Dosyalar;
        private System.Windows.Forms.CheckBox chb_pdf;
        private System.Windows.Forms.CheckBox chb_txt;
        private System.Windows.Forms.CheckBox chb_doc;
        private System.Windows.Forms.Button btn_Excele_Aktar;
    }
}

