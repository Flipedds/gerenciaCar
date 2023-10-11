namespace Classes.Models;

public class Carro
{
    public string Placa {get; set;}
    public string Cor {get; set;}
    public string Modelo {get; set;}

    public int Ano {get; set;}

    public string Marca {get; set;}

    public Carro(string modelo, string marca, string placa, string cor, int ano)
    {
        Modelo = modelo;
        Marca = marca;
        Cor = cor;
        Ano = ano;
        Placa = placa;
    }

    public override string ToString()
    {
        return $"carro: Modelo: {Modelo}, Marca: {Marca}, Cor: {Cor}, Ano: {Ano}, Placa: {Placa}";
    }

}
