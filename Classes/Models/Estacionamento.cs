namespace Classes.Models;

public class Estacionamento
{
    private List<Carro> vagas;
    private int quantidadeDeVagas;

    public Estacionamento(int vaga)
    {
        vagas = new();
        quantidadeDeVagas = vaga;
    }

    public void Estacionar(Carro carro)
    {
       if(quantidadeDeVagas <= 0){
            Console.WriteLine("Não foi possivel "+ 
            "estacionar o carro");
            return;
       }
       vagas.Add(carro);
       quantidadeDeVagas -= 1;
       Console.WriteLine("Carro adicionado com sucesso!");
       return; 
    }

    public void RetirarCarro(string placa)
    {
        if(vagas?.Count < 0)
        {
            Console.WriteLine("Não existem carros "+
            "para serem retirados!");
            return;
        }
        Carro? queryCar = vagas?.Find(car => car.Placa == placa);
        if(queryCar != null)
        {
        vagas?.Remove(queryCar);
        quantidadeDeVagas += 1;
        Console.WriteLine("Carro removido com sucesso!");
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
            System.Console.WriteLine(carro.ToString());
        }
    }
}
