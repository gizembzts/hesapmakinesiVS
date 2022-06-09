
namespace hesapmakinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sayi1txt = new System.Windows.Forms.TextBox();
            this.sayi2txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.böl = new System.Windows.Forms.Button();
            this.çıkar = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.çarp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sonuçtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sayi1txt
            // 
            this.sayi1txt.Location = new System.Drawing.Point(55, 64);
            this.sayi1txt.Name = "sayi1txt";
            this.sayi1txt.Size = new System.Drawing.Size(100, 23);
            this.sayi1txt.TabIndex = 0;
            // 
            // sayi2txt
            // 
            this.sayi2txt.Location = new System.Drawing.Point(170, 64);
            this.sayi2txt.Name = "sayi2txt";
            this.sayi2txt.Size = new System.Drawing.Size(100, 23);
            this.sayi2txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Sayı";
            // 
            // böl
            // 
            this.böl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.böl.Location = new System.Drawing.Point(161, 244);
            this.böl.Name = "böl";
            this.böl.Size = new System.Drawing.Size(83, 41);
            this.böl.TabIndex = 3;
            this.böl.Text = "/";
            this.böl.UseVisualStyleBackColor = true;
            this.böl.Click += new System.EventHandler(this.böl_Click);
            // 
            // çıkar
            // 
            this.çıkar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.çıkar.Location = new System.Drawing.Point(161, 185);
            this.çıkar.Name = "çıkar";
            this.çıkar.Size = new System.Drawing.Size(83, 40);
            this.çıkar.TabIndex = 3;
            this.çıkar.Text = "-";
            this.çıkar.UseVisualStyleBackColor = true;
            this.çıkar.Click += new System.EventHandler(this.çıkar_Click);
            // 
            // topla
            // 
            this.topla.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topla.Location = new System.Drawing.Point(54, 185);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(85, 40);
            this.topla.TabIndex = 3;
            this.topla.Text = "+";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // çarp
            // 
            this.çarp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.çarp.Location = new System.Drawing.Point(54, 244);
            this.çarp.Name = "çarp";
            this.çarp.Size = new System.Drawing.Size(85, 41);
            this.çarp.TabIndex = 3;
            this.çarp.Text = "*";
            this.çarp.UseVisualStyleBackColor = true;
            this.çarp.Click += new System.EventHandler(this.çarp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Sayı";
            // 
            // sonuçtxt
            // 
            this.sonuçtxt.BackColor = System.Drawing.Color.White;
            this.sonuçtxt.Enabled = false;
            this.sonuçtxt.Location = new System.Drawing.Point(100, 127);
            this.sonuçtxt.Name = "sonuçtxt";
            this.sonuçtxt.Size = new System.Drawing.Size(124, 23);
            this.sonuçtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 333);
            this.Controls.Add(this.sonuçtxt);
            this.Controls.Add(this.çıkar);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.çarp);
            this.Controls.Add(this.böl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayi2txt);
            this.Controls.Add(this.sayi1txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sayi1txt;
        private System.Windows.Forms.TextBox sayi2txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button böl;
        private System.Windows.Forms.Button çıkar;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button çarp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sonuçtxt;
        private System.Windows.Forms.Label label3;
    }
}

