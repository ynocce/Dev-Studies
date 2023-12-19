namespace programa{

    public class Carro:Veiculo{

        public override void estacionar(){
            Console.WriteLine("de a seta, estacione");
        }
        public double velocimetro;
        public override void Locomover()
        {
            Console.WriteLine("Correr");
        }
        public override void Frear()
        {
            Console.WriteLine("Pisa no pedal do meio.");
        }
        
        public override double getVelocidade()
        {
            Console.WriteLine("O velocímentro indica" + this.velocimetro);
            return this.velocimetro;
        }
    }
}