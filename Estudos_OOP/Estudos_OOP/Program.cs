class Pessoa
{
    public string nome;
    public int idade;
    public double cpf;
    public string end;

    public void Soma_id()
    { 
        idade = idade + 10; 
    }
    public string Valida_cpf()
    {
        if(cpf != 0)
        {
            return "CPF Válido";
        }
        return "CPF Inválido";
    }
    public void Ano(int valor)
    {
        Console.WriteLine(valor);
    }

    public int Ano_soma(int valor)
    {
        int a = valor + 10;
        return a;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa pe = new Pessoa();
        pe.nome = Console.ReadLine();
        pe.idade = Convert.ToInt32(Console.ReadLine() );
        pe.cpf = Convert.ToDouble(Console.ReadLine());
        pe.end = Console.ReadLine();

        pe.Ano(2022);
        Console.WriteLine(pe.Ano_soma(2022) );

        Console.WriteLine("Nome: {0} \n Idade: {1} \n CPF: {2} \n Endereço: {3}",
                            pe.nome, pe.idade, pe.cpf, pe.end);
        pe.Soma_id();
        Console.WriteLine(pe.idade);

        Console.WriteLine(pe.Valida_cpf() );

    }

}
