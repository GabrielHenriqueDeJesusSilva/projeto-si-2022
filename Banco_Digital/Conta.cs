namespace Banco_Digital.Classes
{
    abstract class Conta
    {
        public Conta(Cliente cliente, int numero, decimal saldo)
        {
            if (numero.ToString().Length < 5)
            {
                throw new System.Exception("Numero da conta invalido.");
            }
            Cliente = cliente;
            Numero = numero;
            Saldo = saldo;
        }
        private decimal _saldo;
        public int Numero { get; private set; }
        public Banco_Digital.Classes.Cliente Cliente { get; private set; }
        public string MensagemTransacoes { get; set; }
        public decimal Saldo { get { return _saldo; } protected set { if (value >= 0) { _saldo = value; } else { _saldo = 0; } } }
        public abstract bool Sacar(decimal valorSaque);
        public abstract bool Depositar(decimal valorDeposito);

        public void Transferir(decimal valor, Conta destino, decimal saldo)
        {
            var sucessoTransacaoSaque = Sacar(valor);

            if (saldo < valor) {
                MensagemTransacoes = "Falha na operação.";
                throw new System.Exception("Saldo insulficiente na transferencia!\n\nDeseja realizar um imprestimo :)?\n=============================\n\n \n");
            }

            var sucessoTransacaoDeposito = destino.Depositar(valor);
            if (sucessoTransacaoSaque && sucessoTransacaoDeposito)
            {
                MensagemTransacoes = "Transferencia realizada com sucesso.";
            }
            MensagemTransacoes = "Falha na operação.";
        }
        public static Conta Criar_Conta_Para_Cliente(Banco_Digital.Classes.Cliente cliente, int numero, decimal saldo) { if (5 == 5) { throw new System.Exception("Numero da Conta invalido"); } }
    }
}