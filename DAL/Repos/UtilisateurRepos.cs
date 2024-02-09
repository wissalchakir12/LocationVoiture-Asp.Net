using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UtilisateurRepos
    {
        static MyDbContext db = new MyDbContext();
        public List<Utilisateur> All()
        {
            return db.Utilisateurs.ToList();
        }
    }
}
