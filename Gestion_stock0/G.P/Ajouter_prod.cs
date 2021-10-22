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
    public partial class Ajouter_prod : Form
    {
        Cls_Produit CP = new Cls_Produit();

        UserControl user;
        public Ajouter_prod(UserControl u)
        {
            InitializeComponent();
            this.user = u;
          
        }
        dbStockContext1 db =new dbStockContext1();
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
        private void btnEnrg_Click(object sender, EventArgs e)
        {
            if (Test() != null)
            {
                MessageBox.Show(Test(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            { 
                MemoryStream MS = new MemoryStream();
                pictureBox1.Image.Save(MS, pictureBox1.Image.RawFormat);
                byte[] byteimageP = MS.ToArray();
                int q = int.Parse(txtquantite.Text);
                float p = float.Parse(txtPrix.Text);
                string n = txtNom.Text.ToString();
                string s;
                DateTime d = dateEXP.Value;
                int f = CP.idFournisseur(comboBox1.SelectedItem.ToString());
                if (q > 1) { s = "disponible"; }
                else { s = "non disponible"; }
               
                CP.Ajouter_Produit(n,p,f,d,q,s, byteimageP);
                MessageBox.Show("Produit ajouté avec succes", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                (user as ProduitD).ActualiserDataGrid();
                this.Close();

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
        OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";
        if (OP.ShowDialog() == DialogResult.OK)
        {
            pictureBox1.Image = Image.FromFile(OP.FileName);
        }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
           

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom ")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom ";
                txtNom.ForeColor = Color.DarkGray;
            }
        }

        private void txtPrix_Enter(object sender, EventArgs e)
        {
            if (txtPrix.Text == "Prix")
            {
                txtPrix.Text = "";
                txtPrix.ForeColor = Color.Black;
            }
        }

        private void txtPrix_Leave(object sender, EventArgs e)
        {
            if (txtPrix.Text == "")
            {
                txtPrix.Text = "Prix";
                txtPrix.ForeColor = Color.DarkGray;
            }
        }

        private void txtquantite_Enter(object sender, EventArgs e)
        {
            if (txtquantite.Text == "Quantité")
            {
                txtquantite.Text = "";
                txtquantite.ForeColor = Color.Black;
            }
        }

        private void txtquantite_Leave(object sender, EventArgs e)
        {
            if (txtquantite.Text == "")
            {
                txtquantite.Text = "Quantité";
                txtquantite.ForeColor = Color.DarkGray;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtquantite.Text = "Quantité";
            txtquantite.ForeColor = Color.DarkGray;

            txtPrix.Text = "Prix";
            txtPrix.ForeColor = Color.DarkGray;

            txtquantite.Text = "Quantité";
            txtquantite.ForeColor = Color.DarkGray;

            txtNom.Text = "Nom";
            txtNom.ForeColor = Color.DarkGray;
        }

        private void txtquantite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Ajouter_prod_Load(object sender, EventArgs e)
        {
            foreach (Fournisseur f in db.Fournisseurs)
            {
                comboBox1.Items.Add(f.Nom_Fournisseur);
            }
        }
    }
}
 