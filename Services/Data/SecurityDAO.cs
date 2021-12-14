using BondMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BondMovies.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(UserModel user)
        {
            if (user.Username == "Admin" && user.Password == "Secret")
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }
    }
}