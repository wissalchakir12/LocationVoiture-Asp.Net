using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Repos
{
    public class VoitureRepos
    {
        static MyDbContext db = new MyDbContext();
        public List<Voiture> All()
        {
            return db.Voitures.ToList();
        }
        /// <summary>
        /// voiture par id
        /// </summary>
        public Voiture Read(int id)
        {
            return db.Voitures.Find(id);
        }

        public void Create(Voiture voiture) 
        {
            db.Voitures.Add(voiture);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Remove(db.Voitures.Find(id));
            db.SaveChanges() ;
        }

        public void Update(Voiture voiture)
        {
            db.Update(voiture);
            db.SaveChanges() ;
        }

        public Voiture Get(int Id)
        {
            return db.Voitures.Find(Id);
        }
    }
    
}
