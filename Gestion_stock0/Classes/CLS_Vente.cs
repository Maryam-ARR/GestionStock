using Gestion_stock0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock0
{
    class CLS_Vente
    {
        public dbStockContext1 db = new dbStockContext1();
        public vente v;

        public void Ajouter_Vente(int id,int qty, DateTime d)
        {
                 v = new vente();
                 v.ID_PRODUIT = id;
                 v.Quantite_Vendu = qty;
                 v.Date_Vente = d;
                 db.ventes.Add(v);
                 db.SaveChanges();
        }
    }
}
