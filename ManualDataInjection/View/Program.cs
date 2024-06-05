using Controllers;
using Models;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertCar();
            CarController controller = new();
            foreach (var item in controller.GetAll())
            {
                Console.WriteLine($"Placa: {item.Plate}, Carro: {item.Name}");
            }
        }

        static void InsertCar()
        {
            string plate = LerString("Digite a placa do carro: ");
            string name = LerString("Digite o nome do carro: ");
            int modelYear = LerInt("Digite o ano do modelo do carro: ");
            int manufactureYear = LerInt("Digite o ano de fabricação do carro: ");
            string color = LerString("Digite a cor do carro: ");

            CarController controller = new();
            Car car = new()
            {
                Plate = plate,
                Name = name,
                ModelYear = modelYear,
                ManufatureYear = manufactureYear,
                Color = color
            };

            if (controller.Insert(car))
            {
                Console.WriteLine("Carro inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha ao Inserir Carro");
            }
        }

        static string LerString(string msg)
        {
            string result = string.Empty;
            do
            {
                Console.WriteLine(msg);
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("\nValor invalido, digite novamente!\n");
                }

            } while (string.IsNullOrEmpty(result));

            return result;
        }

        static int LerInt(string msg)
        {
            int result;
            bool conversao;

            do
            {
                Console.WriteLine(msg);
                conversao = int.TryParse(Console.ReadLine(), out result);
                if (!conversao)
                {
                    Console.WriteLine("\nValor invalido, digite novamente!\n");
                }

            } while (!conversao);

            return result;
        }
    }
}
