using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategorieRepos
    {
        static MyDbContext db = new MyDbContext();
        public List<Categorie> All()
        {
            return db.Categories.ToList();
        }

        public void Create(Categorie categorie)
        {
            db.Categories.Add(categorie);
            db.SaveChanges();
        }
    }
}
