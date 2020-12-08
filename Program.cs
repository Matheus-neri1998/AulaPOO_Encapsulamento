using System;
using AulaPOO_Encapsulamento.Classes;

namespace AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.NomeTitular = "Matheus Neri";

            m.Numero = "123456789"; // Aqui foi utilizado o SET

            m.Bandeira = "MasterCard";

            Console.WriteLine($"O titular {m.NomeTitular} - Token {m.Token}"); // Aqui foi utilizado o GET

        }
    }
}
