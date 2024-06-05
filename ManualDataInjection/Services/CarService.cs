using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarService
    {
        private ICarRepositories _carRepositories;

        public CarService()
        {
            _carRepositories = new CarRepositories();
        }

        public bool Insert(Car car)
        {
            return _carRepositories.Insert(car);
        }

        public List<Car> GetAll()
        {
            return _carRepositories.GetAll();
        }
    }
}
