using DemoCacheRedis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAuthJWT.Repositories
{
    public class BrandRepository
    {
        public static IList<Brand> Brands = new List<Brand>
        {

            new Brand
            {
                Id = Guid.NewGuid(),
                Name = "Ferrari",
                Country = "Itália"
            },

             new Brand
            {
                Id = Guid.NewGuid(),
                Name = "Ford",
                Country = "Estados Unidos"
            },

             new Brand
            {
                Id = Guid.NewGuid(),
                Name = "Mercedes",
                Country = "Alemanha"
            },
        };


        public IList<Brand> GetAll()
        {
            return Brands;
        }
    }
}
