using Models;
using Newtonsoft.Json;
using Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarService
    {
        private ICarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepositry(Car.PATH, Car.FILE);
        }

        public bool InsertCar(List<Car> cars)
        {
            return _carRepository.InsertCar(JsonConvert.SerializeObject(cars));
        }
    }
}
