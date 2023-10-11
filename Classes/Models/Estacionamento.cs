namespace Classes.Models;

public class Estacionamento
{
    private List<Carro> vagas;
    private int quantidadeDeVagas;
    private decimal valorCobradoPorHoras;

    public Estacionamento(int vaga, decimal valor)
    {
        vagas = new();
        quantidadeDeVagas = vaga;
        valorCobradoPorHoras = valor;
    }

    public void Estacionar(Carro carro)
    {
       if(quantidadeDeVagas <= 0){
            Console.WriteLine("Não foi possivel "+ 
            "estacionar o carro");
            return;
       }
       Carro? querycar = vagas.Find(car => car.Placa == carro.Placa);
       if(querycar != null){
            Console.WriteLine("Não é possível estacionar " +
            "um carro com uma placa que já existe!");
            return;
       }
       vagas.Add(carro);
       quantidadeDeVagas -= 1;
       Console.WriteLine("Carro adicionado com sucesso!");
       return; 
    }

    public void RetirarCarro(string placa)
    {
        if(vagas?.Count <= 0)
        {
            Console.WriteLine("Não existem carros "+
            "para serem retirados!");
            return;
        }
        Carro? queryCar = vagas?.Find(car => car.Placa == placa);
        if(queryCar != null)
        {
        Console.WriteLine("Quantas horas permaneceu estacionado?");
        decimal horasDePermanencia = Convert.ToDecimal(Console.ReadLine());
        vagas?.Remove(queryCar);
        quantidadeDeVagas += 1;
        Console.WriteLine($"Carro removido com sucesso! \n" +
        $"Valor a pagar: {horasDePermanencia * valorCobradoPorHoras}");
        return;
        }
        else
        {
            Console.WriteLine("Carro não encontrado!");
        }   
    }

    public void MostrarCarros()
    {
        foreach (var carro in vagas)
        {
            Console.WriteLine(carro.ToString());
        }
    }
}
