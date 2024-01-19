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
    }
    
}
