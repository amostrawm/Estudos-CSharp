class Pessoa
{
    public string nome;
    public int cpf;

    public Pessoa()//Constructor
    {
        nome = "Amós";
        cpf = 0;
    }

    public void set_nome(string xnome)
    {
        if (nome !="");
        nome = xnome;
    }

    public string get_nome()
    {
        return nome;
    }
}

class Conta
{
    public int Num_Conta { get; set; }
    public string Nome { get; set; }
    public double Limite;
    public double Saldo { get; set; }

    public Conta()//Constructor
    {
        Num_Conta = 0;
        Nome = "";
        Limite = 1000;
        Saldo = 0;
    }

    public void Deposito(double valor)
    {
        Saldo = Saldo + valor;
        Console.WriteLine("Deposito bem sucedido no valor de R$[" + valor + "].");
    }
}

class Program
{ 
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        Console.WriteLine(p1.get_nome());

        Conta c1 = new Conta();
        Console.WriteLine(c1.Num_Conta);
        c1.Nome = p1.nome;
        Console.WriteLine(c1.Nome);
        Console.WriteLine(c1.Limite);
        Console.WriteLine(c1.Saldo); 
        c1.Deposito(1000);
        Console.WriteLine(c1.Saldo);
        int Escolha;
        bool Run = true;
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
                Console.WriteLine("Seu saldo é: R$[" + c1.Saldo + "]\n" + "Precione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }

            if(Escolha == 2)//Limite
            {
                Console.Clear();
                Console.WriteLine("Seu limite é: R$[" + c1.Limite + "]\n" + "Precione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }

            if(Escolha == 3)//Deposito
            {
                Console.Clear();
                Console.WriteLine("Digite o valor a ser depositado: ");

            }
        }
    }
}