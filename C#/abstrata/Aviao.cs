namespace programa{

    public class Aviao:Veiculo{
        public override void Locomover()
        {
            Console.WriteLine("voar");
        }
        public override void Frear()
        {
            Console.WriteLine("Ligar os reversores");
        }
        public override double getVelocidade()
        {
            return base.velocidade;
        }
        public override void estacionar(){
            Console.WriteLine("faça o taxi até o hangar");
        }
    }
}