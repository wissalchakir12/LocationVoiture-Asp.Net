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
    }
}
