Class Agencia
{
    public string Numero {get; set;}
    public Endereco End;

    public Agencia()//Constructor
    {
        End = new Endereco();
    }
}