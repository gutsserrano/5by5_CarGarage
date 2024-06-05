using Microsoft.Data.SqlClient;
using Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarInjectionRepository : ICarInjectionRepository
    {
        private string _conn { get; set; }

        public CarInjectionRepository()
        {
            _conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool insert(List<Car> cars)
        {
            int result;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();

                result = db.Execute("INSERT INTO Car (Plate, Name, ModelYear, ManufatureYear, Color) VALUES (@Plate, @Name, @ModelYear, @ManufatureYear, @Color)", cars);

                db.Close();
            }

            return result > 0;
        }
    }
}
