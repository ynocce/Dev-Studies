namespace programa
{
    public class Guerreiro : Pessoa
    {
        public override void atacar()
        {
            Console.WriteLine("Arremessar espada");
        }

        public override void caminhar()
        {
            Console.WriteLine("Avançar");
        }

        public override void pular()
        {
            Console.WriteLine("Saltar");
        }
    }
}
