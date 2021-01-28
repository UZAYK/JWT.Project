using Bussines.Interfaces;
using Bussines.StringInfos;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class JwtIdentityInitializer
    {
        public static async Task Seed(IAppUserService appUserService,
            IAppUserRoleService appUserRoleService, IAppRoleService appRoleService)
        {
            var adminRole = await appRoleService.FindByName(RoleInfo.Admin);
            if (adminRole == null)
            {
                await appRoleService.AddAsync(new Entities.Concrete.AppRole
                { Name = RoleInfo.Admin });
            }

            var memberRole = await appRoleService.FindByName(RoleInfo.Member);
            if (adminRole == null)
            {
                await appRoleService.AddAsync(new Entities.Concrete.AppRole
                { Name = RoleInfo.Member });
            }
            var adminUser = await appUserService.FindByUserName("Uzay");
            if (adminUser == null)
            {
                await appUserService.AddAsync(new AppUser
                {
                    FullName = "Uzay KAHRAMAN",
                    UserName = "Uzay",
                    Password = "1"

                });
                var role = await appRoleService.FindByName(RoleInfo.Admin);
                var admin = await appUserService.FindByUserName("Uzay");

                await appUserRoleService.AddAsync(new AppUserRole
                {
                    AppUserId = admin.Id,
                    AppRoleId = role.Id
                });
            }

        }
    }

}
