namespace Gestionnaire_de_depenses.Vues
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.connexion = new System.Windows.Forms.Button();
            this.inscri = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connexion
            // 
            this.connexion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.connexion.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.connexion.ForeColor = System.Drawing.Color.White;
            this.connexion.Location = new System.Drawing.Point(35, 428);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(231, 71);
            this.connexion.TabIndex = 0;
            this.connexion.Text = "Se Connecter";
            this.connexion.UseVisualStyleBackColor = false;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // inscri
            // 
            this.inscri.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inscri.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.inscri.ForeColor = System.Drawing.Color.White;
            this.inscri.Location = new System.Drawing.Point(35, 522);
            this.inscri.Name = "inscri";
            this.inscri.Size = new System.Drawing.Size(231, 71);
            this.inscri.TabIndex = 1;
            this.inscri.Text = "Créer Un Compte";
            this.inscri.UseVisualStyleBackColor = false;
            this.inscri.Click += new System.EventHandler(this.inscri_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(35, 284);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(35, 346);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(240, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenue , Connecterz-vous pour accéder a votre application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(35, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(35, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Image = global::Gestionnaire_de_depenses.Properties.Resources.money_bag__2_1;
            this.label4.Location = new System.Drawing.Point(440, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(605, 537);
            this.label4.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1123, 631);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inscri);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Gestionnaire de depenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connexion;
        private System.Windows.Forms.Button inscri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}