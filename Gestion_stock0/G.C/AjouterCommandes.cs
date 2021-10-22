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

namespace Gestion_stock0
{
    public partial class AjouterCommandes : Form
    {
        UserControl user;
        private dbStockContext1 db;
        ClassCommande cc = new ClassCommande();
        public AjouterCommandes(UserControl u)
        {
            InitializeComponent();
            db = new dbStockContext1();
             this.user=u;

        }
        public string valider()
        {
            if (comboBox1.SelectedItem == null)
            {
                return "veuillez remplir le champs du fournisseur";
            }
            if (comboBox2.SelectedItem == null)
            {
                return "veuillez remplir le champs du produit";
            }
            if (textBox3.Text=="" || textBox3.Text == "Quantité")
            {
                return "veuillez remplir le champs quantité";
            }
            if (textBox4.Text == "" || textBox4.Text =="Prix grossiste")
            {
                return "veuillez remplir le champs prix";
            }
            if (DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value) > 0)
            {
                return "La date de demande ne peut être supérieure à la date d'arrivé! ";
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             comboBox2.Items.Clear();
            int idf = cc.idFournisseur(comboBox1.SelectedItem.ToString());
            foreach (Produit p in db.Produits)
            {
                if (p.ID_FOURNISSEUR == idf)
                {
                    comboBox2.Items.Add(p.Nom_Produit);
                }
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void AjouterCommandes_Load(object sender, EventArgs e)
        {
            foreach (Fournisseur f in db.Fournisseurs)
            {
                comboBox1.Items.Add( f.Nom_Fournisseur);
            }
            

        }
       
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        { int idp = cc.idProduit(comboBox2.SelectedItem.ToString());
            
                 foreach (Produit p in db.Produits)
            { 
                if (p.ID_PRODUIT == idp)
                {
                    if (p.Image_Produit != null)
                    {
                        MemoryStream ms = new MemoryStream(p.Image_Produit);

                        imgProd.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        imgProd.Image = System.Drawing.Image.FromFile(@"D:\ProjetCs\Logo\remove_image_40px.png");

                    }
;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Quantité")
            {
                textBox3.Text = "";
                

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text =="")
            {
                textBox3.Text = "Quantité";


            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Prix grossiste")
            {
                textBox4.Text = "";


            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Prix grossiste";


            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar ==8)
            {
                e.Handled = false;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (valider() != null)
            {
                MessageBox.Show(valider(), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            { int q = int.Parse(textBox3.Text);
              int p = int.Parse(textBox4.Text);
                DateTime d1 = dateTimePicker1.Value;
                DateTime d2 = dateTimePicker2.Value;
                int idp = cc.idProduit(comboBox2.SelectedItem.ToString());
                cc.ajouteCommande(idp,q,p,d1,d2);
                MessageBox.Show("Commande ajouté avec succes", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                (user as GestionCommandes).remplir();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
