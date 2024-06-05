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
    public class CarRepositories : ICarRepositories
    {
        private string _conn { get; set; }

        public CarRepositories()
        {
            _conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public List<Car> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                using var connection = new SqlConnection(_conn);
                connection.Open();
                return connection.Query<Car>(Car.GETALL).ToList();
            }
        }

        public bool Insert(Car car)
        {
            var result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();

                db.Execute("INSERT INTO Car (Plate, Name, ModelYear, ManufatureYear, Color) VALUES (@Plate, @Name, @ModelYear, @ManufatureYear, @Color)", car);

                result = true;

                db.Close();
            }

            return result;
        }
    }
}
