namespace AulaPOO_Encapsulamento.Classes
{
    public class MasterCard : Cartao // Classe herdando de Cartao
    {
        private int parcelas;
        public void ExibirLimite()
        {
           System.Console.WriteLine(this.limite);
        }
    }
}