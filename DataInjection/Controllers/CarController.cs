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
        private CarService _carService { get; set; }

        public CarController()
        {
            _carService = new CarService();
        }

        public bool Insert()
        {
            return _carService.Insert();
        }
    }
}
