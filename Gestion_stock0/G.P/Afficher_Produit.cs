using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock0
{
    public partial class Afficher_Produit : Form
    {
        int id;
        Produit P;
        private dbStockContext1 db = new dbStockContext1();
       
        public Afficher_Produit(int id)
        {
            InitializeComponent();
            this.id = id;
            P = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Afficher_Produit_Load(object sender, EventArgs e)
        {
            P = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == id);
            if (P != null)
            {
                foreach (Fournisseur f in db.Fournisseurs)
                {
                    comboBox1.Items.Add(f.Nom_Fournisseur);
                }

                Fournisseur F = db.Fournisseurs.SingleOrDefault(s => s.ID_FOURNISSEUR == P.ID_FOURNISSEUR);
                comboBox1.SelectedItem = F.Nom_Fournisseur;
                txtNom.Text = P.Nom_Produit.ToString();
                txtquantite.Text = P.Quantite_Produit.ToString();
                txtPrix.Text = P.Prix_Produit.ToString();
                dateEXP.Value = P.Date_exp;
                MemoryStream MS = new MemoryStream(P.Image_Produit);

                pictureBox1.Image = Image.FromStream(MS);
            }
        }
    }
}
