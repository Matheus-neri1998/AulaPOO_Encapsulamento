namespace AulaPOO_Encapsulamento.Classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get {return numero;} // get = capturar ou pegar o valor
            set {numero = value;} // set = definir o valor 
            // nesta sintaxe de Encapsulamento, o ponto e vírgula (;) vem antes do fechamento da chave
        }
        private string nomeTitular;
        public string NomeTitular{
            get {return nomeTitular;}
            set {nomeTitular = NomeTitular;}
        }
        
        private string bandeira;
        public string Bandeira{get; set;}
        protected string token = "qwertyui"; 
        public string Token{
            get{return token;}
        }
        private string cvv;
        public string Cvv{get; set;}
        protected float limite = 5000;
        public float Limite{
            get {return limite;}
            set {limite = Limite;}
        }

        // Métodos
        public string RegistarCompra(bool validado){
            return "";
        }
        public string ReceberNome(string nomeDigitado){
           return this.nomeTitular = nomeDigitado;
        }
        public void ExibirNome(){
            System.Console.WriteLine(this.nomeTitular);
        }

        
    }
}