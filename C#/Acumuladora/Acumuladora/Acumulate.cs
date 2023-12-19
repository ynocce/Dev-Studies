namespace programa
{
    public class Acumuladora
    {
        static void Main(String[] args)
        {
            int num1 = 0;
            int count = 0;
            int x = 1;
            while (x != 0)
            {
                Console.Write("\nInforme um valor:");
                x = int.Parse(Console.ReadLine());
                num1 += x;
                count++;
            }

            Console.WriteLine("\nTotal: " + num1);
            Console.WriteLine("Números digitados: " + count);

            Operacoes operacoes = new Operacoes();
            operacoes.isPar(num1);
        }

    }

    public class Operacoes
    {
        public void isPar(int valor)
        {
            if (valor % 2 == 0)
            {
                Console.WriteLine("O número é PAR");
            }
            else
            {
                Console.WriteLine("O número é ÍMPAR");
            }
        }
    }
}