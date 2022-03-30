struct Pessoa
{
    public int idade;
    public string nome, cpf;
}

class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();

        Console.WriteLine("Digite os dados da pessoa [1]"); 
        p1.nome = Console.ReadLine();
        p1.idade = Convert.ToInt32(Console.ReadLine());
        p1.cpf = Console.ReadLine();

        Console.WriteLine("Digite os dados da pessoa [2]");
        p2.nome = Console.ReadLine();
        p2.idade = Convert.ToInt32(Console.ReadLine());
        p2.cpf = Console.ReadLine();

        Console.WriteLine("Nome: {0} | Idade: {1} | CPF: {2}", p1.nome, p1.idade, p1.cpf);
        Console.WriteLine("Nome: {0} | Idade: {1} | CPF: {2}", p2.nome, p2.idade, p2.cpf);

    }
}