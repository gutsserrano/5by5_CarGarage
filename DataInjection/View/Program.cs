using Controllers;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarController controller = new CarController();

            if (controller.Insert())
            {
                Console.WriteLine("Dados inseridos com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha ao inserir dados!");
            }

        }
    }
}
