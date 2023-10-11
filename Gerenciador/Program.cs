using Classes.Models;
Estacionamento estacionamento = new(2);

string menu =
    "O que deseja fazer no estacionamento?\n" +
    "1 - Estacionar \n" +
    "2 - Remover carro \n" +
    "3 - Mostrar todos os carros";
do
{
    try
    {
        Console.Clear();
        Console.WriteLine(menu);
        int escolha = Convert.ToInt32(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Digite o modelo do carro: ");
                string? modelo = Console.ReadLine();
                Console.WriteLine("Digite a marca do carro: ");
                string? marca = Console.ReadLine();
                Console.WriteLine("Digite a placa do carro: ");
                string? placa = Console.ReadLine();
                Console.WriteLine("Digite a cor do carro: ");
                string? cor = Console.ReadLine();
                Console.WriteLine("Digite o ano do carro: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                Carro novoCarro = new(modelo, marca, placa, cor, ano);
                estacionamento.Estacionar(novoCarro);
                break;
            case 2:
                Console.WriteLine();
                break;
            case 3:
                estacionamento.MostrarCarros();
                break;
            default:
                Console.WriteLine("Valor não disponível!");
                continue;
        }
    }
    catch (System.Exception e)
    {

        throw new Exception(e.Message);
    }
} while (true);
