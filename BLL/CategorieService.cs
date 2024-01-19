using DAL.Repos;
using Models;
using DAL.Entity;
using Microsoft.Identity.Client;

namespace BLL

{
    public class CategorieService
    {
        public List<Models.CategorieVM> ListVM()
        {
            var categorieRepos = new CategorieRepos();
            List<CategorieVM> repostomodel = new List<CategorieVM>();
            
            foreach(var vm in categorieRepos.All()) 
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
            CategorieRepos cat = new CategorieRepos();
            Categorie categorie = new Categorie
            {
                Name = item.Name,
                Description = item.Description,
                Image = item.Image,
                ID = item.Id
			};
			cat.Create(categorie);
        }


		public void UpdateCategorie(CategorieVM item)
		{
			CategorieRepos cat = new CategorieRepos();
			Categorie categorie = new Categorie
			{
				Name = item.Name,
				Description = item.Description,
				Image = item.Image
			};
			cat.Update(categorie);
		}


		public void SupprimerCategorie(int id)
		{
			CategorieRepos categorieRepos = new CategorieRepos();
			categorieRepos.Delete(id);
		}


        public CategorieVM GetCategorie(int id)
        {
            CategorieRepos cat = new CategorieRepos();
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
	}
}