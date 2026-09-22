class Conta
{
    public string titular;
    public int id;
    public double saldo;
    public int senha;

   public void ExibirConta()
    {
        Console.WriteLine("INFORMAÇÕES DA CONTA:");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo atual: {saldo}");
    }
}