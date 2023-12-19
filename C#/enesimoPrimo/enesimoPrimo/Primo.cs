namespace programa
{
    public class EnesimoPrimo
    {
        static void Main(String[] args)
        {
            int[] numerosPrimos = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };
            int posicao = 0;

            Console.WriteLine("Digite a posição do núemro primo:");
            posicao = int.Parse(Console.ReadLine());

            Console.WriteLine("O número primo na posição {0} é {1}", posicao, numerosPrimos[posicao - 1]);
        }
    }
}