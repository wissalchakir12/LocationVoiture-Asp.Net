using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}
