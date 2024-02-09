using DAL.Entity;
using DAL.Repos;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VoitureService
    {

        public List<VoitureVM> ListVoiture(int idCategorie)
        {
            VoitureRepos cat=new VoitureRepos();
            List<VoitureVM> l=new List<VoitureVM>();
            foreach(var item in cat.All().Where(a=>a.CategorieId==idCategorie))
            {
                VoitureVM v=new VoitureVM();
                v.Id=item.Id;
                v.Name=item.Name;
                v.Description=item.Description;
                v.Image = item.Image;
                v.CategorieId = item.CategorieId;
                l.Add(v);
                

            }
            return l;
        }
        
        public VoitureVM DetailVoiture(int id)
        {
            VoitureVM obj = new VoitureVM();
            Voiture src = new VoitureRepos().Read(id);
            obj.Id=src.Id;
            obj.Name=src.Name;
            obj.Description=src.Description;
            obj.Image = src.Image;
            obj.CategorieId=src.CategorieId;
            obj.Est_Dispo = src.EstDispo;
            obj.Prix = src.Prix;
            
            return obj;
        }

        public void Create(VoitureVM voiture)
        {
            VoitureRepos voitureRepos = new VoitureRepos();
            Voiture voiture1 = new Voiture
            {
                Id = voiture.Id,
                Name = voiture.Name,
                Description = voiture.Description,
                CategorieId = voiture.CategorieId,
                Image = voiture.Image
            };
            voitureRepos.Create(voiture1);
        }

        public void Delete(int Id)
        {
            VoitureRepos voitureRepos=new VoitureRepos();
            voitureRepos.Delete(Id);
        }

        public void Update(VoitureVM voiture)
        {
            VoitureRepos voitureRepos = new VoitureRepos();
            Voiture voiture1 = voitureRepos.Get(voiture.Id);
            if (voiture1 != null)
            {
                voiture1.Prix = voiture.Prix;
                voiture1.EstDispo = voiture.Est_Dispo;
                voiture1.Description = voiture.Description;
                voiture1.Image = voiture.Image;
                voiture1.Name = voiture.Name;
                voitureRepos.Update(voiture1);
            }
           
        }

        public VoitureVM Get(int Id)
        {
            VoitureRepos voitureRepos = new VoitureRepos();
            Voiture rep = voitureRepos.Get(Id);
            VoitureVM v = new VoitureVM();
            v.Id = Id;
            v.Name = rep.Name;
            v.Description = rep.Description;
            v.Image = rep.Image;
            v.Est_Dispo = rep.EstDispo;
            v.CategorieId = rep.CategorieId;
            return v;
        }

    }
}
