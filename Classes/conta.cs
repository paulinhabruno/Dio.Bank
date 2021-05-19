namespace Dio.Bank
{
    public class conta
    {
// Atributos
        private TipoConta TipoConta { get; set; }

        private double Saldo {get; set;}

        private double Credito {get; set;}

        private string Nome {get; set; }

// construtor
        public conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito; 
            this.Nome = nome;
        }
    }
}