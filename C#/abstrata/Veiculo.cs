namespace programa{
    public abstract class Veiculo{
        public double velocidade;
        public abstract void Locomover();
        
        public abstract void Frear();


        public abstract void estacionar();
        public virtual double getVelocidade(){
            return this.velocidade;
        }

        public void explodir(){
            Console.WriteLine("boom");
        }
    }
}