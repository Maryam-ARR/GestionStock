using Gestion_stock0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock0
{
    class CLS_Produit
    {
        private dbStockContext1 db = new dbStockContext1();
        private Produit p;
        //fonction pour vendre un produit
        public bool Vendre(int qty, int id)
        {
            p = db.Produits.SingleOrDefault(s => s.ID_PRODUIT == id);
            if (p != null && p.Quantite_Produit>=qty)
            {
                p.Quantite_Produit = p.Quantite_Produit - qty;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
