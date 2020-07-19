using DemoCacheRedis.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoAuthJWT.Repositories
{
    public class CarRepository
    {
        public static IList<Car> Cars = new List<Car>
        {

            new Car
            {
                Id = Guid.NewGuid(),
                Model = "Ferrari 812",
                Year = 2019
            },

            new Car
            {
                Id = Guid.NewGuid(),
                Model = "Ferrari F8",
                Year = 2020
            },

            new Car
            {
                Id = Guid.NewGuid(),
                Model = "Mercedes AMG GT",
                Year = 2020
            },

            new Car
            {
                Id = Guid.NewGuid(),
                Model = "Mercedes CLS",
                Year = 2020
            },

            new Car
            {
                Id = Guid.NewGuid(),
                Model = "Ford Mustang GT",
                Year = 2021
            },

            new Car
            {
                Id = Guid.NewGuid(),
                Model = "Ford Mustang Shelby",
                Year = 2020
            },
        };


        public IList<Car> GetAll()
        {
            return Cars;
        }

        public IList<Car> GetByCurrent()
        {
            return Cars.Where(x => x.Year == DateTime.Now.Year).ToList();
        }
    }
}
