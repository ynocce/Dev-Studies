namespace programa
{
    public class Sacerdote : Pessoa
    {
        public override void atacar()
        {
            Console.WriteLine("Magia Negra");
        }

        public override void caminhar()
        {
            Console.WriteLine("Correr");
        }

        public override void pular()
        {
            Console.WriteLine("Pular");
        }
    }
}
