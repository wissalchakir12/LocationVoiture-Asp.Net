using DAL.Repos;
using Models;
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
    }
}