namespace Banco_Digital
{
    class Program
    {
        static void Main()
        {
            try{
                var mauricio = Banco_Digital.Classes.Cliente.CreateCliente("Mauricio", "Rua 9 de Julho", 3333332999, "999.999.999-99", new System.DateTime(2000, 02, 17));
                var brunao = Banco_Digital.Classes.Cliente.CreateCliente("Brunao", "Rua 11 de Maio", 33232329, "999.999.999-99", new System.DateTime(2001, 12, 17));
                //PODERIAMOS CRIAR UM BANCO DE DADOS PARA OS CLIENTE?
                int mydelay = 8000;
                int mydelayfast = 1000;

                var Saque = 500;
                var Deposito = 1000;
                var Transferencia = 5000;

                //////////////////////////////////
                Classes.Conta ContaMauricioPoupanca = new Poupanca(mauricio, 445852, 1000);// cria conta poupanca
                System.Console.Clear();
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {ContaMauricioPoupanca.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {ContaMauricioPoupanca.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {ContaMauricioPoupanca.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {ContaMauricioPoupanca.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {ContaMauricioPoupanca.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo na conta: {ContaMauricioPoupanca.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Conta poupanca criada com suecesso!");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();

                ContaMauricioPoupanca.Depositar(Deposito);// deposita saldo na poupanca
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {ContaMauricioPoupanca.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {ContaMauricioPoupanca.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {ContaMauricioPoupanca.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {ContaMauricioPoupanca.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {ContaMauricioPoupanca.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Deposito efetuado na conta poupanca: {Deposito}.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo atual: {ContaMauricioPoupanca.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Deposito realizado com suecesso!");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();

                ContaMauricioPoupanca.Sacar(Saque); //saca saldo na poupanca
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {ContaMauricioPoupanca.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {ContaMauricioPoupanca.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {ContaMauricioPoupanca.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {ContaMauricioPoupanca.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {ContaMauricioPoupanca.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saque efetuado na conta poupanca: {Saque}.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo atual: {ContaMauricioPoupanca.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Saque realizado com suecesso!");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();

                ///////////////////////////////////
                Classes.Conta contaMauricioCorrente = new Corrente(mauricio, 445852, 1000); //criar conta corrente
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {contaMauricioCorrente.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {contaMauricioCorrente.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {contaMauricioCorrente.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {contaMauricioCorrente.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {contaMauricioCorrente.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo na conta: {contaMauricioCorrente.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Conta corrente criada com suecesso!");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();

                contaMauricioCorrente.Depositar(Deposito);// deposita saldo na conta corrente
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {contaMauricioCorrente.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {contaMauricioCorrente.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {contaMauricioCorrente.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {contaMauricioCorrente.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {contaMauricioCorrente.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Deposito efetuado na conta corrente: {Deposito}.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo atual: {contaMauricioCorrente.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Deposito realizado com suecesso!");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();

                contaMauricioCorrente.Sacar(Saque); // saca saldo da conta corrente
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {contaMauricioCorrente.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {contaMauricioCorrente.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {contaMauricioCorrente.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {contaMauricioCorrente.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {contaMauricioCorrente.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saque efetuado na conta corrente: {Saque}.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo atual: {contaMauricioCorrente.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Saque realizado com suecesso!");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();

                /////////////////////////////////// 
                Classes.Conta contaBrunaoCorrente = new Corrente(brunao, 445852, 0); //cria a conta corrente
                System.Console.Clear();
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {contaBrunaoCorrente.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {contaBrunaoCorrente.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {contaBrunaoCorrente.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {contaBrunaoCorrente.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {contaBrunaoCorrente.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo na conta: {contaBrunaoCorrente.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Conta corrente criada com suecesso!");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();

                Classes.Conta ContaBrunaoPoupanca = new Poupanca(brunao, 445852, 0); // cria a conta poupanca
                System.Console.Clear();
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {ContaBrunaoPoupanca.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {ContaBrunaoPoupanca.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {ContaBrunaoPoupanca.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {ContaBrunaoPoupanca.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {ContaBrunaoPoupanca.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo na conta: {ContaBrunaoPoupanca.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Conta poupanca criada com suecesso!");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();

                // transferir dinheiros
                System.Console.Clear();
                System.Console.WriteLine("=============================");
                System.Console.WriteLine("");
                System.Console.WriteLine("BANCO LINDOSVALDO_DIGITAL");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {ContaMauricioPoupanca.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {ContaMauricioPoupanca.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {ContaMauricioPoupanca.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {ContaMauricioPoupanca.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {ContaMauricioPoupanca.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo na conta: {ContaMauricioPoupanca.Saldo}.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Efetuando transferencia de {ContaMauricioPoupanca.Cliente.Nome} ({ContaMauricioPoupanca.Cliente.CPF}) " +
                    $"para {contaBrunaoCorrente.Cliente.Nome} ({contaBrunaoCorrente.Cliente.CPF}) no valor de {Transferencia}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Usuário: {contaBrunaoCorrente.Cliente.Nome}");
                System.Console.WriteLine($"Endereco: {contaBrunaoCorrente.Cliente.Endereco}");
                System.Console.WriteLine($"Telefone: {contaBrunaoCorrente.Cliente.Telefone}");
                System.Console.WriteLine($"CPF: {contaBrunaoCorrente.Cliente.CPF}");
                System.Console.WriteLine($"Idade: {contaBrunaoCorrente.Cliente.Data_de_Nascimento}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo na conta: {contaBrunaoCorrente.Saldo}.");
                System.Console.WriteLine("");
                ContaMauricioPoupanca.Transferir(Transferencia, contaBrunaoCorrente, ContaMauricioPoupanca.Saldo); // tranferir dinheiro
                System.Console.WriteLine($"Transferindo {Transferencia} para {ContaMauricioPoupanca.Cliente.Nome}");
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Saldo atual na conta do {ContaMauricioPoupanca.Cliente.Nome} esta:{ContaMauricioPoupanca.Saldo}");
                System.Console.WriteLine($"Saldo atual na conta do {contaBrunaoCorrente.Cliente.Nome} esta: {contaBrunaoCorrente.Saldo}");
                System.Console.WriteLine("");
                System.Console.WriteLine("=============================");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.WriteLine("Carregando mais informações...");
                System.Threading.Thread.Sleep(mydelayfast);

                ///////////////////////////////////
            }
            catch (System.Exception ex)
            { 
                System.Console.WriteLine(ex.Message);
                int mydelay = 8000;
                System.Threading.Thread.Sleep(mydelay);
            }
        }
    }
}