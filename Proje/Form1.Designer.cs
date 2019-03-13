namespace Proje
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
            this.label1 = new System.Windows.Forms.Label();
            this.Asal1txt = new System.Windows.Forms.TextBox();
            this.Asal2txt = new System.Windows.Forms.TextBox();
            this.pureText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cryptedtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptedtxt = new System.Windows.Forms.TextBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.elbl = new System.Windows.Forms.Label();
            this.dlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asal Sayılar";
            // 
            // Asal1txt
            // 
            this.Asal1txt.Location = new System.Drawing.Point(143, 45);
            this.Asal1txt.Name = "Asal1txt";
            this.Asal1txt.Size = new System.Drawing.Size(100, 26);
            this.Asal1txt.TabIndex = 1;
            this.Asal1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Asal1txt_KeyPress);
            // 
            // Asal2txt
            // 
            this.Asal2txt.Location = new System.Drawing.Point(276, 45);
            this.Asal2txt.Name = "Asal2txt";
            this.Asal2txt.Size = new System.Drawing.Size(100, 26);
            this.Asal2txt.TabIndex = 2;
            this.Asal2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Asal2txt_KeyPress);
            // 
            // pureText
            // 
            this.pureText.Location = new System.Drawing.Point(192, 149);
            this.pureText.Name = "pureText";
            this.pureText.Size = new System.Drawing.Size(184, 26);
            this.pureText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifrelenecek Metin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crypted :";
            // 
            // cryptedtxt
            // 
            this.cryptedtxt.Location = new System.Drawing.Point(189, 250);
            this.cryptedtxt.Name = "cryptedtxt";
            this.cryptedtxt.ReadOnly = true;
            this.cryptedtxt.Size = new System.Drawing.Size(184, 26);
            this.cryptedtxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Encrypted:";
            // 
            // encryptedtxt
            // 
            this.encryptedtxt.Location = new System.Drawing.Point(189, 322);
            this.encryptedtxt.Name = "encryptedtxt";
            this.encryptedtxt.ReadOnly = true;
            this.encryptedtxt.Size = new System.Drawing.Size(184, 26);
            this.encryptedtxt.TabIndex = 7;
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(444, 18);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(123, 81);
            this.randomButton.TabIndex = 9;
            this.randomButton.Text = "Rastgele Üret";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 88);
            this.button2.TabIndex = 10;
            this.button2.Text = "Şifrele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // elbl
            // 
            this.elbl.AutoSize = true;
            this.elbl.Location = new System.Drawing.Point(440, 245);
            this.elbl.Name = "elbl";
            this.elbl.Size = new System.Drawing.Size(22, 20);
            this.elbl.TabIndex = 11;
            this.elbl.Text = "e:";
            this.elbl.Visible = false;
            // 
            // dlbl
            // 
            this.dlbl.AutoSize = true;
            this.dlbl.Location = new System.Drawing.Point(440, 328);
            this.dlbl.Name = "dlbl";
            this.dlbl.Size = new System.Drawing.Size(22, 20);
            this.dlbl.TabIndex = 12;
            this.dlbl.Text = "d:";
            this.dlbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 425);
            this.Controls.Add(this.dlbl);
            this.Controls.Add(this.elbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encryptedtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cryptedtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pureText);
            this.Controls.Add(this.Asal2txt);
            this.Controls.Add(this.Asal1txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Asal1txt;
        private System.Windows.Forms.TextBox Asal2txt;
        private System.Windows.Forms.TextBox pureText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cryptedtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox encryptedtxt;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label elbl;
        private System.Windows.Forms.Label dlbl;
    }
}

