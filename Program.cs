using System;

class CarroMonitoramento
{
    public static bool VerificarAptidao(int anoFabricacao, int anoAtual)
    {
        int idade = anoAtual - anoFabricacao;
        return idade <= 10;
    }

    static void Main()
    {
        string modelo = Console.ReadLine();
        int anoFabricacao = int.Parse(Console.ReadLine());
        int anoAtual = int.Parse(Console.ReadLine());

        string resultado = VerificarAptidao(anoFabricacao, anoAtual) ? $"{modelo}: Apto" : $"{modelo}: Nao apto";

        Console.WriteLine(resultado);
    }
}
