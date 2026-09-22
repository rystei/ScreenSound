// Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;
    public int quantidadePortas;
    public int velocidade = 0;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Fabricante: {fabricante}, Modelo: {modelo}, Ano: {ano}, Quantidade de portas: {quantidadePortas} e Velocidade: {velocidade}");
    }

    public void acelerar()
    {
        Console.WriteLine("Acelerando");
        if (velocidade < 100)
        {
            velocidade += 5;
        }
    }
    public void frear()
    {
        Console.WriteLine("Freando");
        if (velocidade > 0)
        {
            velocidade -= 5;
        }
    }

    public void buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}