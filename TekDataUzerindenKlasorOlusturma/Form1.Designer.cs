
namespace TekDataUzerindenKlasorOlusturma
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
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.btnkisigetir = new System.Windows.Forms.Button();
            this.btnklasorolustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 16;
            this.lstKisiler.Location = new System.Drawing.Point(70, 55);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(162, 212);
            this.lstKisiler.TabIndex = 0;
            // 
            // btnkisigetir
            // 
            this.btnkisigetir.Location = new System.Drawing.Point(70, 294);
            this.btnkisigetir.Name = "btnkisigetir";
            this.btnkisigetir.Size = new System.Drawing.Size(106, 27);
            this.btnkisigetir.TabIndex = 1;
            this.btnkisigetir.Text = "Kişi Getir";
            this.btnkisigetir.UseVisualStyleBackColor = true;
            this.btnkisigetir.Click += new System.EventHandler(this.btnkisigetir_Click);
            // 
            // btnklasorolustur
            // 
            this.btnklasorolustur.Location = new System.Drawing.Point(70, 338);
            this.btnklasorolustur.Name = "btnklasorolustur";
            this.btnklasorolustur.Size = new System.Drawing.Size(106, 28);
            this.btnklasorolustur.TabIndex = 2;
            this.btnklasorolustur.Text = "Klasör Oluştur";
            this.btnklasorolustur.UseVisualStyleBackColor = true;
            this.btnklasorolustur.Click += new System.EventHandler(this.btnklasorolustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 414);
            this.Controls.Add(this.btnklasorolustur);
            this.Controls.Add(this.btnkisigetir);
            this.Controls.Add(this.lstKisiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.Button btnkisigetir;
        private System.Windows.Forms.Button btnklasorolustur;
    }
}

