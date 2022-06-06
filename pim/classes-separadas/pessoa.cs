class Pessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Telefone1 { get; set; }
    public string Telefone2 { get; set; }
    public Pessoa()//Constructor 
    {
        Nome = "";
        CPF = "";
        Telefone1 = "";
        Telefone2 = "";
    }
    //Métodos CRUD para Pessoa
    public void Add_Pessoa() { }
    public void Editar_Pessoa() { }
    public void Excluir_Pessoa() { }
    public void Ver_Pessoa() { }
}