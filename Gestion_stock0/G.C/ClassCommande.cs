using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock0
{
    class ClassCommande
    {
       private dbStockContext1 db = new dbStockContext1();
        private Commande c;
        public int id;
        public void ajouteCommande( int id_produit,int quantité, int prix_gros,DateTime date_demande,DateTime date_arrive)
        {
            c = new Commande();
            
                c.ID_PRODUIT = id_produit;
                c.Quantite_Commande = quantité;
                c.Prix_Grossiste = prix_gros;
                c.Date_Demande = date_demande;
                c.Date_Arrive = date_arrive;
                db.Commandes.Add(c);
                db.SaveChanges();
                id = c.ID_COMMANDE;
            
            
        }
        public void suppCommande(int id_commande)
        {
            c = new Commande();

            c = db.Commandes.SingleOrDefault(s => s.ID_COMMANDE == id_commande);
            if (c != null)
            {
                db.Commandes.Remove(c);
                db.SaveChanges();
            }
        }
        public int idFournisseur(string nom)
        {
            if (db.Fournisseurs.SingleOrDefault(s => s.Nom_Fournisseur == nom) != null)
            {
                int idf = db.Fournisseurs.SingleOrDefault(s => s.Nom_Fournisseur == nom).ID_FOURNISSEUR;

                return idf;
            }
            return 0;
        }
        public int CommandeDemande(DateTime demande)
        {
            int i = 0;
            foreach (var x in db.Commandes)
            {
                if (x.Date_Demande.Date == demande)
                {
                    i++;
                }
            }
            if (i!=0)
            {

                return i;
            }
            return 0;
        }
        public int CommandeArrivee(DateTime demande)
        {
            int i = 0;
            foreach (var x in db.Commandes)
            {
                if (x.Date_Arrive.Date == demande)
                {
                    i++;
                }
            }
            if (i != 0)
            {

                return i;
            }
            return 0;
        }
        public int idProduit(string nom)
        {
            if (db.Produits.SingleOrDefault(s => s.Nom_Produit == nom) != null)
            {
                int idp = db.Produits.SingleOrDefault(s => s.Nom_Produit == nom).ID_PRODUIT;
                return idp;
            }
            return 0;
        }
        public string nomProduit(int id)
        {
            if (db.Produits.SingleOrDefault(s => s.ID_PRODUIT == id).Nom_Produit != null)
            {
                string nom = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == id).Nom_Produit;

                return nom;
            }
            return null;
        }
        public void modifierCommande(int id_com,int id_produit, int quantité, int prix_gros, DateTime date_demande, DateTime date_arrive)
        {
            c = new Commande();
            c = db.Commandes.SingleOrDefault(s => s.ID_COMMANDE == id_com);
            if (c != null)
            {
                c.ID_PRODUIT = id_produit;
                c.Quantite_Commande = quantité;
                c.Prix_Grossiste = prix_gros;
                c.Date_Demande = date_demande;
                c.Date_Arrive = date_arrive;
                db.SaveChanges();
            }
        }
        public void modifierStatut(Produit p,string statut,int q)
        {
            Produit p1 = new Produit();
            p1 = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == p.ID_PRODUIT);

            if (p1 != null)
            {
                p1.Statut = statut;
                p1.Quantite_Produit = p1.Quantite_Produit + q;
                db.SaveChanges();
            }
        }
    }
}
