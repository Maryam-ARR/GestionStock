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
    public partial class Afficher_Fournisseur : Form
    {
        int id;
        Fournisseur f;
        private dbStockContext1 db = new dbStockContext1();
        public Afficher_Fournisseur(int id)
        {
            InitializeComponent();
            this.id = id;
            f = db.Fournisseurs.SingleOrDefault(s => s.ID_FOURNISSEUR == id);
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Afficher_Fournisseur_Load(object sender, EventArgs e)
        {

            f = db.Fournisseurs.SingleOrDefault(s => s.ID_FOURNISSEUR == id);
            if (f != null)
            {
                txtNom.Text = f.Nom_Fournisseur.ToString();
                txtPrenom.Text = f.Prenom_Fournisseur.ToString();
                txtAddresse.Text = f.Adresse_fournisseur.ToString();
                txtTele.Text = f.Tele_Fournisseur.ToString();
                txtMail.Text = f.Email_Fournisseur.ToString();

                MemoryStream MS = new MemoryStream(f.Logo_Fournisseur);

                pictureBox1.Image = Image.FromStream(MS);
            }
        }
    }
}
