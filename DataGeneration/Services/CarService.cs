using Models;
using Newtonsoft.Json;
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
        private ICarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepositry("../../../../Reports/", "carJson.txt");
        }

        public bool InsertCar(Car car)
        {
            return _carRepository.InsertCar(JsonConvert.SerializeObject(car));
        }
    }
}
