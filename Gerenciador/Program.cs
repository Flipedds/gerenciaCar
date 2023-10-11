using Classes.Models;

string menu =
    "O que deseja fazer no estacionamento?\n" +
    "1 - Estacionar \n" +
    "2 - Remover carro \n" +
    "3 - Mostrar todos os carros \n" +
    "4 - Encerrar";

bool loop = true;
Console.WriteLine("Qual o valor cobrado por horas estacionado? Exemplo: 4,00 ");
decimal valorCobradoPorHorasEstacionado = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Quantas vagas tem o estacionamento? ");
int quantidadeDeVagasDoEstacionamento = Convert.ToInt32(Console.ReadLine());
Estacionamento estacionamento = new(quantidadeDeVagasDoEstacionamento, valorCobradoPorHorasEstacionado);

while(loop)
{
    try
    {
        Thread.Sleep(5000);
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

                if (modelo != null &&
                    marca != null &&
                    placa != null &&
                    cor != null)
                {
                    Carro novoCarro = new(modelo, marca, placa, cor, ano);
                    estacionamento.Estacionar(novoCarro);
                }
                else
                {
                    Console.WriteLine("Alguma informação do carro foi omitida. " +
                    "Não foi possível estacionar !");
                    continue;
                }
                break;
            case 2:
                Console.WriteLine("Digite a placa do carro: ");
                string? placaDoCarro = Console.ReadLine();
                if (placaDoCarro != null)
                estacionamento.RetirarCarro(placaDoCarro);
                break;
            case 3:
                estacionamento.MostrarCarros();
                break;
            
            case 4:
                loop = false;
                break;

            default:
                Console.WriteLine("Valor não disponível!");
                continue;
        }
    }
    catch (Exception e)
    {

        throw new Exception(e.Message);
    }
}
