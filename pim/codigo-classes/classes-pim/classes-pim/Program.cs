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
class Admin
{
    public Funcionario Adm;
    public Admin() //Constructor
    {    
        Adm = new Funcionario();
    }
}

class Veterinario
{
    public Funcionario fvet;
    public Veterinario() //Constructor
    {
        fvet = new Funcionario();
    }
}

class Recepcao
{
    public Funcionario frec;
    public Recepcao() //Constructor
    {
        frec = new Funcionario();
    }
}

class Petshop
{
    public Funcionario fpet;
    public Petshop() //Constructor
    {
        fpet = new Funcionario();
    }
}
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

