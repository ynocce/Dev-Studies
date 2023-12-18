namespace programa
{
    public class Mago : Pessoa
    {
        public override void atacar()
        {
            Console.WriteLine("Bola de fogo");
        }

        public override void caminhar()
        {
            Console.WriteLine("Abrir portal");
        }

        public override void pular()
        {
            Console.WriteLine("Saltar");
        }
    }
}