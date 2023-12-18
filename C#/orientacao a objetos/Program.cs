namespace programa{
    public class Program
    {
        static void Main ()
        {
            Escola senai;
            senai = new Escola();
            senai.setNome("Senai Londrina");
            senai.setCnpj("3776284002225");
            senai.setEndereco("rua belem");
            Console.WriteLine(senai);

            Escola senai2 = new Escola("Senai Londrina","3776284002225","Rua Belem");
            Console.WriteLine(senai2);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Pessoa pessoa = new Pessoa("00033344422", "Joaquim", "Rua antonio rodrigues, 167");

            Console.WriteLine(pessoa);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Cliente cliente = new Cliente(1, "Bom Pagador", "111444222277","Francisco", "Rua das acácias, 120");

            Console.WriteLine(cliente);

            Veiculo a;
            Veiculo b;

            a = new Aviao();
            b = new Carro();
            a.Locomover();
            b.Locomover();
        }
    }
}