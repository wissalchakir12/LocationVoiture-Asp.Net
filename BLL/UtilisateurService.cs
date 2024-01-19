using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;
using Models;

namespace BLL
	
{

	/// <summary>
	/// La création d'une session pour un utilisateur existant et retourne null pour un user non existant
	/// </summary>
	public class UtilisateurService
	{
		public Session? VerifierCompte(UserAuthVM user)
		{
			UtilisateurRepos us = new UtilisateurRepos();
			
			
				var Result=us.All().Where(a => a.Password == user.Password && a.Email == user.Email)
						.FirstOrDefault();
			if (us != null)
			{
				Session session = new Session();
				session.Email= user.Email;
				session.Password= user.Password;
				return session;

			}
			return null;

				
			
				

				


			
		}
		

	}
}
