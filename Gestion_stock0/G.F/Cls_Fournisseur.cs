using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock0

{
    class Cls_Fournisseur
    {
        private dbStockContext1 db = new dbStockContext1();
        private Fournisseur F;

        public bool Ajouter_Fournisseur(String nom, String prenom, String Adresse, String tele, String mail, byte[] image)
        {
            F = new Fournisseur();
            F.Nom_Fournisseur = nom;
            F.Prenom_Fournisseur = prenom;
            F.Adresse_fournisseur = Adresse;
            F.Tele_Fournisseur = tele;
            F.Email_Fournisseur = mail;
            F.Logo_Fournisseur = image;
            if (db.Fournisseurs.SingleOrDefault(s => s.Nom_Fournisseur == nom && s.Prenom_Fournisseur == prenom) == null)
            {
                db.Fournisseurs.Add(F);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Modifier_Fournisseur(int IDF, String nom, String prenom, String Adresse, String tele, String mail, byte[] image)
        {
            F = new Fournisseur();
            F = db.Fournisseurs.SingleOrDefault(s => s.ID_FOURNISSEUR == IDF);
            if (F != null)
            {
                F.Nom_Fournisseur = nom;
                F.Prenom_Fournisseur = prenom;
                F.Adresse_fournisseur = Adresse;
                F.Tele_Fournisseur = tele;
                F.Email_Fournisseur = mail;
                F.Logo_Fournisseur = image;

                db.SaveChanges();
                
              return true;
        }
            else
            {
                return false;
            }


        }
        public void suppFournisseur(int id_F)
        {
            F = new Fournisseur();

            F = db.Fournisseurs.SingleOrDefault(s => s.ID_FOURNISSEUR == id_F);
            if (F != null)
            {
                db.Fournisseurs.Remove(F);
                db.SaveChanges();
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
    }
}
