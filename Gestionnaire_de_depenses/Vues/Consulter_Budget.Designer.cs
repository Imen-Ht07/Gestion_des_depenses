namespace Gestionnaire_de_depenses.Vues
{
    partial class Consulter_Budget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulter_Budget));
            this.btnAjout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.montant = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moisBudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_depensesDataSet = new Gestionnaire_de_depenses.gestion_depensesDataSet();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaire_de_depensesDataSet2 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet2();
            this.gestionnairededepensesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionnaire_de_depensesDataSet1 = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.mois_budget = new System.Windows.Forms.DateTimePicker();
            this.budgetTableAdapter = new Gestionnaire_de_depenses.Gestionnaire_de_depensesDataSet2TableAdapters.BudgetTableAdapter();
            this.budgetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetTableAdapter1 = new Gestionnaire_de_depenses.gestion_depensesDataSetTableAdapters.BudgetTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_depensesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnairededepensesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAjout.Location = new System.Drawing.Point(-3, 318);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(127, 31);
            this.btnAjout.TabIndex = 0;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(128, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsupp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsupp.FlatAppearance.BorderSize = 0;
            this.btnsupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnsupp.Location = new System.Drawing.Point(257, 318);
            this.btnsupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(127, 31);
            this.btnsupp.TabIndex = 2;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.UseVisualStyleBackColor = false;
            this.btnsupp.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = " Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(23, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Montant";
            // 
            // montant
            // 
            this.montant.BackColor = System.Drawing.Color.LightCyan;
            this.montant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.montant.Location = new System.Drawing.Point(27, 177);
            this.montant.Margin = new System.Windows.Forms.Padding(2);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(181, 20);
            this.montant.TabIndex = 9;
            this.montant.Enter += new System.EventHandler(this.montant_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.montantDataGridViewTextBoxColumn,
            this.moisBudgetDataGridViewTextBoxColumn,
            this.ID_Budget});
            this.dataGridView1.DataSource = this.budgetBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(388, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(290, 207);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.Width = 125;
            // 
            // moisBudgetDataGridViewTextBoxColumn
            // 
            this.moisBudgetDataGridViewTextBoxColumn.DataPropertyName = "Mois_Budget";
            this.moisBudgetDataGridViewTextBoxColumn.HeaderText = "Mois_Budget";
            this.moisBudgetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moisBudgetDataGridViewTextBoxColumn.Name = "moisBudgetDataGridViewTextBoxColumn";
            this.moisBudgetDataGridViewTextBoxColumn.Width = 125;
            // 
            // ID_Budget
            // 
            this.ID_Budget.DataPropertyName = "ID_Budget";
            this.ID_Budget.HeaderText = "ID_Budget";
            this.ID_Budget.MinimumWidth = 6;
            this.ID_Budget.Name = "ID_Budget";
            this.ID_Budget.ReadOnly = true;
            this.ID_Budget.Width = 125;
            // 
            // budgetBindingSource2
            // 
            this.budgetBindingSource2.DataMember = "Budget";
            this.budgetBindingSource2.DataSource = this.gestion_depensesDataSet;
            // 
            // gestion_depensesDataSet
            // 
            this.gestion_depensesDataSet.DataSetName = "gestion_depensesDataSet";
            this.gestion_depensesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "Budget";
            this.budgetBindingSource.DataSource = this.gestionnaire_de_depensesDataSet2;
            // 
            // gestionnaire_de_depensesDataSet2
            // 
            this.gestionnaire_de_depensesDataSet2.DataSetName = "Gestionnaire_de_depensesDataSet2";
            this.gestionnaire_de_depensesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionnairededepensesDataSet1BindingSource
            // 
            this.gestionnairededepensesDataSet1BindingSource.DataSource = this.gestionnaire_de_depensesDataSet1;
            this.gestionnairededepensesDataSet1BindingSource.Position = 0;
            // 
            // gestionnaire_de_depensesDataSet1
            // 
            this.gestionnaire_de_depensesDataSet1.DataSetName = "Gestionnaire_de_depensesDataSet1";
            this.gestionnaire_de_depensesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(23, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mois de budget";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(9, 353);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 31);
            this.button4.TabIndex = 14;
            this.button4.Text = "Actualiser";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mois_budget
            // 
            this.mois_budget.Location = new System.Drawing.Point(27, 235);
            this.mois_budget.Margin = new System.Windows.Forms.Padding(2);
            this.mois_budget.Name = "mois_budget";
            this.mois_budget.Size = new System.Drawing.Size(181, 20);
            this.mois_budget.TabIndex = 15;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // budgetBindingSource1
            // 
            this.budgetBindingSource1.DataMember = "Budget";
            this.budgetBindingSource1.DataSource = this.gestionnaire_de_depensesDataSet2;
            // 
            // budgetTableAdapter1
            // 
            this.budgetTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Gestionnaire_de_depenses.Properties.Resources.tota_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(388, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(185, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Consulter_Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(689, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mois_budget);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Consulter_Budget";
            this.Text = "Gestionnaire de depenses";
            this.Load += new System.EventHandler(this.Consulter_Budget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_depensesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnairededepensesDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaire_de_depensesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gestionnairededepensesDataSet1BindingSource;
        private Gestionnaire_de_depensesDataSet1 gestionnaire_de_depensesDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker mois_budget;
        private Gestionnaire_de_depensesDataSet2 gestionnaire_de_depensesDataSet2;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private Gestionnaire_de_depensesDataSet2TableAdapters.BudgetTableAdapter budgetTableAdapter;
        private System.Windows.Forms.BindingSource budgetBindingSource1;
        private gestion_depensesDataSet gestion_depensesDataSet;
        private System.Windows.Forms.BindingSource budgetBindingSource2;
        private gestion_depensesDataSetTableAdapters.BudgetTableAdapter budgetTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moisBudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Budget;
        private System.Windows.Forms.Button button1;
    }
}