Class Agencia
{
    public string Numero {get; set;}
    public Endereco End;

    public Agencia()
    {
        End = new Endereco();
    }
}