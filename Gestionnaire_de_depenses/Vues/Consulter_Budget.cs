using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Gestionnaire_de_depenses.Vues
{
    public partial class Consulter_Budget : Form
    {
        // ***BD ***
        // connection string, SqlConnection, SqlCommand, SqlDataAdapter, and a DataTable.
        string cs = ConfigurationManager.ConnectionStrings["datacon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        

        public Consulter_Budget()
        {
            InitializeComponent();
            Check_month();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        { using (con = new SqlConnection(cs))
            { con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ID_Budget, Montant, Mois_Budget FROM Budget where utilisateur_username = @user ";
            cmd.Parameters.AddWithValue("@user ", Login.user);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            }
        }


        private void montant_Enter(object sender, EventArgs e)
        {
            montant.Text = "";
        }

        public void Check_month()
        {
            if (DateTime.Now.Day == 1)
            {
                /*Consulter_Budget csb = new Consulter_Budget();
                csb.Show();
                this.Hide();*/
                MessageBox.Show("Un nouveau mois est commencé veuillez introduire un nouveau mois !");

            }
        }
        // BOUTON AJOUT
        private void button1_Click(object sender, EventArgs e)
        {
            // Utilisation d'une instruction 'using' pour assurer la fermeture automatique de la connexion.
            using (con = new SqlConnection(cs))
            {
                float montantparsed = 0;

                try
                {
                    montantparsed = float.Parse(montant.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veuillez entrer un montant valide (nombre décimal).");
                    montantparsed = 0;
                    return; // Sortir de la méthode si la conversion échoue.
                }

                if (montantparsed > 0)
                {
                    con.Open();
                    // Use the value of mois_budget instead of DateTime.Now
                    DateTime selectedDate = mois_budget.Value;

                    // Vérifier s'il existe déjà un budget pour le mois actuel
                    if (!BudgetExistsForMonth(selectedDate))
                    {
                        // Utilisation de paramètres pour éviter les problèmes de sécurité (injection SQL).
                        cmd = new SqlCommand("INSERT INTO Budget (Montant, Mois_Budget , Utilisateur_Username) VALUES (@Montant, @Mois_Budget , @user)", con);
                        cmd.Parameters.AddWithValue("@Montant", montantparsed);
                        cmd.Parameters.AddWithValue("@Mois_Budget", selectedDate.ToString("MMM"));
                        cmd.Parameters.AddWithValue("@user", Login.user);


                        int w = cmd.ExecuteNonQuery();
                        cleardata();
                        con.Close();
                        displaydata();

                        // Check if it's the 1st day of the month
                       
                        //condition 
                        if (w > 0)
                        {
                            MessageBox.Show("Budget ajouté avec succès.");
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'ajout du budget. Veuillez réessayer.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Un budget existe déjà pour le mois sélectionné. Vous ne pouvez pas ajouter un autre budget pour le même mois.");
                    }
                }
                else
                {
                    MessageBox.Show("Le montant doit être supérieur à zéro.");
                }
            }
        }
        // un seul budget chaque mois 
        private bool BudgetExistsForMonth(DateTime selectedDate)
        {
            // Vérifiez si un budget existe déjà pour le mois actuel
            using (SqlCommand checkCmd = con.CreateCommand())
            {
                checkCmd.CommandType = CommandType.Text;
                checkCmd.CommandText = "SELECT COUNT(*) FROM Budget WHERE Utilisateur_username = @user and Mois_Budget = @Mois_Budget";
                checkCmd.Parameters.AddWithValue("@Mois_Budget", selectedDate.ToString("MMM"));
                checkCmd.Parameters.AddWithValue("@user", Login.user);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                return count > 0;
            }
        }



        // fonction Effacer les données après avoir soumis les détails pour effacer les zones de texte.
        private void cleardata()
        {
            montant.Clear();
            mois_budget.Value = DateTime.Today; // or mois_budget.Value = null;
        }

        // Actualiser 
        private void button4_Click(object sender, EventArgs e)
        {
            Consulter_Budget CB = new Consulter_Budget();
            CB.Show();
            this.Hide();
        }

        // MODIFICATION
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    // Use the value of mois_budget instead of DateTime.Now
                    DateTime selectedDate = mois_budget.Value;


                    // Check if a row is selected in the DataGridView
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                        int budgetId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID_Budget"].Value);

                        float montantParsed;

                        // Vérifiez si la valeur dans la zone de texte montant peut être convertie en float
                        if (float.TryParse(montant.Text, out montantParsed))
                        {
                            using (SqlCommand cmd = con.CreateCommand())
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "UPDATE Budget SET Montant=@Montant, Mois_Budget=@Mois WHERE ID_Budget=@BudgetId";
                                cmd.Parameters.AddWithValue("@Montant", montantParsed);
                                cmd.Parameters.AddWithValue("@Mois", selectedDate.ToString("MMM"));
                                cmd.Parameters.AddWithValue("@BudgetId", budgetId);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    cleardata();
                                    con.Close();
                                    displaydata();
                                    MessageBox.Show("Budget mis à jour avec succès.");
                                }
                                else
                                {
                                    MessageBox.Show("Aucun enregistrement trouvé avec l'ID fourni.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Veuillez entrer un montant valide (nombre décimal).");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner une ligne à mettre à jour.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Suppression 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Check if a row is selected in the DataGridView
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                        int budgetId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID_Budget"].Value);

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Budget WHERE ID_Budget=@BudgetId", con))
                        {
                            cmd.Parameters.AddWithValue("@BudgetId", budgetId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                cleardata();
                                con.Close();
                                displaydata(); // Rafraîchir les données après la suppression
                                MessageBox.Show("Budget supprimé avec succès.");
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement trouvé avec l'ID fourni.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Consulter_Budget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_depensesDataSet.Budget' table. You can move, or remove it, as needed.
            //this.budgetTableAdapter1.Fill(this.gestion_depensesDataSet.Budget);
            // TODO: cette ligne de code charge les données dans la table 'gestionnaire_de_depensesDataSet2.Budget'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.budgetTableAdapter.Fill(this.gestionnaire_de_depensesDataSet2.Budget);

            // Fetch the existing budget data and display it in the DataGridView
            using (con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_Budget, Montant, Mois_Budget FROM Budget where utilisateur_username = @user ";
                cmd.Parameters.AddWithValue("@user ", Login.user);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            accueil a = new accueil();
            a.Show();
            this.Close();
        }
    }
}
