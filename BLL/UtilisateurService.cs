using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repos;

namespace BLL
{
    public class UtilisateurService
    {
        static UtilisateurRepos utilisateurRepos = new UtilisateurRepos();
        public List<AuthVM> ListVM()
        {
            List<AuthVM> list = new List<AuthVM>();
            foreach (var item in utilisateurRepos.All())
            {
                AuthVM vm = new AuthVM();
                vm.Email = item.Email;
                vm.PassWord = item.PassWord;
                vm.KeepLoggedIn = item.KeepLoggedIn;
                list.Add(vm);
            }
            return list;
        }

    }
}
