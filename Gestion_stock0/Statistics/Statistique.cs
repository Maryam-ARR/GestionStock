using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock0.Statistics
{
    public partial class Statistique : UserControl
    {
        dbStockContext1 db = new dbStockContext1();
        private static Statistique UserStatistic;
        public static Statistique Instance
        {
            get
            {
                if (UserStatistic == null)
                {
                    UserStatistic = new Statistique();
                }
                return UserStatistic;
            }
        }
        public Statistique()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        private void Statistique_Load(object sender, EventArgs e)
        {
            Produit();

        }
        private void Achat() { 
            chart1.Series["Quantite_vs_jour"].XValueMember = "Jour";
            chart1.Series["Quantite_vs_jour"].YValueMembers = "Achat";
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
           List<DateTime> date = new List<DateTime>();
            List<int> quantite = new List<int>();
            foreach (var s in db.Commandes){
                date.Add(s.Date_Arrive);}
            for (int j = 0; j < date.Count; j++) {
                for (int k = j + 1; k < date.Count; k++){
                    if (date[j].Equals(date[k])){
                        date.Remove(date[j]);
                        k--;} }}
            int varq = 0;
            List<Commande> v = new List<Commande>();
            foreach (var d in date) {
                var listvente = db.Commandes.Where(x => x.Date_Arrive == d);
                v = listvente.ToList();
                foreach (var p in v) {
                    varq = varq + p.Quantite_Commande;}
                quantite.Add(varq);
                varq = 0;}
            for (int u = 0; u < GestionCommandes.Instance.Date.Count; u++){
                int indice = 0;
                if (date.Contains(GestionCommandes.Instance.Date[u])){
                    indice = date.FindIndex(GestionCommandes.Instance.Date[u].Equals);
                    quantite[indice] = quantite[indice] + GestionCommandes.Instance.Quantite[u];
                }else {
                    date.Add(GestionCommandes.Instance.Date[u]);
                    quantite.Add(GestionCommandes.Instance.Quantite[u]);
                }}for (int u = 0; u < date.Count; u++){
                chart1.Series["Quantite_vs_jour"].Points.AddXY(date[u].ToShortDateString(),quantite[u]); }
        }
        private void Vente()
        {
            chart2.Series["Vente_vs_jour"].XValueMember = "Jour";
            chart2.Series["Vente_vs_jour"].YValueMembers = "Vente";
            chart2.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart2.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            List<DateTime> date = new List<DateTime>();
            List<int> quantite = new List<int>();
            foreach (var s in db.ventes)
            {
                date.Add(s.Date_Vente);
            }
            for (int j = 0; j < date.Count; j++)
            {
                for (int k = j + 1; k < date.Count; k++)
                {
                    if (date[j].Equals(date[k]))
                    {
                        date.Remove(date[j]);
                        k--;
                    }
                }
            }
            int varq = 0;
            List<vente> v = new List<vente>();
            foreach (var d in date)
            {
                var listvente = db.ventes.Where(x => x.Date_Vente == d);
                v = listvente.ToList();
                foreach (var p in v)
                {
                    varq = varq + p.Quantite_Vendu;
                }
                quantite.Add(varq);
                varq = 0;
            }
            for (int u = 0; u < date.Count; u++)
            {
                chart2.Series["Vente_vs_jour"].Points.AddXY(date[u].ToShortDateString(), quantite[u]);
            }
        }
        private void Gain()
        {
            chart3.Series["Gain_vs_jour"].XValueMember = "Jour";
            chart3.Series["Gain_vs_jour"].YValueMembers = "Gain";
            chart3.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart3.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            List<DateTime> date = new List<DateTime>();
            List<double> gain = new List<double>();
            foreach (var s in db.ventes)
            {
                date.Add(s.Date_Vente);
            }
            for (int j = 0; j < date.Count; j++)
            {
                for (int k = j + 1; k < date.Count; k++)
                {
                    if (date[j].Equals(date[k]))
                    {
                        date.Remove(date[j]);
                        k--;
                    }
                }
            }
            double varq = 0;
            List<vente> v = new List<vente>();
            foreach (var d in date)
            {
                var listvente = db.ventes.Where(x => x.Date_Vente == d);
                v = listvente.ToList();
                foreach (var p in v)
                {
                    double a = p.Produit.Prix_Produit;
                    varq = varq + p.Quantite_Vendu * (a);
                }
                gain.Add(varq);
                varq = 0;
            }
            for (int u = 0; u < date.Count; u++)
            {
                chart3.Series["Gain_vs_jour"].Points.AddXY(date[u].ToShortDateString(), gain[u]);
            }
        }
        private void Produit()
        {

            chart4.Series["Produit_vs_Name"].XValueMember = "Nom";
            chart4.Series["Produit_vs_Name"].YValueMembers = "Quantite";
            chart4.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart4.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            foreach (var p in db.Produits)
            {
 chart4.Series["Produit_vs_Name"].Points.AddXY(p.Nom_Produit, p.Quantite_Produit);
            }

        }
        static string getFullName(int month)
        {
            DateTime date = new DateTime(2020, month, 1);

            return date.ToString("MMMM");
        }
        private void Achat_Mois()
        {
            chart1.Series["Quantite_vs_jour"].XValueMember = "MOIS";
            chart1.Series["Quantite_vs_jour"].YValueMembers = "Achat";
            List<int> date = new List<int>();
            List<int> quantite = new List<int>();
            foreach (var s in db.Commandes)
            {
                date.Add(s.Date_Arrive.Month);
            }
            for (int j = 0; j < date.Count; j++)
            {
                for (int k = j + 1; k < date.Count; k++)
                {
                    if (date[j].Equals(date[k]))
                    {
                        date.Remove(date[j]);
                        k--;
                    }
                }
            }
            int varq = 0;
            List<Commande> v = new List<Commande>();
            foreach (var d in date)
            {
                var listvente = db.Commandes.Where(x => x.Date_Arrive.Month == d);
                v = listvente.ToList();
                foreach (var p in v)
                {
                    varq = varq + p.Quantite_Commande;
                }
                quantite.Add(varq);
                varq = 0;
            }
            for (int u = 0; u < GestionCommandes.Instance.Date.Count; u++)
            {
                int indice = 0;
                if (date.Contains(GestionCommandes.Instance.Date[u].Month))
                {
                    indice = date.FindIndex(GestionCommandes.Instance.Date[u].Month.Equals);
                    quantite[indice] = quantite[indice] + GestionCommandes.Instance.Quantite[u];
                }
                else
                {
                    date.Add(GestionCommandes.Instance.Date[u].Month);
                    quantite.Add(GestionCommandes.Instance.Quantite[u]);
                }
            }
            for (int u = 0; u < date.Count; u++)
            {
                chart1.Series["Quantite_vs_jour"].Points.AddXY(getFullName(date[u]), quantite[u]);
            }
        }
        private void Vente_Mois()
        {
            chart2.Series["Vente_vs_jour"].XValueMember = "MOIS";
            chart2.Series["Vente_vs_jour"].YValueMembers = "Vente";
            List<int> date = new List<int>();
            List<int> quantite = new List<int>();
            foreach (var s in db.ventes)
            {
                date.Add(s.Date_Vente.Month);
            }
            for (int j = 0; j < date.Count; j++)
            {
                for (int k = j + 1; k < date.Count; k++)
                {
                    if (date[j].Equals(date[k]))
                    {
                        date.Remove(date[j]);
                        k--;
                    }
                }
            }
            int varq = 0;
            List<vente> v = new List<vente>();
            foreach (var d in date)
            {
                var listvente = db.ventes.Where(x => x.Date_Vente.Month == d);
                v = listvente.ToList();
                foreach (var p in v)
                {
                    varq = varq + p.Quantite_Vendu;
                }
                quantite.Add(varq);
                varq = 0;
            }
            for (int u = 0; u < date.Count; u++)
            {
                chart2.Series["Vente_vs_jour"].Points.AddXY(getFullName(date[u]), quantite[u]);
            }

        }
        private void Gain_Mois()
        {
            chart3.Series["Gain_vs_jour"].XValueMember = "Mois";
            chart3.Series["Gain_vs_jour"].YValueMembers = "Gain";
            List<int> date = new List<int>();
            List<double> gain = new List<double>();
            foreach (var s in db.ventes)
            {
                date.Add(s.Date_Vente.Month);
            }
            for (int j = 0; j < date.Count; j++)
            {
                for (int k = j + 1; k < date.Count; k++)
                {
                    if (date[j].Equals(date[k]))
                    {
                        date.Remove(date[j]);
                        k--;
                    }
                }
            }
            double varq = 0;
            List<vente> v = new List<vente>();
            foreach (var d in date)
            {
                var listvente = db.ventes.Where(x => x.Date_Vente.Month == d);
                v = listvente.ToList();
                foreach (var p in v)
                {
                    double a = p.Produit.Prix_Produit;
                    varq = varq + p.Quantite_Vendu * (a);
                }
                gain.Add(varq);
                varq = 0;
            }
            for (int u = 0; u < date.Count; u++)
            {
                chart3.Series["Gain_vs_jour"].Points.AddXY(getFullName(date[u]), gain[u]);
            }
        }
        private void Achat_Annee()
        {
            chart1.Series["Quantite_vs_jour"].XValueMember = "Annee";
            chart1.Series["Quantite_vs_jour"].YValueMembers = "Achat";
            List<int> date = new List<int>();
            List<int> quantite = new List<int>();
            foreach (var s in db.Commandes)
            {
                date.Add(s.Date_Arrive.Year);
            }
            for (int j = 0; j < date.Count; j++)
            {
                for (int k = j + 1; k < date.Count; k++)
                {
                    if (date[j].Equals(date[k]))
                    {
                        date.Remove(date[j]);
                        k--;
                    }
                }
            }
            int varq = 0;
            List<Commande> v = new List<Commande>();
            foreach (var d in date)
            {
                var listvente = db.Commandes.Where(x => x.Date_Arrive.Year == d);
                v = listvente.ToList();
                foreach (var p in v)
                {
                    varq = varq + p.Quantite_Commande;
                }
                quantite.Add(varq);
                varq = 0;
            }


            for (int u = 0; u < GestionCommandes.Instance.Date.Count; u++)
            {
                int indice = 0;
                if (date.Contains(GestionCommandes.Instance.Date[u].Year))
                {
                    indice = date.FindIndex(GestionCommandes.Instance.Date[u].Year.Equals);
                    quantite[indice] = quantite[indice] + GestionCommandes.Instance.Quantite[u];
                }
                else
                {
                    date.Add(GestionCommandes.Instance.Date[u].Year);
                    quantite.Add(GestionCommandes.Instance.Quantite[u]);
                }
            }
            for (int u = 0; u < date.Count; u++)
            {
                chart1.Series["Quantite_vs_jour"].Points.AddXY(date[u], quantite[u]);
            }

        }
        private void Vente_Annee()
        {
            chart2.Series["Vente_vs_jour"].XValueMember = "Annee";
            chart2.Series["Vente_vs_jour"].YValueMembers = "Vente";
            List<int> date = new List<int>();
            List<int> quantite = new List<int>();
            foreach (var s in db.ventes)
            {
                date.Add(s.Date_Vente.Year);
            }
            for (int j = 0; j < date.Count; j++)
            {
                for (int k = j + 1; k < date.Count; k++)
                {
                    if (date[j].Equals(date[k]))
                    {
                        date.Remove(date[j]);
                        k--;
                    }
                }
            }
            int varq = 0;
            List<vente> v = new List<vente>();
            foreach (var d in date)
            {
                var listvente = db.ventes.Where(x => x.Date_Vente.Year == d);
                v = listvente.ToList();
                foreach (var p in v)
                {
                    varq = varq + p.Quantite_Vendu;
                }
                quantite.Add(varq);
                varq = 0;
            }
            for (int u = 0; u < date.Count; u++)
            {
                chart2.Series["Vente_vs_jour"].Points.AddXY(date[u], quantite[u]);
            }

        }
        private void Gain_Annee()

        {
            chart3.Series["Gain_vs_jour"].XValueMember = "Mois";
            chart3.Series["Gain_vs_jour"].YValueMembers = "Gain";
            List<int> date = new List<int>();
            List<double> gain = new List<double>();
            foreach (var s in db.ventes)
            {
                date.Add(s.Date_Vente.Year);
            }
            for (int j = 0; j < date.Count; j++)
            {
                for (int k = j + 1; k < date.Count; k++)
                {
                    if (date[j].Equals(date[k]))
                    {
                        date.Remove(date[j]);
                        k--;
                    }
                }
            }
            double varq = 0;
            List<vente> v = new List<vente>();
            foreach (var d in date)
            {
                var listvente = db.ventes.Where(x => x.Date_Vente.Year == d);
                v = listvente.ToList();
                foreach (var p in v)
                {
                    double a = p.Produit.Prix_Produit;
                    varq = varq + p.Quantite_Vendu * (a);
                }
                gain.Add(varq);
                varq = 0;
            }
            for (int u = 0; u < date.Count; u++)
            {
                chart3.Series["Gain_vs_jour"].Points.AddXY(date[u], gain[u]);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                chart1.Series["Quantite_vs_jour"].Points.Clear();
                Achat();
                chart2.Series["Vente_vs_jour"].Points.Clear();
                Vente();
                chart3.Series["Gain_vs_jour"].Points.Clear();
                Gain();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                chart1.Series["Quantite_vs_jour"].Points.Clear();
                Achat_Mois();
                chart2.Series["Vente_vs_jour"].Points.Clear();
                Vente_Mois();
                chart3.Series["Gain_vs_jour"].Points.Clear();
                Gain_Mois();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                chart1.Series["Quantite_vs_jour"].Points.Clear();
                Achat_Annee();
                chart2.Series["Vente_vs_jour"].Points.Clear();
                Vente_Annee();
                chart3.Series["Gain_vs_jour"].Points.Clear();
                Gain_Annee();
            }
        }

        private void Actualiser_Click(object sender, EventArgs e)
        {
            chart1.Series["Quantite_vs_jour"].Points.Clear();
            Achat();
            chart2.Series["Vente_vs_jour"].Points.Clear();
            Vente();
            chart3.Series["Gain_vs_jour"].Points.Clear();
            Gain();
        }
    }
}