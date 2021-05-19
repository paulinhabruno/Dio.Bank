using System;

namespace Dio.Bank
{
    public class conta
    {

        private TipoConta TipoConta { get; set; }

        private double Saldo { get; set; }

        private double Credito { get; set; }

        private string Nome { get; set; }

        // construtor
        public conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;  // limite do cheque especial
            this.Nome = nome;
        }
// sacar da conta
        public bool Sacar(double valorSaque)
        {
            // Informação de saldo insuficiente na conta do correntista
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente na sua conta!");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da sua conta de {0} é {1}." , this.Nome, this.Saldo);
            return true;
        }
// Depósito caindo na conta.
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }
// Transferencia entre contas
        public void Transferir(double valorTransferencia, conta contaDestino)
        {
        if (this.Sacar(valorTransferencia)){
            contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " +  this.TipoConta + " | ";
            retorno += "Nome " +  this.Nome + " | ";
            retorno += "Saldo " +  this.Saldo + " | ";
            retorno += "Credito " +  this.Credito + " | ";
            return retorno;
            
       }
    }
}