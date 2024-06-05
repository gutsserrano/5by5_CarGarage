using Models;
using Newtonsoft.Json;
using Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarService
    {
        private ICarRepository _carRepository;
        private readonly string path = "../../../../../Reports/";
        private readonly string file = "carJson.json";

        public CarService()
        {
            _carRepository = new CarRepositry(path, file);
        }

        public bool InsertCar(List<Car> cars)
        {
            return _carRepository.InsertCar(JsonConvert.SerializeObject(cars));
        }
    }
}
