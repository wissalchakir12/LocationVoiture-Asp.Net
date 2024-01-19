using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class UserAuthVM
	{
        public string Nom { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}
