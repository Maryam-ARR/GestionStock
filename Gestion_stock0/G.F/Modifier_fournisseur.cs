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
    public partial class Modifier_fournisseur : Form
    {
        int id; 
        Fournisseur f;
        UserControl user;
        private dbStockContext1 db ;
        public Modifier_fournisseur(int id,UserControl u)
        {
            InitializeComponent();
            db = new dbStockContext1();
            this.id = id;
            this.user = u;
            f = db.Fournisseurs.SingleOrDefault(s => s.ID_FOURNISSEUR == id); 
           
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string Test()
        {
            if (txtNom.Text == "" || txtNom.Text == "Nom")
            {
                return "Entrez le nom du fournisseur";
            }
            if (txtPrenom.Text == "" || txtPrenom.Text == "Prenom")
            {
                return "Entrez le prenom du fournisseur";
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
            if (pictureBox1.Image == null)
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
      
        private void btnEnrg_Click(object sender, EventArgs e)
        {
            if (Test() != null)
            {
                MessageBox.Show(Test(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {Cls_Fournisseur fournisser = new Cls_Fournisseur();
                MemoryStream MS = new MemoryStream();
                pictureBox1.Image.Save(MS, pictureBox1.Image.RawFormat);
                byte[] byteimageF = MS.ToArray();
                DialogResult DR = MessageBox.Show("Voulez vous Modifier ?!","Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    if (fournisser.Modifier_Fournisseur(id, txtNom.Text.ToString(), txtPrenom.Text.ToString(),
                         txtAddresse.Text.ToString(), txtTele.Text.ToString(), txtMail.Text.ToString(), byteimageF))
                    {
                        MessageBox.Show("Fournisseur modifier avec succes.. ", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (user as Fournisseurs).ActualiserDataGrid();
                        Close();
                    }
                    else { MessageBox.Show("On n'a pas pu modifier!!! ", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                }
                else {
                    MessageBox.Show("Modification Annuler !!! ", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void txtTele_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Modifier_fournisseur_Load(object sender, EventArgs e)
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
