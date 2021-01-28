using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Interfaces
{
   public interface IJwtService
    {
        string GenerateJwt(AppUser appUser, List<AppRole> roles);

    }
}
