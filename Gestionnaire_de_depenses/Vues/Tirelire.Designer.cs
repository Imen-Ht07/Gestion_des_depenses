namespace Gestionnaire_de_depenses.Vues
{
    partial class Tirelire
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tirelire));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nom_tirelire = new System.Windows.Forms.TextBox();
            this.description_tirelire = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nomTir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etats = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tirelireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaire_de_depensesDataSet4 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gestionnaire_de_depensesDataSet = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet();
            this.gestionnairededepensesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tirelireTableAdapter = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet4TableAdapters.tirelireTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tirelireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnairededepensesDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(38, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 43);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tirelire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Description";
            // 
            // nom_tirelire
            // 
            this.nom_tirelire.BackColor = System.Drawing.Color.LightCyan;
            this.nom_tirelire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_tirelire.Location = new System.Drawing.Point(12, 170);
            this.nom_tirelire.Name = "nom_tirelire";
            this.nom_tirelire.Size = new System.Drawing.Size(140, 20);
            this.nom_tirelire.TabIndex = 3;
            this.nom_tirelire.Enter += new System.EventHandler(this.EnterNom);
            // 
            // description_tirelire
            // 
            this.description_tirelire.BackColor = System.Drawing.Color.LightCyan;
            this.description_tirelire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_tirelire.Location = new System.Drawing.Point(12, 239);
            this.description_tirelire.Multiline = true;
            this.description_tirelire.Name = "description_tirelire";
            this.description_tirelire.Size = new System.Drawing.Size(140, 56);
            this.description_tirelire.TabIndex = 4;
            this.description_tirelire.Enter += new System.EventHandler(this.EnterDEsc);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomTir,
            this.montants,
            this.descriptions,
            this.etats,
            this.IDs});
            this.dataGridView3.DataSource = this.tirelireBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(186, 126);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(452, 210);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // nomTir
            // 
            this.nomTir.DataPropertyName = "Nom_Tirelire";
            this.nomTir.HeaderText = "Nom Tirelire";
            this.nomTir.Name = "nomTir";
            // 
            // montants
            // 
            this.montants.DataPropertyName = "Montant";
            this.montants.HeaderText = "Montant";
            this.montants.Name = "montants";
            // 
            // descriptions
            // 
            this.descriptions.DataPropertyName = "Description";
            this.descriptions.HeaderText = "Description";
            this.descriptions.Name = "descriptions";
            // 
            // etats
            // 
            this.etats.DataPropertyName = "terminer";
            this.etats.HeaderText = "terminer";
            this.etats.Name = "etats";
            // 
            // IDs
            // 
            this.IDs.DataPropertyName = "ID_Tirelire";
            this.IDs.HeaderText = "ID Tirelire";
            this.IDs.Name = "IDs";
            this.IDs.ReadOnly = true;
            // 
            // tirelireBindingSource
            // 
            this.tirelireBindingSource.DataMember = "tirelire";
            this.tirelireBindingSource.DataSource = this.gestionnaire_de_depensesDataSet4;
            // 
            // gestionnaire_de_depensesDataSet4
            // 
            this.gestionnaire_de_depensesDataSet4.DataSetName = "Gestionnaire_de_depensesDataSet4";
            this.gestionnaire_de_depensesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAjout);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(139, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnModif);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(248, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnSupp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(426, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 39);
            this.button4.TabIndex = 9;
            this.button4.Text = "Actualiser";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnActualiser);
            // 
            // gestionnaire_de_depensesDataSet
            // 
            this.gestionnaire_de_depensesDataSet.DataSetName = "Gestionnaire_de_depensesDataSet";
            this.gestionnaire_de_depensesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionnairededepensesDataSetBindingSource
            // 
            this.gestionnairededepensesDataSetBindingSource.DataSource = this.gestionnaire_de_depensesDataSet;
            this.gestionnairededepensesDataSetBindingSource.Position = 0;
            // 
            // tirelireTableAdapter
            // 
            this.tirelireTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(535, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 39);
            this.button5.TabIndex = 10;
            this.button5.Text = "Retour";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Image = global::Gestionnaire_de_depenses.Properties.Resources.tota_removebg_preview__1_;
            this.label8.Location = new System.Drawing.Point(468, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 119);
            this.label8.TabIndex = 11;
            // 
            // Tirelire
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(642, 424);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.description_tirelire);
            this.Controls.Add(this.nom_tirelire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tirelire";
            this.Text = "Gestionnaire de depenses";
            this.Load += new System.EventHandler(this.Tirelire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tirelireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnairededepensesDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestion_depensesDataSet gestion_depensesDataSet;
        private System.Windows.Forms.BindingSource gestiondepensesDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nom_tirelire;
        private System.Windows.Forms.TextBox description_tirelire;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Gestionnaire_de_depensesDataSet gestionnaire_de_depensesDataSet;
        private System.Windows.Forms.BindingSource gestionnairededepensesDataSetBindingSource;
        private Gestionnaire_de_depensesDataSet4 gestionnaire_de_depensesDataSet4;
        private System.Windows.Forms.BindingSource tirelireBindingSource;
        private Gestionnaire_de_depensesDataSet4TableAdapters.tirelireTableAdapter tirelireTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTir;
        private System.Windows.Forms.DataGridViewTextBoxColumn montants;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn etats;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDs;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
    }
}