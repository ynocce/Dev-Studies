namespace programa
{
    public class Program
    {
        public static void Main()
        {
            Arqueiro arqueiro = new Arqueiro();
            Guerreiro guerreiro = new Guerreiro();
            Mago mago = new Mago();
            Sacerdote sacerdote = new Sacerdote();

            menu();
            string perssonagem = Console.ReadLine();

            switch (perssonagem)
            {
                case "1":
                    arqueiro.atacar();
                    arqueiro.pular();
                    arqueiro.caminhar();
                    break;

                case "2":
                    guerreiro.atacar();
                    guerreiro.pular();
                    guerreiro.caminhar();
                    break;

                case "3":
                    mago.atacar();
                    mago.pular();
                    mago.caminhar();
                    break;

                case "4":
                    sacerdote.atacar();
                    sacerdote.pular();
                    sacerdote.caminhar();
                    break;

                default:
                    Console.WriteLine("Perssonagem não encontrado!");
                    break;
            }
        }

        public static void menu()
        {
            Console.WriteLine("Olá, escolha seu perssonagem:" +
                "\n" +
                "\n1 - Arqueiro" +
                "\n2 - Guerreiro" +
                "\n3 - Mago" +
                "\n4 - Sacerdote\n");
        }
    }
}