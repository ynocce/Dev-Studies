
namespace programa{


    public  class Program{
        public static void Main(){
            Veiculo carro = new Carro();
            Veiculo aviao = new Aviao();
            carro.Locomover();
            aviao.Locomover();
            aviao.getVelocidade();
        }
    }
}