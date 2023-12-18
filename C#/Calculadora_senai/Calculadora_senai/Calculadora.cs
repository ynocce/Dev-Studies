namespace programa
{
    public class Calculadora
    {
        static void Main(String[] args)
        {
            int num1, num2;
            string operacao;

            Console.Write("Informe o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe a operação (+, -, *, /): ");
            operacao = Console.ReadLine();

            Console.Write("Informe o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());


            Operacoes operacoes = new Operacoes();

            if(operacao == "+")
            {
                operacoes.Somar(num1, operacao, num2);
            }
            else if(operacao == "*")
            {
                operacoes.Multiplicar(num1, operacao, num2);
            }
            else if (operacao == "-")
            {
                operacoes.Subtrair(num1, operacao, num2);
            }
            else if (operacao == "/")
            {
                operacoes.Dividir(num1, operacao, num2);
            }

        }

    }


    public class Operacoes
    {
        public void Somar(int valor1, string operacao, int valor2)
        {
            Console.WriteLine(valor1 + valor2);
        }
        public void Multiplicar(int valor1, string operacao, int valor2)
        {
            Console.WriteLine(valor1 * valor2);
        }
        public void Subtrair(int valor1, string operacao, int valor2)
        {
            Console.WriteLine(valor1 - valor2);
        }
        public void Dividir(int valor1, string operacao, int valor2)
        {
            Console.WriteLine(valor1 / valor2);
        }
    }
}
