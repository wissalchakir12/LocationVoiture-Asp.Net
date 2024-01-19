using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
	public class Auth
	{
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
