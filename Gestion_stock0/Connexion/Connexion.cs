using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Gestion_stock0
    
{
    
    
    

    public partial class Connexion : Form
    {
        private dbStockContext1 db;
        ClassConnexion c = new ClassConnexion();
        public Connexion()
        {
            
            InitializeComponent();
            db = new dbStockContext1();
            

        }
        string valider()
        {
            if(username.Text==""||username.Text == "Nom d'Utilisateur")
            {
                return "Veuillez saisir votre Nom d'Utilisateur";
            }
            if (mdp.Text == "" || mdp.Text == "Mot de Passe")
            {
                return "Veuillez saisir votre Mot de Passe";
            }
            return null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (username.Text == "Nom d'Utilisateur")
            {
                username.Text = "";
                username.ForeColor = Color.WhiteSmoke;
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (mdp.Text == "Mot de Passe")
            {
                mdp.Text = "";
                mdp.PasswordChar = '*';
                mdp.ForeColor = Color.WhiteSmoke;
                
            }
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (mdp.Text == "")
            {
                mdp.Text = "";
                mdp.UseSystemPasswordChar = true;
                mdp.ForeColor = Color.WhiteSmoke;
                
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Nom d'Utilisateur";
                username.ForeColor = Color.WhiteSmoke;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valider() == null)
            {
                if (c.ConnexionValide(db,username.Text,mdp.Text)==true)
                {
                    MessageBox.Show("valide"," Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f = new Form1(this);
                    f.Show();
                    this.Hide();
                   // GestionCommandes gc = new GestionCommandes();
                    //gc.Show();

                }
                else
                {
                    MessageBox.Show("Connexion a échoué", " Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(valider()," Connexion",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            //var users = from Utilisateur in bd.Utilisateur where Utilisateur.Pass_Word == mdp.Text && Utilisateur.Nom_User == username.Text select Utilisateur.Nom_User;
            // if (users.Any())
            // {
            //   msg.Text = "Connexion réussite";
            // }
            // else { msg.Text = "Connexion échouée! Veuillez réessayer!"; }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
