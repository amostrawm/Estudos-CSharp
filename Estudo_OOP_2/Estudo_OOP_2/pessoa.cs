Class Pessoa
{
    public string Nome;
    public Telefone Tel1, Tel2;
    public Endereco End;
    public Conta Conta;

    public Pessoa()//Constructor
    {
        Nome = "";
        Tel1 = new Telefone;
        Tel2 = new Telefone;
        End = new Endereco;
        Conta = new Conta;
    }
}