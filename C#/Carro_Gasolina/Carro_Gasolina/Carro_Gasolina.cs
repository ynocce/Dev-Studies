public class Carro_Gasolina
{
    static void Main(string[] args)
    {
        int PrecoGasoli, distancia, consumo, calc, valor;

        Console.WriteLine("Digite o preço da gasolina. ");
        Console.Write("Valor, por litro: ");
        PrecoGasoli = int.Parse(Console.ReadLine());

        Console.Write("Digite a distancia do seu destino em KM: ");
        distancia = int.Parse(Console.ReadLine());


        Console.Write("Desempenho do seu carro em quilômetros por litro: ");
        consumo = int.Parse(Console.ReadLine());

        calc = distancia / consumo;
        valor = calc * PrecoGasoli;

        Console.WriteLine("Dinheiro gasto: " + valor + " Reais");
        Console.WriteLine("Consumo: " + calc + " Litros");
    }
}