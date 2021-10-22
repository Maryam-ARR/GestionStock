using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Gestion_stock0
{
    public partial class Fournisseurs : UserControl
    {
        Cls_Fournisseur CF = new Cls_Fournisseur();
        private static Fournisseurs G_Fournisseur;
        private dbStockContext1 db =new dbStockContext1();
        public static Fournisseurs Instance
        {
            get
            {
                if (G_Fournisseur == null)
                {
                    G_Fournisseur = new Fournisseurs();
                }
                return G_Fournisseur;
            }
        }
        public Fournisseurs()
        {
            InitializeComponent();
            db = new dbStockContext1();
            ActualiserDataGrid();
        }
      
        public void ActualiserDataGrid() {
            db = new dbStockContext1();
            ListeFournisseur.Rows.Clear();
            foreach (var f in db.Fournisseurs) {
                ListeFournisseur.Rows.Add(false,f.ID_FOURNISSEUR,f.Nom_Fournisseur,f.Prenom_Fournisseur,
                    f.Adresse_fournisseur,f.Tele_Fournisseur,f.Email_Fournisseur);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
               if (!Form1.Instance.PnlContainer.Controls.Contains(GestionCommandes.Instance))
            {
       Form1.Instance.PnlContainer.Controls.Add(GestionCommandes.Instance);
               GestionCommandes.Instance.Dock = DockStyle.Fill;
               GestionCommandes.Instance.BringToFront();
            }
            else
            {
                GestionCommandes.Instance.BringToFront();
            }
              }
        
        
        private void btnAjouterF_Click(object sender, EventArgs e)
        {
            Ajouter_Frounisseur f = new Ajouter_Frounisseur(this);
            f.Show();
            ActualiserDataGrid();
        }

        private void txtChercher_Enter(object sender, EventArgs e)
        {
            if (txtChercher.Text=="Recherche") {
                txtChercher.Text = "";
                txtChercher.ForeColor = Color.Black;
            }
        }

        private void btnModifierP_Click(object sender, EventArgs e)
        {
            Fournisseur F = new Fournisseur();
            int select = 0;
            for (int i = 0; i < ListeFournisseur.Rows.Count; i++)
            {
                if ((bool)ListeFournisseur.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun fournisseur n'est selectionnée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                    for (int i = 0; i < ListeFournisseur.Rows.Count; i++)
                    {
                        if ((bool)ListeFournisseur.Rows[i].Cells[0].Value == true)
                        {
                        Modifier_fournisseur MF = new Modifier_fournisseur(int.Parse(ListeFournisseur.Rows[i].Cells[1].Value.ToString()), this);
                            MF.Show();
                        }
                    }
                ActualiserDataGrid();
            }
        }
        private void Fournisseurs_Load(object sender, EventArgs e)
        {
            ActualiserDataGrid();
        }

        private void btnSupprimerP_Click(object sender, EventArgs e)
        {
            int select = 0;
            for (int i = 0; i < ListeFournisseur.Rows.Count; i++)
            {
                if ((bool)ListeFournisseur.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun fournisseur n'est selectionnée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
            else
            {
                DialogResult r =
              MessageBox.Show("Etes vous sure de vouloir supprimer!!", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i < ListeFournisseur.Rows.Count ; i++)
                    {
                        if ((bool)ListeFournisseur.Rows[i].Cells[0].Value == true)
                        {
                            CF.suppFournisseur(int.Parse(ListeFournisseur.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    
                    MessageBox.Show("Supprimé avec succès!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualiserDataGrid();
                }
                else
                {
                    MessageBox.Show("Suppression annulée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListeFournisseur.Rows.Clear();
            if (txtChercher.Text == "" || txtChercher.Text == "Recherche")
            {
    MessageBox.Show(" veuillez saisir votre recherche!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (CF.idFournisseur(txtChercher.Text) != 0)
                {
                    int idf = CF.idFournisseur(txtChercher.Text);
                    foreach (var f in db.Fournisseurs)
                    {
                        Fournisseur F = db.Fournisseurs.Find(f.ID_FOURNISSEUR);
                        if (F.ID_FOURNISSEUR == idf)
                        {
                            ListeFournisseur.Rows.Add(false, f.ID_FOURNISSEUR, f.Nom_Fournisseur, f.Prenom_Fournisseur, f.Adresse_fournisseur, f.Tele_Fournisseur, f.Email_Fournisseur);
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Auncun résultat trouvé!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtChercher_Leave(object sender, EventArgs e)
        {
            if (txtChercher.Text == "")
            {
                txtChercher.Text = "Recherche";
                txtChercher.ForeColor = Color.DarkGray;
            }
        }

        private void ListeFournisseur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                Afficher_Fournisseur AF = new Afficher_Fournisseur(int.Parse(ListeFournisseur.Rows[e.RowIndex].Cells[1].Value.ToString()));
                AF.Show();

        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ActualiserDataGrid();
            
            txtChercher.Text = "Recherche";
            txtChercher.ForeColor = Color.DarkGray;
        }

        private void btnCommander_Click(object sender, EventArgs e)
            {
         if (!Fournisseurs.Instance.Controls.Contains(GestionCommandes.Instance))
         {
             Fournisseurs.Instance.Controls.Add(GestionCommandes.Instance);
             GestionCommandes.Instance.Dock = DockStyle.Fill;
             GestionCommandes.Instance.BringToFront();
         }
         else
         {
             GestionCommandes.Instance.BringToFront();
         }

    }

        private void ListeFournisseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
