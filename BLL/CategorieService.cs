using DAL.Repos;
using Models;
using DAL.Entity;
using Microsoft.Identity.Client;

namespace BLL

{
    public class CategorieService
    {
		static CategorieRepos cat = new CategorieRepos();
		public List<Models.CategorieVM> ListVM()
        {
            
            List<CategorieVM> repostomodel = new List<CategorieVM>();
            
            foreach(var vm in cat.All()) 
            {
                CategorieVM item = new CategorieVM();
                item.Name = vm.Name;
                item.Description = vm.Description;
                item.Image = vm.Image;
                item.Id = vm.ID;
                repostomodel.Add(item);
            }

            return repostomodel;
        } 
        public void AddCategorie(CategorieVM item)
        {
            
            Categorie categorie = new Categorie
            {
                Name = item.Name,
                Description = item.Description,
                Image = item.Image,
                ID = item.Id
			};
			cat.Create(categorie);
        }


		public void SupprimerCategorie(int id)
		{
			cat.Delete(id);
		}
        

        public CategorieVM GetCategorie(int id)
        {
            Categorie data =  cat.Get(id);
            CategorieVM ret = new CategorieVM()
            {
                Id = data.ID,
                Name = data.Name,
                Description = data.Description,
                Image = data.Image,
            };
            return ret;

        }
        public void UpdateCategorie(CategorieVM item)
		{

            Categorie categorie = cat.Get(item.Id);
            categorie.Name = item.Name;
            categorie.Description = item.Description;
            categorie.Image = item.Image; 
			cat.Update(categorie);
		}
	}
}