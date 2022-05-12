class Conta
{
    public double Saldo {get; set;}
    public Agencia Ag1;

    public Conta()
    {
        Ag1 = new Agencia();
    }
}