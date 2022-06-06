class Pet
{
    public string Nome_Pet { get; set; }
    public string Id_Pet { get; set; } 
    public string Descricao_Pet { get; set; }
    public Cliente petcli;

    public Pet()//Constructor
    {
        Nome_Pet = "";
        Id_Pet = "";
        Descricao_Pet = "";
        petcli = new Cliente();
    }
    //Métodos CRUD para Pet
    public void Add_Pet() { }
    public void Editar_Pet() { }
    public void Excluir_Pet() { }
    public void Ver_Pet() { }
}
