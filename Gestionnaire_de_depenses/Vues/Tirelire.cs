using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Gestionnaire_de_depenses.Vues
{
    public partial class Tirelire : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["datacon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public Tirelire()
        {
            InitializeComponent();
            Addmontatn();
        }
       

        private void btnActualiser(object sender, EventArgs e)
        {
            Tirelire CB = new Tirelire();
            CB.Show();
            this.Hide();
        }

        private void btnSupp(object sender, EventArgs e)
        {
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Vérifier si une ligne est sélectionnée dans le DataGridView
                    
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Tirelire WHERE ID_Tirelire=@TirelireId ", con))
                        {
                            cmd.Parameters.AddWithValue("@TirelireId", id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                            
                                MessageBox.Show("Tirelire supprimée avec succès.");
                                // Rafraîchir les données après la suppression
                                //dataGridView3_CellContentClick();
                                showData();
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement trouvé avec l'ID fourni.");
                            }
                        }
                   
                    con.Close();
                }
            }
        }
        SqlDataAdapter adapter;
        DataTable dt;
        public void showData()
        {
            using (con = new SqlConnection(cs))
            {

                /*dt = new DataTable();
                adapter = new SqlDataAdapter("Select  ID_Tirelire , nom_Tirelire , montant , description , terminer from Tirelire where utilisateur_username=@user ", con);
                
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
                */
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select  ID_Tirelire , nom_Tirelire , montant , description , terminer from Tirelire where utilisateur_username=@user ";
                cmd.Parameters.AddWithValue("@user ", Login.user);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView3.DataSource = dt;

                con.Close();
            }
        }
        private void btnModif(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();

                // Vérifier si une ligne est sélectionnée dans le DataGridView
                /*if (dataGridView1.SelectedRows.Count > 0)
                {*/
                /*int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int tirelireId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID_Tirelire"].Value);
                */
                // Récupérer le montant actuel de la tirelire
                double montantActuel = GetTirelireAmount(id);

                // Modifier la tirelire
                using (con = new SqlConnection(cs))
                {       con.Open();
                        cmd = new SqlCommand("UPDATE Tirelire SET Montant=@Montant, Nom_Tirelire=@Nom_Tirelire, Description=@Description  , terminer=@etat WHERE ID_Tirelire=@TirelireId", con);
                    
                        cmd.Parameters.AddWithValue("@Montant", montant); // Conserver le montant actuel
                        cmd.Parameters.AddWithValue("@Nom_Tirelire", nomtire);
                        cmd.Parameters.AddWithValue("@Description", desc);
                        cmd.Parameters.AddWithValue("@TirelireId", id);
                        cmd.Parameters.AddWithValue("@etat", etat);
                    Console.WriteLine(etat);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                        con.Close();
                            MessageBox.Show("Tirelire modifiée avec succès.");
                            // Rafraîchir les données après la modification
                            //dataGridView3_CellContentClick();
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement trouvé avec l'ID fourni.");
                        }
                    }
                /*}
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne à mettre à jour.");
                }*/

                con.Close();
            }
        }
        // Méthode pour récupérer le montant actuel d'une tirelire
        private double GetTirelireAmount(int tirelireId)
        {
            double montant = 0;

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Montant FROM Tirelire WHERE ID_Tirelire = @TirelireId";
                cmd.Parameters.AddWithValue("@TirelireId", tirelireId);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    montant = Convert.ToDouble(result);
                }
            }

            return montant;
        }
        private void Addmontatn()
        {
            DateTime date = DateTime.Now;
            if (date.Day == 1) 
            {
                
                using ( con = new SqlConnection(cs))
                {
                    con.Open();
                    cmd = new SqlCommand("Select TOP 1  ID_Tirelire from Tirelire ORDER BY ID_Tirelire DESC", con);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        id= int.Parse(result.ToString());
                    }
                    cmd = new SqlCommand(" UPDATE Tirelire SET Montant =@Montant where ID_Tirelire=@id ", con);
                    cmd.Parameters.AddWithValue("@Montant", GetTirelireAmount(id) + GetLastBudgetAmount());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
        }
        private void EnterNom(object sender, EventArgs e)
        {
            nom_tirelire.Text = "";
        }
        private void EnterDEsc(object sender, EventArgs e)
        {
            description_tirelire.Text = "";
        }

        private void btnAjout(object sender, EventArgs e)
        {
                
            using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Récupérer le montant du dernier budget
                    double montantBudget = GetLastBudgetAmount();

                    // Ajouter la tirelire
                    cmd = new SqlCommand("INSERT INTO Tirelire (Montant, Nom_Tirelire, Description , utilisateur_username) VALUES (@Montant, @Nom_Tirelire, @Description , @user)", con);
                    cmd.Parameters.AddWithValue("@Montant", montantBudget);
                    cmd.Parameters.AddWithValue("@Nom_Tirelire", nom_tirelire.Text);
                cmd.Parameters.AddWithValue("@Description", description_tirelire.Text);
                cmd.Parameters.AddWithValue("@user", Login.user);
                
                int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        showData();
                        MessageBox.Show("Tirelire ajoutée avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Échec de l'ajout de la tirelire. Veuillez réessayer.");
                    }

                    con.Close();
                }
            }

        private double GetLastBudgetAmount()
            {
                double montant = 0;
            

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 Montant FROM Budget WHERE Utilisateur_Username = @Username ORDER BY Mois_Budget DESC";
                cmd.Parameters.AddWithValue("@Username", Login.user);

                object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        montant = Convert.ToDouble(result);
                    }
                }

                return montant;
            }

        private void SupprimerDernierBudget()
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Budget WHERE ID_Budget = (SELECT TOP 1 ID_Budget FROM Budget ORDER BY Mois_Budget DESC)", con))
                {
                    cmd.ExecuteNonQuery();
                }
            }

        /*private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_Tirelire, Montant, Nom_Tirelire, Description FROM Tirelire";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        */
        private void Tirelire_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select  ID_Tirelire , nom_Tirelire , montant , description , terminer from Tirelire where utilisateur_username=@user ";
                cmd.Parameters.AddWithValue("@user ", Login.user);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView3.DataSource = dt;

                con.Close();
            }
        }

        string nomtire;
        string montant;
        bool etat; 
        string desc;
        int id;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(this.dataGridView3.CurrentRow.Cells["IDs"].Value.ToString());
            nomtire = this.dataGridView3.CurrentRow.Cells["nomTir"].Value.ToString();
            montant = this.dataGridView3.CurrentRow.Cells["montants"].Value.ToString();

            desc = this.dataGridView3.CurrentRow.Cells["descriptions"].Value.ToString();
            etat = bool.Parse(this.dataGridView3.CurrentRow.Cells["etats"].Value.ToString());
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            accueil a= new accueil();
            a.Show();
            this.Hide();
        }
    }
    }
    

    
