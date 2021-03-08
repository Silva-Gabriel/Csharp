using System;

namespace Projeto
{
    public class Contas
    {
        private TipoDeConta TipoDeConta { get; set; }

        private double Saldo{ get; set; }

        private double Credito { get; set; }

        private string Nome { get; set; }

        public Contas(TipoDeConta TipoDeConta, double Saldo,double Credito, string Nome)
        {
            //Altera somente está instância
            this.TipoDeConta = TipoDeConta;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Nome = Nome;
        }

        public bool Sacar(double ValorDoSaque)
        {
            //Validação do saldo
            if(this.Saldo - ValorDoSaque < (this.Credito *(-1)))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            this.Saldo -= ValorDoSaque;
            Console.WriteLine($"\n - Saldo atual da conta de {this.Nome} é de R${this.Saldo:f2}");

            return true;
        }
        public void Depositar(double ValorDoDeposito)
        {
            this.Saldo += ValorDoDeposito;

            Console.WriteLine($"\n - Saldo atual da conta de {this.Nome} é de R${this.Saldo:f2}");
        }

        public void Transferir(double ValorDaTransferencia, Contas ContaDestino)
        {
            if(this.Sacar(ValorDaTransferencia))
            ContaDestino.Depositar(ValorDaTransferencia);
        }
        //Representação da instância no console
        public override string ToString()
        {
            string retorno = "";
            retorno += "\nTipo de Conta: " + this.TipoDeConta + " | ";
            retorno += "Nome:  " + this.Nome + " | ";
            retorno += "Saldo:R$" + this.Saldo + " | ";
            retorno += "Crédito:R$" + this.Credito;
            return retorno;
        }
    }
}