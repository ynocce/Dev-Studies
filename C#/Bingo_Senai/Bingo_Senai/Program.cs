public class Program
{
    static void Main(string[] args)
    {
        int valor;
        int i, j;

        int[,] cartela = new int[4, 5];
        Random randNum = new Random();

        Console.WriteLine("Sua cartela é: ");
        for (i = 0; i < 4; i++)
        {
            for (j = 0; j < 5; j++)
            {
                valor = (int)System.Math.Abs(randNum.Next(20));

                for(int y = 0; y < 1; y++)
                {
                    if (valor == cartela[i, j])
                    {
                        valor = valor + 1;
                        cartela[i, j] = valor;
                        Console.Write("\t" + cartela[i, j]);

                    }
                    else
                    {
                        cartela[i, j] = valor;
                        Console.Write("\t" + cartela[i, j]);
                    }
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Vamos Jogar!");
        Console.WriteLine("Bingo!!!");
    }
}