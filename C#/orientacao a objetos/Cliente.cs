namespace programa{

    public class Cliente:/*extends do java*/Pessoa{
        public int clId;
        private string avaliacao;
        

        
        public Cliente(int clId, string avaliacao, string cpf, string nome, string endereco):base(cpf, nome, endereco)
        {

            this.clId = clId;
            this.avaliacao=avaliacao;

        }
        
        public override string ToString(){
            return base.ToString()+
             "ID: "+ this.clId+"\n"+
            "Avaliação:"+ this.avaliacao+"\n";
        }
        public bool negativar(){//como verificar avisar o usuario da classe que o cliente já é um devedor?
            if(this.avaliacao.Equals("Devedor"))
            {
                return false;
                
            } else{
                this.avaliacao = "Devedor";
                return true;
            }
        }


    }
}