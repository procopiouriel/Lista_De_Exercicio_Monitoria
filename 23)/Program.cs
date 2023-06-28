using System;

class Monitoria23
{
    public static void Main(string[] args)
    {
        //LOGICA 1:

        Console.WriteLine("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        string nomeContrario = "";

        for(int i = palavra.Length -1; i >= 0;  i--)
        {
            nomeContrario += palavra[i];
        }

       if (nomeContrario == palavra)
        {
            Console.WriteLine("Esta palavra é um Palindromo!");
        }
        else
        {
            Console.WriteLine("Esta palavra não é um Palindromo");
        }

        //LOGICA 2:

        // Reverse() inverte os valores do array
        // Replace(" ", "") substitui os caracteres da primeira aspas
        // pelo caractere da segunda aspas
        // string Palindromo = frase.Replace(" ", "");
        //TOARRAY = CONVERTER A STRING Frase, EM UM ARRAY DE CARACTERES CHAR, ADICIONANDO CADA CARACTERE EM UM LOCAL ESPECIFICO.

        Console.Write("Digite uma palavra ou frase: ");
        string Frase = Console.ReadLine();

        char[] frase2 = Frase.Replace(" ", "").ToArray();//ARRAY ONDE E ARMAZENADO A VARIAVEL Frase, SEM ESPAÇAMENTOS, E GUARDADOS EM UM ARRAY.
        
        char[] Palindromo = frase2.Reverse().ToArray();//ARRAY ONDE E ARMAZENADO A VARIAVEL Frase AO CONTRARIO, SEM ESPAÇAMENTOS, E GUARDADOS EM UM ARRAY.


        int contaDiferentes = 0;
        for (int i = 0; i < frase2.Length; i++)
        {
            if (frase2[i] != Palindromo[i])
            {
                contaDiferentes++;
                Console.WriteLine("Não é palíndromo");
                break;
            }
        }
        if (contaDiferentes == 0)
        {
            Console.WriteLine("É um palíndromo");
        }

    }
}