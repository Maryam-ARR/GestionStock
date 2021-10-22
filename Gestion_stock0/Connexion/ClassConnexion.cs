using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock0
{
    class ClassConnexion
    {
        public Boolean ConnexionValide(dbStockContext1 db, string nom, string mdp)
        {
            Utilisateur u = new Utilisateur();
            u.Nom_User = nom;
            u.Pass_Word = mdp;
            if(db.Utilisateurs.SingleOrDefault(s=>s.Nom_User==nom && s.Pass_Word == mdp)!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
