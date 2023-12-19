namespace programa{

    public class Pessoa{
        private string cpf;
        public string nome;
        private string endereco;

        public Pessoa(string cpf, string nome, string endereco){
            this.cpf=cpf;
            this.nome = nome;
            this.endereco=endereco;
        }

        public override string ToString(){
            return "Nome: "+this.nome+"\n"+
            "CPF: "+this.cpf+"\n"+
            "Endereco: "+this.endereco+"\n";
        }



        
        

    }
}