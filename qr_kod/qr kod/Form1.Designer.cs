
namespace qr_kod
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
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.tbMetin = new System.Windows.Forms.TextBox();
            this.pbQr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOlustur.Location = new System.Drawing.Point(150, 159);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(249, 94);
            this.BtnOlustur.TabIndex = 0;
            this.BtnOlustur.Text = "oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMetin
            // 
            this.tbMetin.Location = new System.Drawing.Point(139, 107);
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.Size = new System.Drawing.Size(260, 26);
            this.tbMetin.TabIndex = 1;
            // 
            // pbQr
            // 
            this.pbQr.Location = new System.Drawing.Point(457, 50);
            this.pbQr.Name = "pbQr";
            this.pbQr.Size = new System.Drawing.Size(224, 203);
            this.pbQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQr.TabIndex = 2;
            this.pbQr.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbQr);
            this.Controls.Add(this.tbMetin);
            this.Controls.Add(this.BtnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.TextBox tbMetin;
        private System.Windows.Forms.PictureBox pbQr;
    }
}

