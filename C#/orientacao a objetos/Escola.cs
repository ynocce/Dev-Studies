namespace programa{
    public class Escola{
        private string nome;
        private string cnpj;
        private string endereco;
        

        public Escola(){

        }
        public Escola(string nome, string cnpj, string endereco){
            this.nome = nome;
            this.cnpj = cnpj;
            this.endereco = endereco;
        }

        public string getNome(){
            return this.nome;
        }

        public void setNome(string nome){
            this.nome = nome;
        }

        public string getCnpj(){
            return this.cnpj;
        }
        public void setCnpj(string cnpj){
            this.cnpj = cnpj;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
        public void setEndereco(string endereco){
            this.endereco = endereco;
        }

        public override string ToString()
        {
            return "Nome: "+ this.nome+"\nCNPJ: "+ this.cnpj +"\nEndereço: "+ this.endereco;
        }
        

    }
}