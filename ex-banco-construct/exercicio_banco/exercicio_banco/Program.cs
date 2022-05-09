class Pessoa
{
    public string Nome { get; set; }
    public int CPF { get; set; }

    public Pessoa()//Constructor
    {
        Nome = "";
        CPF = 0;
    }
}

class Conta
{
    public string Num_Conta { get; set; }
    public string Nome { get; set; }
    public double Limite;
    public double Saldo { get; set; }

    public Conta()//Constructor
    {
        Num_Conta = "";
        Nome = "";
        Limite = 0;
        Saldo = 0;
    }

    public void Deposito(double valor)//Deposito
    {
        Saldo = Saldo + valor;
        Console.WriteLine("Deposito bem sucedido no valor de R$" + valor + ".");
    }
}

class Program
{ 
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();//Instância p1
        p1.Nome = "Amós";
        p1.CPF = 1234;

        Conta c1 = new Conta();//Instância c1
        c1.Num_Conta = "0001";
        c1.Nome = p1.Nome;
        c1.Limite = 1000;


        int Escolha;
        bool Run = true;
        double Valor_deposito;
        Console.Clear();
        Console.WriteLine("Conta: {0}\nNome: {1}\nCPF: {2}\nSaldo: {3}",c1.Num_Conta,p1.Nome,Convert.ToString(p1.CPF),Convert.ToString(c1.Saldo));
        Console.WriteLine("O limite para novas contas é R$1000.\nDigite qualquer tecla para continuar...\n");
        Console.ReadKey();
        Console.Clear();

        while (Run)
        {

            Console.WriteLine("Bem vindo ao Banco! \n" + "Escolha uma opção:\n[1]Saldo\n" + "[2]Limite\n" + "[3]Depósito\n" + "[4]Finalizar\n");
            Escolha = Convert.ToInt32(Console.ReadLine());

            if (Escolha == 4)//Finaliza
            {
                Console.Clear();
                Console.WriteLine("Finalizando...");
                Run = false;
            }

            if(Escolha == 1)//Saldo
            {
                Console.Clear();
                Console.WriteLine("Seu saldo é: R$" + c1.Saldo + ".\n" + "Precione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }

            if(Escolha == 2)//Limite
            {
                Console.Clear();
                Console.WriteLine("Seu limite é: R$" + c1.Limite + ".\n" + "Precione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }

            if(Escolha == 3)//Deposito
            {
                Console.Clear();
                Console.Write("Digite o valor a ser depositado: R$");

                Valor_deposito = Convert.ToDouble(Console.ReadLine());//Leitura de valor
                Console.Clear();
                c1.Deposito(Valor_deposito);//Chama o método deposito e soma com saldo
                Console.WriteLine("");
                Console.WriteLine("Saldo após depósito: R$" + c1.Saldo + '.');
                Console.WriteLine("Precione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();


            }
        }
    }
}