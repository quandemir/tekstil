namespace Tekstil
{
    partial class KişiyeUlaş
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
            this.CmbKisiler = new System.Windows.Forms.ComboBox();
            this.BtnKisiAra = new System.Windows.Forms.Button();
            this.BtnKisiOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbKisiler
            // 
            this.CmbKisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbKisiler.FormattingEnabled = true;
            this.CmbKisiler.Location = new System.Drawing.Point(48, 86);
            this.CmbKisiler.Name = "CmbKisiler";
            this.CmbKisiler.Size = new System.Drawing.Size(288, 44);
            this.CmbKisiler.TabIndex = 0;
            // 
            // BtnKisiAra
            // 
            this.BtnKisiAra.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKisiAra.Location = new System.Drawing.Point(78, 136);
            this.BtnKisiAra.Name = "BtnKisiAra";
            this.BtnKisiAra.Size = new System.Drawing.Size(239, 52);
            this.BtnKisiAra.TabIndex = 1;
            this.BtnKisiAra.Text = "Kişi Ara";
            this.BtnKisiAra.UseVisualStyleBackColor = true;
            this.BtnKisiAra.Click += new System.EventHandler(this.BtnKisiAra_Click);
            // 
            // BtnKisiOlustur
            // 
            this.BtnKisiOlustur.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKisiOlustur.Location = new System.Drawing.Point(78, 194);
            this.BtnKisiOlustur.Name = "BtnKisiOlustur";
            this.BtnKisiOlustur.Size = new System.Drawing.Size(239, 52);
            this.BtnKisiOlustur.TabIndex = 2;
            this.BtnKisiOlustur.Text = "Kişi Oluştur";
            this.BtnKisiOlustur.UseVisualStyleBackColor = true;
            this.BtnKisiOlustur.Click += new System.EventHandler(this.BtnKisiOlustur_Click);
            // 
            // KişiyeUlaş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 317);
            this.Controls.Add(this.BtnKisiOlustur);
            this.Controls.Add(this.BtnKisiAra);
            this.Controls.Add(this.CmbKisiler);
            this.Name = "KişiyeUlaş";
            this.Text = "KişiyeUlaş";
            this.Load += new System.EventHandler(this.KişiyeUlaş_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbKisiler;
        private System.Windows.Forms.Button BtnKisiAra;
        private System.Windows.Forms.Button BtnKisiOlustur;
    }
}