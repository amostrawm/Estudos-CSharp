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
        Limite = Saldo * 0.15; //Adiciona 15% do deposito no Limite
    }

    public void Saque(double Valor_Saque)//Saque
    {
        if (Valor_Saque <= Saldo)//Possui saldo para saque
        {
            Saldo = Saldo - Valor_Saque;
            Console.WriteLine("Saque de R$" + Valor_Saque + " realizado!\n");
            Valor_Saque = 0;
        }
        if (Valor_Saque > Saldo)//Valor de saque é maior que o saldo disponível
        {

            if (Valor_Saque > (Saldo + Limite))//Saque não realizado, sem saldo nem limite suficiente
            {

                Console.WriteLine("Você não possui saldo nem limite suficiente para realizar o saque!\n");
                Console.WriteLine("Precione qualquer tecla para continuar.");
                Valor_Saque = 0;
                Console.ReadKey();
                Console.Clear();
            }
            else//Saque realizado, saldo é zerado e a diferença subtrai do limite
            {
                double Temp_Saldo;
                Temp_Saldo = Valor_Saque - Saldo;         
                Limite = Limite - Temp_Saldo;  
                Saldo = Temp_Saldo * -1;
                Console.WriteLine("Saque de R$" + Valor_Saque + " realizado!");
                Console.WriteLine("Foi descontado R$" + Temp_Saldo + " do limite!\n");
                Valor_Saque = 0;
                Temp_Saldo = 0;
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    public void Rendimento()//Método para o rendimento
    {
        double Taxa_Rendimento = Taxa();
        Saldo = Saldo + (Saldo * Taxa_Rendimento);
        Console.WriteLine("Foi aplicada uma taxa de rendimento de: " + Taxa_Rendimento + ".\nSaldo após rendimento: R$" + Saldo + ".");
    }
    double Taxa()//Método que retorna uma taxa. Permite alterar a taxa sem mudar o método de rendimento ou o programa principal.
    { return 0.05; }
}

class Resumo
{
    
}
class Program //Programa principal
{ 
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();//Instância p1
        p1.Nome = "Amós";
        p1.CPF = 1234;

        Conta c1 = new Conta();//Instância c1
        c1.Num_Conta = "0001" ;
        c1.Nome = p1.Nome;

        int Escolha;
        bool Run = true;
        double Valor_Deposito, Valor_Saque;
        
        Console.Clear();
        Console.WriteLine("Conta: {0}\nNome: {1}\nCPF: {2}\nSaldo: {3}",c1.Num_Conta,p1.Nome,Convert.ToString(p1.CPF),Convert.ToString(c1.Saldo));
        Console.WriteLine("Digite qualquer tecla para continuar.\n");
        Console.ReadKey();
        Console.Clear();

        while (Run)
        {
            Console.WriteLine("Bem vindo ao Banco! \n" + "Escolha uma opção:\n[1]Saldo\n" + "[2]Limite\n" + "[3]Depósito\n" + "[4]Saque\n" + "[5]Avançar mês\n" + "[6]Finalizar\n");
            Escolha = Convert.ToInt32(Console.ReadLine());

            if (Escolha == 6)//Finaliza
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
                Valor_Deposito = Convert.ToDouble(Console.ReadLine());//Leitura de valor
                Console.Clear();
                c1.Deposito(Valor_Deposito);//Chama o método deposito e soma com saldo
                Console.WriteLine("Saldo após depósito: R$" + c1.Saldo + ".");
                Console.WriteLine("Ao depositar é adicionado no Limite 15% do valor do depósito.\nNovo limite: R$" + c1.Limite + "\nPrecione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }

            if(Escolha == 4)//Saque
            {
                Console.Clear();
                Console.Write("Digite o valor do saque: R$");
                Valor_Saque = Convert.ToDouble(Console.ReadLine());//Faz a leitura do saque desejado
                Console.Clear();

                c1.Saque(Valor_Saque);//Método saque          
            }
            if (Escolha == 5)//Avança o mês e aplica o rendimento
            {
                Console.Clear();
                c1.Rendimento();//Método para aplicar o rendimento
                Console.WriteLine("Precione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}