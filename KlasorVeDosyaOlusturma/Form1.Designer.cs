
namespace KlasorVeDosyaOlusturma
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
            this.btnklasor = new System.Windows.Forms.Button();
            this.btndosya = new System.Windows.Forms.Button();
            this.btnKlasorTasi = new System.Windows.Forms.Button();
            this.btnDosyaKopyala = new System.Windows.Forms.Button();
            this.btnDosyaSil = new System.Windows.Forms.Button();
            this.btnDosyaOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnklasor
            // 
            this.btnklasor.Location = new System.Drawing.Point(203, 25);
            this.btnklasor.Name = "btnklasor";
            this.btnklasor.Size = new System.Drawing.Size(186, 39);
            this.btnklasor.TabIndex = 0;
            this.btnklasor.Text = "KLASÖR OLUŞTUR";
            this.btnklasor.UseVisualStyleBackColor = true;
            this.btnklasor.Click += new System.EventHandler(this.btnklasor_Click);
            // 
            // btndosya
            // 
            this.btndosya.Location = new System.Drawing.Point(203, 116);
            this.btndosya.Name = "btndosya";
            this.btndosya.Size = new System.Drawing.Size(186, 43);
            this.btndosya.TabIndex = 1;
            this.btndosya.Text = "DOSYA OLUŞTUR";
            this.btndosya.UseVisualStyleBackColor = true;
            this.btndosya.Click += new System.EventHandler(this.btndosya_Click);
            // 
            // btnKlasorTasi
            // 
            this.btnKlasorTasi.Location = new System.Drawing.Point(203, 70);
            this.btnKlasorTasi.Name = "btnKlasorTasi";
            this.btnKlasorTasi.Size = new System.Drawing.Size(186, 40);
            this.btnKlasorTasi.TabIndex = 2;
            this.btnKlasorTasi.Text = "KLASÖR TAŞI";
            this.btnKlasorTasi.UseVisualStyleBackColor = true;
            this.btnKlasorTasi.Click += new System.EventHandler(this.btnKlasorTasi_Click);
            // 
            // btnDosyaKopyala
            // 
            this.btnDosyaKopyala.Location = new System.Drawing.Point(203, 165);
            this.btnDosyaKopyala.Name = "btnDosyaKopyala";
            this.btnDosyaKopyala.Size = new System.Drawing.Size(186, 37);
            this.btnDosyaKopyala.TabIndex = 3;
            this.btnDosyaKopyala.Text = "DOSYA KOPYALA";
            this.btnDosyaKopyala.UseVisualStyleBackColor = true;
            this.btnDosyaKopyala.Click += new System.EventHandler(this.btnDosyaKopyala_Click);
            // 
            // btnDosyaSil
            // 
            this.btnDosyaSil.Location = new System.Drawing.Point(203, 208);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(186, 38);
            this.btnDosyaSil.TabIndex = 4;
            this.btnDosyaSil.Text = "DOSYA SİL";
            this.btnDosyaSil.UseVisualStyleBackColor = true;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // btnDosyaOku
            // 
            this.btnDosyaOku.Location = new System.Drawing.Point(203, 253);
            this.btnDosyaOku.Name = "btnDosyaOku";
            this.btnDosyaOku.Size = new System.Drawing.Size(186, 39);
            this.btnDosyaOku.TabIndex = 5;
            this.btnDosyaOku.Text = "DOSYA OKU";
            this.btnDosyaOku.UseVisualStyleBackColor = true;
            this.btnDosyaOku.Click += new System.EventHandler(this.btnDosyaOku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 323);
            this.Controls.Add(this.btnDosyaOku);
            this.Controls.Add(this.btnDosyaSil);
            this.Controls.Add(this.btnDosyaKopyala);
            this.Controls.Add(this.btnKlasorTasi);
            this.Controls.Add(this.btndosya);
            this.Controls.Add(this.btnklasor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnklasor;
        private System.Windows.Forms.Button btndosya;
        private System.Windows.Forms.Button btnKlasorTasi;
        private System.Windows.Forms.Button btnDosyaKopyala;
        private System.Windows.Forms.Button btnDosyaSil;
        private System.Windows.Forms.Button btnDosyaOku;
    }
}

