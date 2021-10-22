using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock0
{
    class Cls_Produit
    {

        private dbStockContext1 db = new dbStockContext1();
        private Produit P;
        public int id;
        public bool Ajouter_Produit(String nom, float prix, int fournisseur, DateTime date, int quantite, String statut, byte[] image)
        {
            P = new Produit();
            P.Nom_Produit = nom;
            P.Prix_Produit = prix;
            P.Quantite_Produit = quantite;
            P.Image_Produit = image;
            P.Statut = statut;
            P.ID_FOURNISSEUR = fournisseur;
            P.Date_exp = date;
            if (db.Produits.SingleOrDefault(s => s.Nom_Produit == nom ) == null)
            {
                db.Produits.Add(P);
                  db.SaveChanges();
                id = P.ID_PRODUIT;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modifier_Produit(int idP,String nom, float prix, int fournisseur,
            DateTime date, int quantite, String statut, byte[] image)
        {
            P = new Produit();
            P = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == idP) ;
            if (P != null)
            {
                 P.Nom_Produit = nom;
                P.Prix_Produit = prix;
                P.Quantite_Produit = quantite;
                P.Image_Produit = image;
                P.Statut = statut;
                P.ID_FOURNISSEUR = fournisseur;
                P.Date_exp = date;
                db.SaveChanges();
           
            return true;
        }
            else
            {
                return false;
            }
        }
       
        public int idFournisseur(String nom)
        {
            if (db.Fournisseurs.SingleOrDefault(s => s.Nom_Fournisseur == nom) != null)
            {
                int idf = db.Fournisseurs.SingleOrDefault(s => s.Nom_Fournisseur == nom).ID_FOURNISSEUR;
                return idf;
            }
            return 0;
        }
        public void suppProduit(int id_P)
        {
            P = new Produit();

            P = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == id_P);
            if (P != null)
            {
                db.Produits.Remove(P);
                db.SaveChanges();
            }
        }

        public int idProduit(string nom)
        {
            if (db.Produits.SingleOrDefault(s => s.Nom_Produit == nom) != null)
            {
                int idP = db.Produits.SingleOrDefault(s => s.Nom_Produit == nom).ID_PRODUIT;

                return idP;
            }
            return 0;
        }
        public string nomFournisseur(int id)
        {
            if (db.Fournisseurs.SingleOrDefault(s => s.ID_FOURNISSEUR == id).Nom_Fournisseur != null)
            {
                string nom = db.Fournisseurs.SingleOrDefault(s => s.ID_FOURNISSEUR == id).Nom_Fournisseur;

                return nom;
            }
            return null;
        }
        public int statut(string S)        {
            int i = 0;
            foreach (var s in db.Produits)
            {
                if (s.Statut == S)
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
        
    }
}
