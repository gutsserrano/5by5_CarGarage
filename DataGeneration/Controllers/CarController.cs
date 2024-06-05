using Services;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CarController
    {
        private CarService _carService;

        public CarController()
        {
            _carService = new CarService();
        }

        public bool InsertCar(List<Car> cars)
        {
            return _carService.InsertCar(cars);
        }
    }
}
