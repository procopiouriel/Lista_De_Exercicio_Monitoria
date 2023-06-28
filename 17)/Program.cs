using System;

class Monitoria17
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor total da compra efetuada: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a opção: ");
        Console.WriteLine("1- Cliente Comum");
        Console.WriteLine("2- Funcionario");
        Console.WriteLine("3- Cliente VIP");
        int opcao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual é seu nome: ");
        string nome = Console.ReadLine();

        switch (opcao)
        {

            case 1:
                Console.WriteLine("O " + nome + " pagara " + valor.ToString("C2"));
                break;
        }
    }
}