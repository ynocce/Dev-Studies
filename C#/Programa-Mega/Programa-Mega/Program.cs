public class Program
{
    static void Main(string[] args)
    {
            int[] resultado_mega = { 15, 29, 42, 57, 58, 60};
            int[] palpite_mega = new int[6];
            int n = 0;

            string entrada_usuario = "";

            for (int p = 0; p < palpite_mega.Count(); p++)
            {
                do
                {
                    if ((n > 0) && (n < 100))//intervalo da mega sena
                    {
                        //validação de repetido
                        break;
                    }
                    Console.WriteLine("Digite o valor " + (p + 1) + " do seu palpite: ");
                    entrada_usuario = Console.ReadLine();

                    int.TryParse(entrada_usuario, out n);//convertendo a entrada em número
                } while (true);
                for (int y = 0; y <= p - 1; y++)
                {//Verificando se o valor já digitado antes
                    if (n == palpite_mega[y])
                    {
                        Console.WriteLine("Número já existe. Digite novamente:");
                        entrada_usuario = Console.ReadLine();
                        int.TryParse(entrada_usuario, out n);
                    }
                }
                palpite_mega[p] = n;
                n = 0;
            }
            Console.WriteLine("O palpite digitado foi");
            for (int p = 0; p < palpite_mega.Count(); p++)
            {
                Console.Write("\t" + palpite_mega[p]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("O Resultado da mega foi:");
            for (int p = 0; p < resultado_mega.Count(); p++)
            {
                Console.Write("\t" + resultado_mega[p]);
            }
    }
    }