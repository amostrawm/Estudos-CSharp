class Cliente
{
    public string Endereco { get; set; }
    public Pessoa pcli;
    public Cliente()//Constructor
    {
        Endereco = "";
        pcli = new Pessoa();
    }
    //Métodos CRUD para Cliente
    public void Add_Cliente() { }
    public void Editar_Cliente() { }
    public void Excluir_Cliente() { }
    public void Ver_Cliente() { }
}
