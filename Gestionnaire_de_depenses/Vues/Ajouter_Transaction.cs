using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Gestionnaire_de_depenses.Vues
{
    public partial class Ajouter_Transaction : Form
    {
        //declaration des variables
        string cs = ConfigurationManager.ConnectionStrings["datacon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter adapter;
        DataTable dt;
        public static double mont;
        string usern;

        public Ajouter_Transaction()
        {
            InitializeComponent();
            Login l= new Login();
            usern = Login.user;
            Console.WriteLine(usern);
        }

        public void clearAllData()
        {
            nomtrans.Clear();
            montant.Clear();
            categorie.SelectedItem = null;
        }
        int ids;
        private void button1_Click(object sender, EventArgs e)
        {
            
            using (con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 ID_Budget FROM Budget ORDER BY Mois_Budget DESC";

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    ids = Convert.ToInt32(result);
                    con.Close();
                }
            }
            using (con = new SqlConnection(cs))
            {
                float montantparsed = 0;
                try
                {
                    montantparsed = float.Parse(montant.Text);
                }
                catch (Exception ex) { MessageBox.Show("Veuiller entrer un float "); montantparsed = 0; }

                if (nomtrans.Text == "" || categorie.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Vérifier les champs");
                }
                else if ((montantparsed > 0))
                {
                    try
                    {

                        con.Open();
                        cmd = new SqlCommand("Insert Into Transactions (Nom_Transactions, Montant, Date, Categorie , Utilisateur_Username , budget_idb) Values (@Nom_Transactions, @Montant, @Date, @Categorie , @usern , @idbud)", con);
                        cmd.Parameters.AddWithValue("@Nom_Transactions", nomtrans.Text);
                        cmd.Parameters.AddWithValue("@Montant", montantparsed);
                        cmd.Parameters.AddWithValue("@Date", date.Value);
                        cmd.Parameters.AddWithValue("@Categorie", categorie.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@idbud", ids );

                        cmd.Parameters.AddWithValue("@usern", usern);
                        cmd2 = new SqlCommand("SELECT TOP 1 Montant FROM Budget  where  utilisateur_username = @user ORDER BY ID_Budget DESC", con);

                        cmd2.Parameters.AddWithValue("@user", Login.user);
                        object result = cmd2.ExecuteScalar();
                        if (result != null)
                        {
                            mont = Convert.ToDouble(result);
                        }


                    }
                    catch (Exception ex) { MessageBox.Show("Vérifier requête sql" + ex.Message); }
                    if (mont - montantparsed >= 0) {
                        try 
                        { 
                            cmd2 = new SqlCommand("UPDATE Budget SET Montant = @montant WHERE    utilisateur_username = @user and ID_Budget = (SELECT TOP 1 ID_Budget FROM Budget where  utilisateur_username = @user   ORDER BY ID_Budget DESC)", con);
                            cmd2.Parameters.AddWithValue("@montant", (mont - montantparsed));
                            cmd2.Parameters.AddWithValue("@user", Login.user);

                            mont -= montantparsed;
                            cmd2.ExecuteNonQuery();

                        }
                        catch (Exception ex) { MessageBox.Show("Vérifier requête sql" + ex.Message); }
                        int w = cmd.ExecuteNonQuery();
                        con.Close();
                        if (w > 0)
                        {
                            MessageBox.Show("Transaction ajouté avec succés");
                            clearAllData();

                        }
                    }
                    else { MessageBox.Show("Désolé , vous ne pouvez pas faire cette transactions car vous dépassez votre budget "); }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestion_de_transactions Gt = new Gestion_de_transactions();
            Gt.Show();
            this.Hide();
        }

    }
}
