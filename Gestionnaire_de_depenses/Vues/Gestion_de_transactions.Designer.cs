namespace Gestionnaire_de_depenses.Vues
{


    partial class Gestion_de_transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_transactions));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.transactionsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaire_de_depensesDataSet1 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet1();
            this.transactionsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaire_de_depensesDataSet = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet1();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet1TableAdapters.TransactionsTableAdapter();
            this.transactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter1 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet1TableAdapters.TransactionsTableAdapter();
            this.gestionnaire_de_depensesDataSet2 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet1();
            this.transactionsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomTransactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Transactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaire_de_depensesDataSet31 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet3();
            this.transactionsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaire_de_depensesDataSet3 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet();
            this.transactionsTableAdapter2 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSetTableAdapters.TransactionsTableAdapter();
            this.transactionsTableAdapter3 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet3TableAdapters.TransactionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(482, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(482, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajouter une transaction";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // transactionsBindingSource5
            // 
            this.transactionsBindingSource5.DataMember = "Transactions";
            this.transactionsBindingSource5.DataSource = this.gestionnaire_de_depensesDataSet1;
            // 
            // gestionnaire_de_depensesDataSet1
            // 
            this.gestionnaire_de_depensesDataSet1.DataSetName = "Gestionnaire_de_depensesDataSet1";
            this.gestionnaire_de_depensesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource4
            // 
            this.transactionsBindingSource4.DataMember = "Transactions";
            this.transactionsBindingSource4.DataSource = this.gestionnaire_de_depensesDataSet1;
            // 
            // gestionnaire_de_depensesDataSet
            // 
            this.gestionnaire_de_depensesDataSet.DataSetName = "Gestionnaire_de_depensesDataSet";
            this.gestionnaire_de_depensesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.gestionnaire_de_depensesDataSet;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // transactionsBindingSource1
            // 
            this.transactionsBindingSource1.DataMember = "Transactions";
            this.transactionsBindingSource1.DataSource = this.gestionnaire_de_depensesDataSet;
            // 
            // transactionsBindingSource2
            // 
            this.transactionsBindingSource2.DataMember = "Transactions";
            this.transactionsBindingSource2.DataSource = this.gestionnaire_de_depensesDataSet1;
            // 
            // transactionsTableAdapter1
            // 
            this.transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // gestionnaire_de_depensesDataSet2
            // 
            this.gestionnaire_de_depensesDataSet2.DataSetName = "Gestionnaire_de_depensesDataSet";
            this.gestionnaire_de_depensesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource3
            // 
            this.transactionsBindingSource3.DataMember = "Transactions";
            this.transactionsBindingSource3.DataSource = this.gestionnaire_de_depensesDataSet2;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.update.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(482, 229);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(115, 28);
            this.update.TabIndex = 3;
            this.update.Text = "modifier";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.delete.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(482, 280);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 28);
            this.delete.TabIndex = 4;
            this.delete.Text = "supprimer";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomTransactions,
            this.montants,
            this.dates,
            this.categories,
            this.ID_Transactions});
            this.dataGridView1.DataSource = this.transactionsBindingSource7;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 248);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nomTransactions
            // 
            this.nomTransactions.DataPropertyName = "Nom_Transactions";
            this.nomTransactions.HeaderText = "Nom Transactions";
            this.nomTransactions.Name = "nomTransactions";
            // 
            // montants
            // 
            this.montants.DataPropertyName = "Montant";
            this.montants.HeaderText = "Montant";
            this.montants.Name = "montants";
            // 
            // dates
            // 
            this.dates.DataPropertyName = "Date";
            this.dates.HeaderText = "Date";
            this.dates.Name = "dates";
            // 
            // categories
            // 
            this.categories.DataPropertyName = "Categorie";
            this.categories.HeaderText = "Categorie";
            this.categories.Name = "categories";
            // 
            // ID_Transactions
            // 
            this.ID_Transactions.DataPropertyName = "ID_Transactions";
            this.ID_Transactions.HeaderText = "ID Transactions";
            this.ID_Transactions.Name = "ID_Transactions";
            this.ID_Transactions.ReadOnly = true;
            // 
            // transactionsBindingSource7
            // 
            this.transactionsBindingSource7.DataMember = "Transactions";
            this.transactionsBindingSource7.DataSource = this.gestionnaire_de_depensesDataSet31;
            // 
            // gestionnaire_de_depensesDataSet31
            // 
            this.gestionnaire_de_depensesDataSet31.DataSetName = "Gestionnaire_de_depensesDataSet3";
            this.gestionnaire_de_depensesDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource6
            // 
            this.transactionsBindingSource6.DataMember = "Transactions";
            this.transactionsBindingSource6.DataSource = this.gestionnaire_de_depensesDataSet3;
            // 
            // gestionnaire_de_depensesDataSet3
            // 
            this.gestionnaire_de_depensesDataSet3.DataSetName = "Gestionnaire_de_depensesDataSet";
            this.gestionnaire_de_depensesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsTableAdapter2
            // 
            this.transactionsTableAdapter2.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter3
            // 
            this.transactionsTableAdapter3.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gérer les transactions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Image = global::Gestionnaire_de_depenses.Properties.Resources.tota_removebg_preview__1___1_;
            this.label2.Location = new System.Drawing.Point(460, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 142);
            this.label2.TabIndex = 7;
            // 
            // Gestion_de_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(647, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_de_transactions";
            this.Text = "Gestionnaire de depenses";
            this.Load += new System.EventHandler(this.Gestion_de_transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Gestionnaire_de_depensesDataSet1 gestionnaire_de_depensesDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private Gestionnaire_de_depensesDataSet1TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.BindingSource transactionsBindingSource1;
        private Gestionnaire_de_depensesDataSet1 gestionnaire_de_depensesDataSet1;
        private System.Windows.Forms.BindingSource transactionsBindingSource2;
        private Gestionnaire_de_depensesDataSet1TableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
        private Gestionnaire_de_depensesDataSet1 gestionnaire_de_depensesDataSet2;
        private System.Windows.Forms.BindingSource transactionsBindingSource3;
        private System.Windows.Forms.BindingSource transactionsBindingSource4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.BindingSource transactionsBindingSource5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Gestionnaire_de_depensesDataSet gestionnaire_de_depensesDataSet3;
        private System.Windows.Forms.BindingSource transactionsBindingSource6;
        private Gestionnaire_de_depensesDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn montants;
        private System.Windows.Forms.DataGridViewTextBoxColumn dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn categories;
        private Gestionnaire_de_depensesDataSet3 gestionnaire_de_depensesDataSet31;
        private System.Windows.Forms.BindingSource transactionsBindingSource7;
        private Gestionnaire_de_depensesDataSet3TableAdapters.TransactionsTableAdapter transactionsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Transactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}