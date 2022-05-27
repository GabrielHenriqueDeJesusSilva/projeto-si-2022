using Banco_Digital.Classes;

namespace Banco_Digital
{
    class Poupanca : Classes.Conta
    {
        public Poupanca(Cliente cliente, int numero, decimal saldo)
            : base(cliente, numero, saldo)
        { }
        public override bool Depositar(decimal valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                MensagemTransacoes = $"O valor do depósito é inválido!";
                return false;
            }
            Saldo += valorDeposito + 0.5m;
            MensagemTransacoes = "Deposito realizado com sucesso!";
            return true;
        }
        public override bool Sacar(decimal valorSaque)
        {
            if (Saldo <= 0m)
            {
                MensagemTransacoes = $"O saldo é insuficiente para saque. Sua conta está com o valor atual de {Saldo}";
                return false;
            }
            if (Saldo < valorSaque)
            {
                MensagemTransacoes = $"Valor solicitado para o saque é {valorSaque} e o Saldo é {Saldo}";
                return false;
            }
            Saldo -= valorSaque + 0.1m;
            return true;
        }
    }
}