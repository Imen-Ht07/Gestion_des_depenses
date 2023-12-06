namespace Gestionnaire_de_depenses.Vues
{
    partial class Ajouter_Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_Transaction));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomtrans = new System.Windows.Forms.TextBox();
            this.montant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(64, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom transaction";
            // 
            // date
            // 
            this.date.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.date.CalendarTitleBackColor = System.Drawing.Color.LightCyan;
            this.date.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.date.Location = new System.Drawing.Point(68, 280);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 2;
            // 
            // categorie
            // 
            this.categorie.BackColor = System.Drawing.Color.LightCyan;
            this.categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorie.FormattingEnabled = true;
            this.categorie.Items.AddRange(new object[] {
            "Nourriture",
            "Santé",
            "Habillement",
            "Réparation",
            "Éducation",
            "Produits ménageaire",
            "Loisirs",
            "Transports",
            "Électroménagers",
            "Autres"});
            this.categorie.Location = new System.Drawing.Point(68, 340);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(194, 21);
            this.categorie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(64, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Montant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(64, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(64, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Catégorie";
            // 
            // nomtrans
            // 
            this.nomtrans.BackColor = System.Drawing.Color.LightCyan;
            this.nomtrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomtrans.Location = new System.Drawing.Point(68, 160);
            this.nomtrans.Name = "nomtrans";
            this.nomtrans.Size = new System.Drawing.Size(194, 20);
            this.nomtrans.TabIndex = 7;
            // 
            // montant
            // 
            this.montant.BackColor = System.Drawing.Color.LightCyan;
            this.montant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.montant.Location = new System.Drawing.Point(68, 220);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(194, 20);
            this.montant.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(413, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(413, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Image = global::Gestionnaire_de_depenses.Properties.Resources.tota_removebg_preview__1___1_;
            this.label6.Location = new System.Drawing.Point(386, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 155);
            this.label6.TabIndex = 11;
            // 
            // Ajouter_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(583, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.nomtrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categorie);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajouter_Transaction";
            this.Text = "Gestionnaire de depenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox categorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomtrans;
        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}