

class Program
{
    struct Pessoa
    {
        public string nome, cpf;
        public int idade;
    }
    static void Main(String[] args)
    {
        Pessoa[] ps = new Pessoa[3];

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite o nome");
            ps[i].nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            ps[i].cpf = Console.ReadLine();
            Console.WriteLine("Digite a idade");
            ps[i].idade = Convert.ToInt32(Console.ReadLine() );
        }
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nome: {0}\n CPF: {1}\n Idade: {2}\n\n", ps[i].nome,ps[i].cpf,ps[i].idade);
        }
    }
}