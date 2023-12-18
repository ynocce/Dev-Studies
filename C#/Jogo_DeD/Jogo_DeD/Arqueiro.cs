namespace programa
{
    public class Arqueiro : Pessoa
    {
        public override void atacar()
        {
            Console.WriteLine("Atirar flecha");
        }

        public override void caminhar()
        {
            Console.WriteLine("Correr");
        }

        public override void pular()
        {
            Console.WriteLine("Saltar");
        }
    }
}
