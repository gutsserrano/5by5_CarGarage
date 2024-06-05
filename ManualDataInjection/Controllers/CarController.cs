using Models;
using Services;
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

        public bool Insert(Car car)
        {
            return _carService.Insert(car);
        }

        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }
    }
}
