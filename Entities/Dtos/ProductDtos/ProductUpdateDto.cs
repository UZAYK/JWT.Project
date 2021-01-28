using Entities.Dtos.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.ProductDtos
{
   public class ProductUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
