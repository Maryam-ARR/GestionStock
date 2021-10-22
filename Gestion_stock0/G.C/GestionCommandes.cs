using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.IO;

namespace Gestion_stock0
{
    public partial class GestionCommandes : UserControl
    {
        private dbStockContext1 db;
        ClassCommande cc = new ClassCommande();
        DateTime thisDay = DateTime.Today;
        List<DateTime> date = new List<DateTime>();
        List<int> quantite = new List<int>();
        private static GestionCommandes UserCommande;

        public List<DateTime> Date
        {
            get { return date; }
            set { date = value; }
        }
        public List<int> Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public GestionCommandes()
        {
            InitializeComponent();
            db = new dbStockContext1();
        }

        /* public Panel pnlContainer
         {
             get {GestionCommand }
             set { }
         }*/
        public static GestionCommandes Instance
        {
            get
            {
                if (UserCommande == null)
                {
                    UserCommande = new GestionCommandes();


                }
                return UserCommande;
            }
        }
        public void remplir()
        {
            db = new dbStockContext1();
            dataGridView1.Rows.Clear();
            foreach (var x in db.Commandes)
            {
                Produit p = db.Produits.Find(x.ID_PRODUIT);
                if (x.Date_Arrive.Date != thisDay.Date)
                {

                    dataGridView1.Rows.Add(false, x.ID_COMMANDE, p.Nom_Produit, x.Quantite_Commande,
                        x.Prix_Grossiste, x.Date_Demande, x.Date_Arrive, x.Prix_Grossiste * x.Quantite_Commande);
                }
                else
                {
                    cc.modifierStatut(p, "disponible", x.Quantite_Commande);
                    date.Add(x.Date_Arrive);
                    quantite.Add(x.Quantite_Commande);
                    cc.suppCommande(x.ID_COMMANDE);

                }
            }
        }
        private void GestionCommande_Load_1(object sender, EventArgs e)
        {
            remplir();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ActualiserDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var c in db.Commandes)
            {
                dataGridView1.Rows.Add(false, c.ID_COMMANDE, c.Produit.Nom_Produit, c.Quantite_Commande,
                    c.Prix_Grossiste, c.Date_Demande, c.Date_Arrive, c.Prix_Grossiste * c.Quantite_Commande);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AjouterCommandes x = new AjouterCommandes(this);
            x.Show();

        }


        private void button5_Click(object sender, EventArgs e)
        {
            int select = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucunne commande n'est selectionnée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult r =
MessageBox.Show("Etes vous sure de vouloir supprimer!", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                        {
                            cc.suppCommande(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    remplir();
                    MessageBox.Show("Supprimé avec succès!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Suppression annulée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int select = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucunne commande n'est selectionnée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                    {
                        ModifierCommandes x = new ModifierCommandes(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()), this);
                        x.Show();

                        
                    }
                   

                }
                remplir();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Recherche")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Recherche";
            }

        }
        public string valider()
        {
            if (comboBox1.SelectedItem == null)
            {
                return " veuillez choisir une catégorie!";

            }
            if (textBox1.Text == "" || textBox1.Text == "Recherche")
            {
                return " veuillez saisir votre recherche!";

            }
            return null;
        }
        public void remplirRecherche()
        {
            dataGridView1.Rows.Clear();
            if (comboBox1.SelectedItem.ToString() == "Nom du produit")
            {
                if (cc.idProduit(textBox1.Text) != 0)
                {
                    int idp = cc.idProduit(textBox1.Text);
                    foreach (var x in db.Commandes)
                    {
                        if (x.ID_PRODUIT == idp)
                        {
                            Produit p = db.Produits.Find(x.ID_PRODUIT);
                            dataGridView1.Rows.Add(false, x.ID_COMMANDE, p.Nom_Produit, x.Quantite_Commande,
                            x.Prix_Grossiste, x.Date_Demande, x.Date_Arrive, x.Prix_Grossiste * x.Quantite_Commande);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Auncun résultat trouvé!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Nom du Fournisseur")
            {
                if (cc.idFournisseur(textBox1.Text) != 0)
                {
                    int idf = cc.idFournisseur(textBox1.Text);
                    foreach (var x in db.Commandes)
                    {
                        Produit p = db.Produits.Find(x.ID_PRODUIT);
                        if (p.ID_FOURNISSEUR == idf)
                        {
                            dataGridView1.Rows.Add(false, x.ID_COMMANDE, p.Nom_Produit, x.Quantite_Commande,
                                x.Prix_Grossiste, x.Date_Demande, x.Date_Arrive, x.Prix_Grossiste * x.Quantite_Commande);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Auncun résultat trouvé!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Date de demande")
            {
                if (cc.CommandeDemande(dateTimePicker1.Value.Date) != 0)
                {
                    foreach (var x in db.Commandes)
                    {
                        if (x.Date_Demande.Date == dateTimePicker1.Value.Date)
                        {
                            Produit p = db.Produits.Find(x.ID_PRODUIT);
                            dataGridView1.Rows.Add(false, x.ID_COMMANDE, p.Nom_Produit, x.Quantite_Commande, x.Prix_Grossiste,
                       x.Date_Demande, x.Date_Arrive, x.Prix_Grossiste * x.Quantite_Commande);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Auncun résultat trouvé!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Date d'arrivée")
            {
                if (cc.CommandeArrivee(dateTimePicker1.Value.Date) != 0)
                {
                    foreach (var x in db.Commandes)
                    {
                        if (x.Date_Arrive.Date == dateTimePicker1.Value.Date)
                        {
                            Produit p = db.Produits.Find(x.ID_PRODUIT);
                            dataGridView1.Rows.Add(false, x.ID_COMMANDE, p.Nom_Produit, x.Quantite_Commande,
                    x.Prix_Grossiste, x.Date_Demande, x.Date_Arrive, x.Prix_Grossiste * x.Quantite_Commande);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Auncun résultat trouvé!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valider() != null)
            {
                MessageBox.Show(valider(), "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                remplirRecherche();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remplir();
            comboBox1.Text = "Veuillez choisir une catégorie";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Date de demande" || comboBox1.SelectedItem.ToString() == "Date d'arrivée")
            {
                textBox1.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                textBox1.Visible = true;
                dateTimePicker1.Visible = false;
                textBox1.Text = "Recherche";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (Fournisseurs.Instance.Controls.Contains(GestionCommandes.Instance))
            {
                Fournisseurs.Instance.Controls.Remove(GestionCommandes.Instance);
               
            }
            else
            {
                Fournisseurs.Instance.BringToFront();
            }
        }
    
    }
}
