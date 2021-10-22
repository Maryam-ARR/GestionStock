using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace Gestion_stock0
{
    public partial class Ajouter_Frounisseur : Form
    {
        UserControl user;
        public Ajouter_Frounisseur(UserControl user)
        {
            InitializeComponent();
            this.user = user;
        }

        

        private void Ajouter_Frounisseur_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        string Test()
        {
            if (txtNom.Text == "" || txtNom.Text == "Nom Entreprise") {
                return "Entrez le nom de l'entreprise du fournisseur";
            }
            if (txtPrenom.Text == "" || txtPrenom.Text == "Nom Personne")
            {
                return "Entrez le nom du fournisseur";
            }

            if (txtAddresse.Text == "" || txtAddresse.Text == "Adresse")
            {
                return "Entrez l'adresse du fournisseur";
            }
            if (txtTele.Text == "" || txtTele.Text == "Téléphone")
            {
                return "Entrez le téléphone du fournisseur";
            }
            if (txtMail.Text == "" || txtMail.Text == "E-mail")
            {
                return "Entrez l'E-mail du fournisseur";
            }
            if (pictureBox1.Image==null )
            {
                return "Entrez le Logo du fournisseur";
            }
             else {
                 try
                 {
                     new MailAddress(txtMail.Text);
                 }
                 catch(Exception e) {
                     return "E-mail invalide";
                 }

             }

            return null;
        }
        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom Entreprise")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }
        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom Entreprise";
                txtNom.ForeColor = Color.DarkGray;
            }
        }
        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Nom Personne")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.Black;
            }
        }
        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Nom Personne";
                txtPrenom.ForeColor = Color.DarkGray;
            }
        }
        private void txtAddresse_Enter(object sender, EventArgs e)
        {
            if (txtAddresse.Text == "Adresse")
            {
                txtAddresse.Text = "";
                txtAddresse.ForeColor = Color.Black;
            }
        }
        private void txtAddresse_Leave(object sender, EventArgs e)
        {
            if (txtAddresse.Text == "")
            {
                txtAddresse.Text = "Adresse";
                txtAddresse.ForeColor = Color.DarkGray;
            }
        }
        private void txtTele_Enter(object sender, EventArgs e)
        {
            if (txtTele.Text == "Téléphone")
            {
                txtTele.Text = "";
                txtTele.ForeColor = Color.Black;
            }
        }
        private void txtTele_Leave(object sender, EventArgs e)
        {
            if (txtTele.Text == "")
            {
                txtTele.Text = "Téléphone";
                txtTele.ForeColor = Color.DarkGray;
            }
        }
        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "E-mail")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.Black;
            }
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "E-mail";
                txtMail.ForeColor = Color.DarkGray;
            }
        }
        private void txtTele_KeyPress_1(object sender, KeyPressEventArgs e)
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

    private void btnEnrg_Click(object sender, EventArgs e)
    {
        if (Test() != null)
        {
            MessageBox.Show(Test(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            Cls_Fournisseur fournisser = new Cls_Fournisseur();
            MemoryStream MS = new MemoryStream();
            pictureBox1.Image.Save(MS, pictureBox1.Image.RawFormat);
            byte[] byteimageF = MS.ToArray();
            if (fournisser.Ajouter_Fournisseur(txtNom.Text.ToString(), txtPrenom.Text.ToString(),
                txtAddresse.Text.ToString(), txtTele.Text.ToString(), txtMail.Text.ToString(), byteimageF) == true)
            {
                MessageBox.Show("Fournisseur ajouter avec succes.. ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (user as Fournisseurs).ActualiserDataGrid();
                    Close();
                }
            else {
                MessageBox.Show("Fournisseur Existe dejà !!! ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


    private void btnParcourir_Click(object sender, EventArgs e)
    {
        OpenFileDialog OP = new OpenFileDialog();
        OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";
        if (OP.ShowDialog() == DialogResult.OK)
        {
            pictureBox1.Image = Image.FromFile(OP.FileName);
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e)
    {
        txtNom.Text = "Nom Entreprise";
        txtNom.ForeColor = Color.DarkGray;

        txtPrenom.Text = "Nom Personne";
        txtPrenom.ForeColor = Color.DarkGray;

        txtAddresse.Text = "Adresse";
        txtAddresse.ForeColor = Color.DarkGray;

        txtTele.Text = "Téléphone";
        txtTele.ForeColor = Color.DarkGray;

        txtMail.Text = "E-mail";
        txtMail.ForeColor = Color.DarkGray;
        pictureBox1.Image = null;
    }

}  
}
