using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Collections;

namespace Gestion_stock0
{
    public partial class GestionVentes : UserControl
    {
        public dbStockContext1 db;
        CLS_Produit pd=new CLS_Produit();
        CLS_Vente V = new CLS_Vente();
       // Produit p = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == tab[x]);
        int[] tab;//tableau qui stock les ids des produits disponnible
        
        private static GestionVentes UserVente;
       
        //-----------------------------USER CONTROL---------------------
        public static GestionVentes Instance
        {
            get
            {
                if (UserVente == null)
                {
                    UserVente = new GestionVentes();
                }
                return UserVente;
            }
        }
        public GestionVentes()
        {
            InitializeComponent();
            db = new dbStockContext1();
            tab = new int[db.Produits.Count()];
            Actualisergrid();


        }
        public void Actualisergrid()
        {
             
            db = new dbStockContext1();
            tab = new int[db.Produits.Count()];
            dataGridView1.Rows.Clear();
            int i = 0;
            if (db.Produits.Count() != 0)
            {
                foreach (var x in db.Produits)
                {
                    if (x.Quantite_Produit>0)
                    {
                        dataGridView1.Rows.Add(false, x.Nom_Produit, x.Prix_Produit, x.Date_exp);
                        tab[i] = x.ID_PRODUIT;
                        i++;
                    }
                }
            }
        }
        public string SelectVerif()
        {
            int selected = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                    selected++;
                }
            }
            if (selected == 0)
            {
                return "Aucun produit est selectionnee!";
            }
            else if(selected > 1)
            {
                return "Choisir un seul produit!";
            }
            return null;
        }

        //-----------------------Event Click OF GRIDVIEW------------------------

        private void button1_Click(object sender, EventArgs e)//Vendre
        {
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                    {
                        int qt = Convert.ToInt32(txtQuantite.Value);
                        int x = dataGridView1.CurrentCell.RowIndex;
                        if (qt <= 0)
                        {
                            MessageBox.Show("Entrer la quantité que vous voullez");
                        }
                        else if(pd.Vendre(qt, tab[x])==true)
                        {
                            V.Ajouter_Vente(tab[x],qt,dateTimePicker1.Value);
                            MessageBox.Show("Le produit est vendue avec succes", "Vendre produit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }else if(pd.Vendre(qt, tab[x]) == false)
                        {
                            MessageBox.Show("La quantité deppase le stock","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }
                Actualisergrid();
                txtQuantite.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
                
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtQuantite.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            Actualisergrid();
        }

        private void GestionVentes_Load(object sender, EventArgs e)
        {
            Actualisergrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
