class Pessoa
{
    public string nome;
    public int cpf;

    public Pessoa()//constructor
    {
        nome = "Amós";
        cpf = 1000;
    }
}

class Program
{
    void main()
    {
        Pessoa p1 = new pessoa();
        Console.Write(p1.nome);
    }
}