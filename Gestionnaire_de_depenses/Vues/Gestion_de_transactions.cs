using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Gestionnaire_de_depenses.Vues
{
    /*;*/

    public partial class Gestion_de_transactions : Form
    {   //Déclaration des variables
        string cs = ConfigurationManager.ConnectionStrings["datacon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        SqlCommand cmd2;
        SqlDataAdapter adapter;
        DataTable dt;
        double mont;
        string nomtrans;
        string montant;
        string date;
        string categorie;
        int id;
        DateTime myDate;

        public Gestion_de_transactions()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            Ajouter_Transaction At = new Ajouter_Transaction();

            At.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accueil a = new accueil();
            a.Show();
            this.Close();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
                id = int.Parse(this.dataGridView1.CurrentRow.Cells["ID_Transactions"].Value.ToString());
                nomtrans = this.dataGridView1.CurrentRow.Cells["Nomtransactions"].Value.ToString();
                montant = this.dataGridView1.CurrentRow.Cells["montants"].Value.ToString();
                categorie = this.dataGridView1.CurrentRow.Cells["categories"].Value.ToString();
                date = this.dataGridView1.CurrentRow.Cells["dates"].Value.ToString();
                myDate = DateTime.Parse(date);
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd2 = new SqlCommand("SELECT TOP 1 Montant FROM Budget ORDER BY ID_Budget DESC", con);
                object result = cmd2.ExecuteScalar();

                // Vérification si le résultat n'est pas null
                if (result != null)
                {
                    mont = Convert.ToDouble(result);   
                }
                con.Close();
            }
            
        }


        private void delete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("Delete from transactions where ID_Transactions =@id  and utilisateur_username = @userlogin", con);                
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@userlogin", Login.user);
                cmd2 = new SqlCommand("UPDATE Budget SET Montant = @montant WHERE utilisateur_username = @userlogin AND ID_Budget = (SELECT TOP 1 ID_Budget FROM Budget WHERE utilisateur_username = @userlogin ORDER BY ID_Budget DESC)", con);
                cmd2.Parameters.AddWithValue("@montant", (mont));
                cmd2.Parameters.AddWithValue("@userlogin", Login.user);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                showData(); 

            }
        }
        public void showData()
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select  ID_Transactions , nom_transactions , montant , date , categorie from transactions where  utilisateur_username = @user ";
                cmd.Parameters.AddWithValue("@user ", Login.user);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();

            }
        }

        private void Gestion_de_transactions_Load(object sender, EventArgs e)
        {
            showData();
        }
        int w;
        private void update_Click_1(object sender, EventArgs e)
        {
            if (mont + getmontant(id) - float.Parse(montant) >= 0)
            {
                try
                {
                    using (con = new SqlConnection(cs))
                    {
                        con.Open();
                        cmd2 = new SqlCommand("UPDATE Budget SET Montant = @montant WHERE utilisateur_username = @userlogin AND ID_Budget = (SELECT TOP 1 ID_Budget FROM Budget WHERE utilisateur_username = @userlogin ORDER BY ID_Budget DESC)", con);
                        cmd2.Parameters.AddWithValue("@montant", (mont + getmontant(id) - double.Parse(montant)));
                        cmd2.Parameters.AddWithValue("@userlogin", Login.user);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vérifier requête sql" + ex.Message);
                }
                using (con = new SqlConnection(cs))
                {
                    
                    con.Open();                    
                    cmd = new SqlCommand("UPDATE Transactions SET Nom_Transactions=@Nom_Transactions , Montant= @Montant , Date=@Date, Categorie=@Categorie where ID_Transactions =@id", con);
                    cmd.Parameters.AddWithValue("@Nom_Transactions", nomtrans);
                    cmd.Parameters.AddWithValue("@Montant", double.Parse(montant));
                    cmd.Parameters.AddWithValue("@Date", myDate);
                    cmd.Parameters.AddWithValue("@Categorie", categorie);
                    cmd.Parameters.AddWithValue("@id", id);
                    w = cmd.ExecuteNonQuery();
                    
                    if (w > 0)
                    {

                        con.Close();
                        showData();

                        MessageBox.Show("Transactions mis à jour avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Aucun enregistrement trouvé avec l'ID fourni.");
                    }
                }
            }


            else { MessageBox.Show("Désolé , vous ne pouvez pas modifier le budget cette transactions car vous dépassez votre budget "); }

        }
        double montantdebase;
        private double getmontant(int ids)
        {
            using(con = new SqlConnection(cs)) 
            {
                con.Open();
                cmd = new SqlCommand("select montant from transactions where ID_Transactions = @ids", con);
                cmd.Parameters.AddWithValue("@ids", ids);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    montantdebase = Convert.ToDouble(result);
                    
                }
            }
            return montantdebase;
        }
    }
}