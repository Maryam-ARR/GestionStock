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
    public partial class ProduitD : UserControl
    {
        Cls_Produit CP = new Cls_Produit();
        private dbStockContext1 db ;
        public ProduitD()
        {
            InitializeComponent();
            db = new dbStockContext1();
            ActualiserDataGrid();
        }

      

        private static ProduitD G_produit;

        public static ProduitD Instance {
            get { if (G_produit == null)
                {
                    G_produit = new ProduitD();
                }
                return G_produit;
            }
        }

        public void ActualiserDataGrid()
        {
            db = new dbStockContext1();
            
            ListeProduit.Rows.Clear();
            foreach (var P in db.Produits)
            {
                Fournisseur F = db.Fournisseurs.Find(P.ID_FOURNISSEUR);
                if (P.Date_exp < DateTime.Now) {
                    P.Statut = "non disponible";
                }
                
                ListeProduit.Rows.Add(false, P.ID_PRODUIT, P.Nom_Produit, P.Prix_Produit,P.Date_exp,
                   F.Nom_Fournisseur, P.Quantite_Produit,P.Statut);
                
            }
        }
        private void btnAjouterP_Click(object sender, EventArgs e)
        {
            Ajouter_prod x = new Ajouter_prod(this);
            x.Show();
        }
        private void btnModifierP_Click(object sender, EventArgs e)
        {
            Produit P= new Produit();
            int select = 0;
            for (int i = 0; i < ListeProduit.Rows.Count; i++)
            {
                if ((bool)ListeProduit.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun produit n'est selectionnée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
               
                for (int i = 0; i < ListeProduit.Rows.Count; i++)
                {
                    if ((bool)ListeProduit.Rows[i].Cells[0].Value == true)
                    {
                        Modifier_Prod MP = new Modifier_Prod(int.Parse(ListeProduit.Rows[i].Cells[1].Value.ToString()),this);
                        MP.ShowDialog();

                    }
                }
                ActualiserDataGrid();

            }
           
        }

        private void txtChercher_Enter(object sender, EventArgs e)
        {
            if (txtChercher.Text == "Recherche")
            {
                txtChercher.Text = "";
                txtChercher.ForeColor = Color.Black;
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

        private void btnChercher_Click(object sender, EventArgs e)
        {
            if (txtChercher.Text == "" || txtChercher.Text == "Recherche")
            {
                MessageBox.Show(" veuillez saisir votre recherche!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListeProduit.Rows.Clear();
                if (CP.idProduit(txtChercher.Text) != 0)
                {
                    int idP = CP.idProduit(txtChercher.Text);
                    foreach (var P in db.Produits)
                    {
                        
                        if (P.ID_PRODUIT == idP)
                        {
                            Fournisseur F = db.Fournisseurs.Find(P.ID_FOURNISSEUR);
                            ListeProduit.Rows.Add(false, P.ID_PRODUIT,P.Nom_Produit,P.Prix_Produit,F.Nom_Fournisseur,P.Date_exp,P.Quantite_Produit,P.Statut);
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Auncun résultat trouvé!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupprimerP_Click(object sender, EventArgs e)
        {
            int select = 0;
            for (int i = 0; i < ListeProduit.Rows.Count; i++)
            {
                if ((bool)ListeProduit.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun produit n'est selectionnée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
            else
            {
                DialogResult r =
              MessageBox.Show("Etes vous sure de vouloir supprimer!!", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i < ListeProduit.Rows.Count; i++)
                    {
                        if ((bool)ListeProduit.Rows[i].Cells[0].Value == true)
                        {
                            CP.suppProduit(int.Parse(ListeProduit.Rows[i].Cells[1].Value.ToString()));
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

        private void ProduitD_Load(object sender, EventArgs e)
        {
           
            ActualiserDataGrid();

            
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            ListeProduit.Rows.Clear();
            if (comboBox1.SelectedItem.ToString() == "Liste des produits disponible")
            {

                if (CP.statut("disponible") != 0)
                {
                    foreach (var P in db.Produits)
                    {

                        if (P.Statut == "disponible")
                        {
                            Fournisseur F = db.Fournisseurs.Find(P.ID_FOURNISSEUR);
                            ListeProduit.Rows.Add(false, P.ID_PRODUIT, P.Nom_Produit, P.Prix_Produit, F.Nom_Fournisseur, P.Date_exp, P.Quantite_Produit, P.Statut);
                        }


                    }
                }
                else
                { MessageBox.Show("Auncun résultat trouvé!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else if (comboBox1.SelectedItem.ToString() == "Liste des produits non disponible")
            {

                if (CP.statut("non disponible") != 0)
                {
                    foreach (var P in db.Produits)
                    {

                        if (P.Statut == "non disponible")
                        {
                            Fournisseur F = db.Fournisseurs.Find(P.ID_FOURNISSEUR);
                            ListeProduit.Rows.Add(false, P.ID_PRODUIT, P.Nom_Produit, P.Prix_Produit, F.Nom_Fournisseur, P.Date_exp, P.Quantite_Produit, P.Statut);
                        }


                    }
                }
                else
                    MessageBox.Show("Auncun résultat trouvé!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (comboBox1.SelectedItem.ToString() == "Liste des produits déstockés")
            {


                foreach (var P in db.Produits)
                {

                    if (P.Date_exp < DateTime.Today)
                    {

                        Fournisseur F = db.Fournisseurs.Find(P.ID_FOURNISSEUR);
                        ListeProduit.Rows.Add(false, P.ID_PRODUIT, P.Nom_Produit, P.Prix_Produit, F.Nom_Fournisseur, P.Date_exp, P.Quantite_Produit, P.Statut);

                    }


                }

            }
            else { MessageBox.Show("Auncun choix n'est sélectionné!!", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ActualiserDataGrid();
            comboBox1.Text = "Veuillez choisir une liste à afficher";
            
                txtChercher.Text = "Recherche";
                txtChercher.ForeColor = Color.DarkGray;
            
        }

        private void ListeProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                Afficher_Produit AF = new Afficher_Produit(int.Parse(ListeProduit.Rows[e.RowIndex].Cells[1].Value.ToString()));
                  AF.ShowDialog();
           
        }
    }
}
