namespace eLearningMareaUnire1918
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.lblTitul = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnInainte = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitul
            // 
            this.lblTitul.AutoSize = true;
            this.lblTitul.Location = new System.Drawing.Point(12, 21);
            this.lblTitul.Name = "lblTitul";
            this.lblTitul.Size = new System.Drawing.Size(247, 13);
            this.lblTitul.TabIndex = 0;
            this.lblTitul.Text = "Platforma eLearning dedicata Marii Uniri de la 1918";
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(12, 48);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(395, 39);
            this.lblDescriere.TabIndex = 1;
            this.lblDescriere.Text = "Aceasta platforma eLearnig este dedicata Marii Uniri de la 1918.\r\nLa 1 decembrie " +
    "2018 se implinesc 100 de ani de la Unirea Transilvaniei, Banatului,\r\nCrisanei si" +
    " Maramuresului cu Romania.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(165, 372);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(341, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(697, 121);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(713, 415);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(75, 23);
            this.btnIesire.TabIndex = 6;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnInainte
            // 
            this.btnInainte.Location = new System.Drawing.Point(165, 415);
            this.btnInainte.Name = "btnInainte";
            this.btnInainte.Size = new System.Drawing.Size(75, 23);
            this.btnInainte.TabIndex = 7;
            this.btnInainte.Text = "Inainte";
            this.btnInainte.UseVisualStyleBackColor = true;
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(431, 415);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 8;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(292, 415);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(85, 23);
            this.btnAuto.TabIndex = 9;
            this.btnAuto.Text = "Manual";
            this.btnAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(591, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(591, 147);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 11;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(553, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(551, 153);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 13;
            this.lblParola.Text = "Parola";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(556, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnInainte);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblTitul);
            this.Name = "Start";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitul;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnInainte;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

