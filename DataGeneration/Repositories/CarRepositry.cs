using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarRepositry : ICarRepository
    {
        private string Path { get; set; }
        private string FilePath { get; set; }

        public CarRepositry(string path, string file)
        {
            this.Path = path;
            this.FilePath = file;

            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            if (!File.Exists(Path + FilePath))
            {
                var aux = File.Create(Path + FilePath);
                aux.Close();
            }
        }

        public bool InsertCar(string carJson)
        {
            try
            {
                using (var sw = new StreamWriter(Path + FilePath))
                {
                    sw.WriteLine(carJson);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
