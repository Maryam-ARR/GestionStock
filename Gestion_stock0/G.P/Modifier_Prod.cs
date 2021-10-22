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
    public partial class Modifier_Prod : Form
    {
        dbStockContext1 db = new dbStockContext1();
        Cls_Produit CP = new Cls_Produit();
        int id;
        UserControl user;
        Produit P;
        public Modifier_Prod(int id,UserControl u)
        {
            InitializeComponent();
            this.id = id;
            this.user = u;
            P = db.Produits.SingleOrDefault(s => s.ID_FOURNISSEUR == id);
           
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        string Test()
        {
            if (txtNom.Text == "" || txtNom.Text == "Nom")
            {
                return "Entrez le nom du Produit !!";
            }
            if (txtPrix.Text == "" || txtPrix.Text == "Prix")
            {
                return "Entrez le prix du produit !!";
            }


            if (comboBox1.SelectedItem == null)
            {
                return "veuillez remplir le champs du fournisseur !!";
            }

            if (txtquantite.Text == "" || txtquantite.Text == "Quantité")
            {
                return "Entrez la Quantité du produit !!";
            }
            if (pictureBox1.Image == null)
            {
                return "Entrez la photo du produit !!";
            }

            return null;
        }
        String statut;
        private void btnEnrg_Click(object sender, EventArgs e)
        {
            if (Test() != null)
            {
                MessageBox.Show(Test(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { ProduitD P = new ProduitD();
                Cls_Produit produit = new Cls_Produit();
                MemoryStream MS = new MemoryStream();
                pictureBox1.Image.Save(MS, pictureBox1.Image.RawFormat);
                byte[] byteimageP = MS.ToArray();
                DialogResult DR = MessageBox.Show("Voulez vous Modifier ?!", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    
                    if (int.Parse(txtquantite.Text.ToString()) > 0)
                    {
                        statut = "disponible";

                    }
                    else statut = "non disponible";

                    if (produit.Modifier_Produit(id, txtNom.Text.ToString(), float.Parse(txtPrix.Text.ToString()),
                         CP.idFournisseur(comboBox1.SelectedItem.ToString()), dateEXP.Value, int.Parse(txtquantite.Text.ToString()), statut, byteimageP))
                    {
                        MessageBox.Show("Produit modifier avec succes.. ", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (user as ProduitD).ActualiserDataGrid();
                        Close();
                    }
                    else { MessageBox.Show("On n'a pas pu modifier!!! ", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Modification Annuler !!! ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }



            }
        }

        private void Modifier_Prod_Load(object sender, EventArgs e)
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

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";
            if (OP.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OP.FileName);
            }
        }
    }
}
