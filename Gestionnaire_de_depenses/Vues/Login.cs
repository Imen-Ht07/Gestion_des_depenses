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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_depenses.Vues
{
    public partial class Login : Form
    {// ***BD ***
        // connection string, SqlConnection, SqlCommand, SqlDataAdapter, and a DataTable.
        string cs = ConfigurationManager.ConnectionStrings["datacon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public static string user;
            
        public string User { get => user; set => user = value; }

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
        public Login()
        {
            InitializeComponent();
        }
        private void connexion_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Mot_De_Passe = HashMotDePasseSHA256(textBox2.Text);
            using (con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Utilisateurs WHERE Username=@Username AND Mot_De_Passe=@Mot_De_Passe", con);
                cmd.Parameters.AddWithValue("@Username", Username.ToLower());
                cmd.Parameters.AddWithValue("@Mot_De_Passe", Mot_De_Passe);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    user = Username.ToLower();
                    accueil accueil = new accueil();
                    // Afficher la nouvelle fenêtre
                    accueil.Show();

                    // Masquer la fenêtre de connexion actuelle
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Accès refusé. Veuillez vérifier vos informations d'identification.");
                }
            }
        }

        private void inscri_Click(object sender, EventArgs e)
        {
            Inscription insc   = new Inscription();

            insc.Show();
            this.Hide();
        }

        
    }
    }
