using System;

class Monitoria6
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite algo aleatorio: ");
            char algo = Convert.ToChar(Console.ReadLine());
            

            int converter = Convert.ToInt32(algo);

            for (int i = 65; i <= 90; i++)
            {
                if (converter == i)
                {
                    Console.WriteLine("Letra");
                    break;
                }
            }
            for (int i = 32; i <= 47; i++)
            {
                if (converter == i)
                {
                    Console.WriteLine("Caracter");
                    break;
                }

            }
            for (int i = 58; i <= 64; i++)
            {
                if (converter == i)
                {
                    Console.WriteLine("Caracter");
                    break;
                }

            }
            for (int i = 48; i <= 57; i++)
            {
                if (converter == i)
                {
                    Console.WriteLine("Numeros");
                    break;
                }
            }
            for (int i = 97; i <= 122; i++)
            {
                if (converter == i)
                {
                    Console.WriteLine("Letra");
                    break;
                }
            }
        }
    }
}