using Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Services
{
    public class CarService
    {
        private ICarInjectionRepository _carInjectionRepository { get; set; }

        public CarService()
        {
            _carInjectionRepository = new CarInjectionRepository();
        }

        public bool Insert()
        {
            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(Car.PATH + Car.FILE));
            return _carInjectionRepository.insert(cars);
        }
    }
}
