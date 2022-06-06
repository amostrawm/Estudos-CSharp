class Procedimento
{
    public string Cod { get; set; }
    public string Tipo { get; set; }
    public string Descricao { get; set; }
    public Admin adm;
    public Procedimento()//Constructor
    {
        Cod = "";
        Tipo = "";
        Descricao = "";
        adm = new Admin();
    }
    //Métodos CRUD para Procedimento
    public void Add_Proc() { }
    public void Editar_Proc() { }
    public void Excluir_Proc() { }
    public void Ver_Proc() { }
}
