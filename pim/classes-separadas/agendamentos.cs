class Agendamentos
{
    public DateTime Data_agendamento { get; set; }
    public DateTime Hora_agendamento { get; set; }
    public string Id_agendamento { get; set; }
    public string Descricao { get; set; }

    public Procedimento proc;
    public Pet pet;
    public Veterinario vet;
    public Recepcao rec;
    public Petshop petshop;
    public Agendamentos() //Constructor
    {
        Data_agendamento = new DateTime(2022, 01, 01);
        Hora_agendamento = new DateTime(0, 0);
        Id_agendamento = "";
        Descricao = "";
        proc = new Procedimento();
        pet = new Pet();
        vet = new Veterinario();
        rec = new Recepcao();
        petshop = new Petshop();
    }
    //Métodos CRUD para Agendamentos
    public void Add_Agend() { }
    public void Editar_Agend() { }
    public void Excluir_Agend() { }
    public void Ver_Agend() { }
}
