class Funcionario
{
    public string Senha { get; set; }
    public string Tipo_Funcionario { get; set; }
    public Pessoa pfunc;
    public Funcionario()//Constructor
    {
        Senha = "";
        Tipo_Funcionario = "";
        pfunc = new Pessoa();
    }
    //Métodos CRUD para Funcionario
    public void Add_Funcionario() { }
    public void Editar_Funcionario() { }
    public void Excluir_Funcionario() { }
    public void Ver_Funcionario() { }
}
