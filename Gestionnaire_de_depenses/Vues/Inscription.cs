using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_depenses.Vues
{
    public partial class Inscription : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["datacon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter adapter;
        DataTable dt;
        int tel;
        public string user;
        public Inscription()
        {
            InitializeComponent();
        }
        static bool IsPasswordValid(string password)
        {
            // Vérifie si le mot de passe a une longueur d'au moins 8 caractères
            if (password.Length < 8)
            {
                return false;
            }

            // Vérifie la présence d'au moins une majuscule
            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            // Vérifie la présence d'au moins une minuscule
            if (!password.Any(char.IsLower))
            {
                return false;
            }

            // Vérifie la présence d'au moins un chiffre
            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            // Vérifie la présence d'au moins un caractère spécial
            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                return false;
            }

            // Si toutes les conditions sont remplies, le mot de passe est valide
            return true;
        }

        static bool IsValidEmail(string email)
        {
            // Utiliser une expression régulière pour valider l'adresse e-mail
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        static string HashMotDePasseSHA256(string motDePasse)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir le mot de passe en tableau de bytes
                byte[] motDePasseBytes = Encoding.UTF8.GetBytes(motDePasse);

                // Calculer le haché du mot de passe
                byte[] hashBytes = sha256.ComputeHash(motDePasseBytes);

                // Convertir le haché en une chaîne hexadécimale
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2")); // "x2" spécifie le format hexadécimal avec deux chiffres.
                }

                return stringBuilder.ToString();
            }
        }
        int count;
        private void inscri_Click(object sender, EventArgs e)
        {
            
            using (con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    cmd2 = new SqlCommand("SELECT COUNT(*) FROM Utilisateurs WHERE username = @user", con);
                    cmd2.Parameters.AddWithValue("@user", username.Text);
                    count = (int)cmd2.ExecuteScalar();  
                }
                catch (Exception ex) { MessageBox.Show("Erreur : " + ex); }

            }
            Console.WriteLine(count);    
            try
            {
                tel = int.Parse(telephone.Text);
            }
            catch (Exception ex ){ MessageBox.Show("votre numéro de téléphone n'est pas valide "); tel = 0; }
            string motdepasse =HashMotDePasseSHA256(mdp.Text);
            if (nom.Text == "" || prenom.Text == "" || email.Text == "" || motdepasse == "" || username.Text == "" )
            {
                MessageBox.Show("Vérifier les champs");
            }
            else
            {
                if ( ((tel) > 0) && (IsValidEmail(email.Text)) && (count==0) && ( IsPasswordValid(mdp.Text)))
                {
                    using (con = new SqlConnection(cs))
                    {
                        con.Open();
                        user = username.Text;
                        cmd = new SqlCommand("Insert Into Utilisateurs (Username , Nom , Prenom , Telephone , Mot_De_Passe , Adressemail , Date_de_naissance , Metier) values (@username , @nom , @prenom , @telephone , @mdp , @mail , @date , @metier )", con );
                        cmd.Parameters.AddWithValue("@username", username.Text.ToLower());
                        cmd.Parameters.AddWithValue("@nom", nom.Text);
                        cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                        cmd.Parameters.AddWithValue("@telephone", tel);
                        cmd.Parameters.AddWithValue("@mdp", motdepasse);
                        cmd.Parameters.AddWithValue("@mail", email.Text);
                        cmd.Parameters.AddWithValue("@date", date.Value);
                        cmd.Parameters.AddWithValue("@metier", metier.Text);
                        int w = cmd.ExecuteNonQuery();
                        con.Close();
                        if (w > 0)
                        {
                            MessageBox.Show("Votre compte a été bien créer , vous devez vous connecter pour y accéder ", "Succés");
                        }
                    }
                }
                else
                { if (tel == 0)
                    {
                        MessageBox.Show("Votre numero de telephone n'est pas valide ", " Erreur ");
                    }
                else if (!IsValidEmail(email.Text))
                    {

                        MessageBox.Show("Votre Email n'est pas valide ", " Erreur ");
                    }
                else if (count > 0)
                    {
                        MessageBox.Show("Username déja utilisé ", " Erreur ");

                    }
                else if (!IsPasswordValid(mdp.Text))
                    {
                        MessageBox.Show("mot de passe a une faible sécurité veuillé ", " Erreur ");

                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }
    }
}
