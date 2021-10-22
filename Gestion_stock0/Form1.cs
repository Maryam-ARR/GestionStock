using Gestion_stock0;
using Gestion_stock0.Statistics;
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
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get {
                if (_obj == null) {
                    _obj = new Form1();
                }return _obj;
            }
        }
       
        public Panel PnlContainer
        {
            get { return panel6; }
            set { panel6 = value; }
        }
        
        
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnStatics.Height;
            SidePanel.Top = btnStatics.Top;
        }
        Connexion c;
        public Form1(Connexion c)
        {
            this.c = c;
            InitializeComponent();
            SidePanel.Height = btnStatics.Height;
            SidePanel.Top = btnStatics.Top;
        }

        private void btnStatics_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnStatics.Height;
            SidePanel.Top = btnStatics.Top;
            if (!panel6.Controls.Contains(Statistique.Instance))
            {
                panel6.Controls.Add(Statistique.Instance);
                Statistique.Instance.Dock = DockStyle.Fill;
                Statistique.Instance.BringToFront();
            }
            else
            {
                Statistique.Instance.BringToFront();
            }
        }

        private void btnGProduit_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGProduit.Height;
            SidePanel.Top = btnGProduit.Top;
            if (!panel6.Controls.Contains(ProduitD.Instance))
            {
                panel6.Controls.Add(ProduitD.Instance);
                ProduitD.Instance.Dock = DockStyle.Fill;
                ProduitD.Instance.BringToFront();
            }
            else { ProduitD.Instance.BringToFront(); }
            ProduitD.Instance.ActualiserDataGrid();

        }

        private void btnGVentes_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGVentes.Height;
            SidePanel.Top = btnGVentes.Top;
            if (!panel6.Controls.Contains(GestionVentes.Instance))
            {
                panel6.Controls.Add(GestionVentes.Instance);
                GestionVentes.Instance.Dock = DockStyle.Fill;
                GestionVentes.Instance.BringToFront();
            }
            else
            {
                GestionVentes.Instance.BringToFront();
            }
            GestionVentes.Instance.Actualisergrid();

        }

        private void btnGFournisseurs_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGFournisseurs.Height;
            SidePanel.Top = btnGFournisseurs.Top;
          if (!panel6.Controls.Contains(Fournisseurs.Instance))
           {
                panel6.Controls.Add(Fournisseurs.Instance);
                Fournisseurs.Instance.Dock = DockStyle.Fill;
                Fournisseurs.Instance.BringToFront();
           }
           else { Fournisseurs.Instance.BringToFront(); }
        }

        private void btnImpression_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnImpression.Height;
            SidePanel.Top = btnImpression.Top;
            try
            {
                string filename = null;
                SaveFileDialog SaveTxt = new SaveFileDialog();
                SaveTxt.Filter = "TXT files|* .txt";
                SaveTxt.FileName = "GestionStock.txt";
                if (SaveTxt.ShowDialog() == DialogResult.OK)
                {
                    filename = SaveTxt.FileName;
                }
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    FileInfo fileInfo = new FileInfo(filename);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("/--Fichier texte qui resume l'application Gestion de Stock | {0}----/", DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString());
                    sb.AppendLine("");
                    sb.AppendLine("************DATA*************");
                    sb.AppendLine("__________________________");

                    using (dbStockContext1 db = new dbStockContext1())
                    {
                        sb.AppendLine("---------Produits--------");
                        foreach (var x in db.Produits)
                        {
                            sb.AppendFormat("ID     :{0} \n", x.ID_PRODUIT);
                            sb.AppendFormat("Nom     :{0} \n", x.Nom_Produit);
                            sb.AppendFormat("Prix     :{0} \n", x.Prix_Produit);
                            sb.AppendFormat("Quantite     :{0} \n", x.Quantite_Produit);
                            sb.AppendFormat("Fournisseur     :{0}\n", x.Fournisseur.Nom_Fournisseur);
                            sb.AppendFormat("Status     :{0}\n", x.Statut);
                            sb.AppendLine("");
                            sb.AppendLine("---------------------");
                        }
                        sb.AppendLine("--------Fournisseurs---------");
                        foreach (var x in db.Fournisseurs)
                        {
                            sb.AppendFormat("ID     :{0}\n", x.ID_FOURNISSEUR);
                            sb.AppendFormat("Nom     :{0}\n", x.Nom_Fournisseur);
                            sb.AppendFormat("Prix     :{0}\n", x.Adresse_fournisseur);
                            sb.AppendFormat("Quantite     :{0}\n", x.Tele_Fournisseur);
                            sb.AppendFormat("Fournisseur     :{0}\n", x.Tele_Fournisseur);
                            sb.AppendLine("");
                            sb.AppendLine("---------------------");
                        }

                        sb.AppendLine("-----------Commandes---------");

                        foreach (var x in db.Commandes)
                        {
                            sb.AppendFormat("ID     :{0}\n", x.ID_COMMANDE);
                            sb.AppendFormat("Produit     :{0}\n", x.Produit.Nom_Produit);
                            sb.AppendFormat("Date du demande     :{0}\n", x.Date_Demande);
                            sb.AppendFormat("Date d'arrivee     :{0}\n", x.Date_Arrive);
                            sb.AppendLine("");
                            sb.AppendLine("---------------------");
                        }
                        sb.AppendLine("------------Ventes---------");
                        foreach (var x in db.ventes)
                        {
                            sb.AppendFormat("ID     :{0}\n", x.ID_VENTE);
                            sb.AppendFormat("Produit     :{0}\n", x.Produit.Nom_Produit);
                            sb.AppendFormat("Date du vente    :{0}\n", x.Date_Vente);
                            sb.AppendLine("");
                            sb.AppendLine("---------------------");
                        }
                        sb.AppendLine("______________________");
                        sb.AppendLine("*******************END*****************");
                        sw.Write(sb.ToString());
                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Export to TXT Error");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            
            c.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btnStatics.Height;
            SidePanel.Top = btnStatics.Top;
            if (!panel6.Controls.Contains(Statistique.Instance))
            {
                panel6.Controls.Add(Statistique.Instance);
                Statistique.Instance.Dock = DockStyle.Fill;
                Statistique.Instance.BringToFront();
            }
            else
            {
                Statistique.Instance.BringToFront();
            }
        }
    }
}
