using System;

class monitoria5
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Calcular a média de 3 numeros: ");
            Console.WriteLine("2- Tirar a raiz quadrade de um numero: ");
            Console.WriteLine("3- Sair do programa");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o primeiro valor: ");
                    double valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor: ");
                    double valor2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro valor: ");
                    double valor3 = Convert.ToDouble(Console.ReadLine());

                    double resultado = (valor1 + valor2 + valor3) / 3;
                    Console.WriteLine("Média = " + resultado);
                    break;

                case 2:
                    Console.WriteLine("Digite um valor: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    double resultado1 = Math.Sqrt(valor);
                    Console.WriteLine("Raiz quadrada = " + resultado1);
                    break;

                case 3:
                    Console.WriteLine("Encerrando programa!!");
                    goto saida;
                    break;

                default:
                    Console.WriteLine("Opção Invalida!");
                    break;
            }
        saida:
            break;
        }
        Console.ReadKey();
    }
}