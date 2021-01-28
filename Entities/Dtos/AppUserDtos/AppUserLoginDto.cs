using Entities.Dtos.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.AppUserDtos
{
   public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
