using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

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

       
        public void Delete(int id)
        {
            Categorie cat = db.Categories.Find(id);

            if (cat != null)
                {
				db.Categories.Remove(cat);
                db.SaveChanges();
			}
            
        }
       
        public Categorie Get(int id) 
        {
            Categorie categorie = db.Categories.Find(id);
            return categorie;
        }

        public void Update(Categorie categorie)
        {
            db.Categories.Attach(categorie);
            db.Categories.Entry(categorie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

    }
}
