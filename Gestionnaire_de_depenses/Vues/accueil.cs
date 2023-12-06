using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_depenses.Vues
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
            Check_month();
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
        private void button5_Click(object sender, EventArgs e)
        {
            Gestion_de_transactions gt = new Gestion_de_transactions();
            gt.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Consulter_Budget a = new Consulter_Budget();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tirelire a = new Tirelire();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }
    }
}
