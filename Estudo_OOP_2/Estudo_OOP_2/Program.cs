class Pc
{
    public string marca, processador;
    public double preco;
    public int ram;

    public void Taxa_valor()
    {
        preco = preco + (preco * 0.08);
    }

    public string Classe_pc()
    {
        if(preco > 6000)
        {
            return "[PC GAMER]";
        }
        return "[PC MÉDIO OU DE ENTRADA]";
    }

    public int Ram_ideal(int ram)
    {
        ram = ram + 4;
        return ram;
    }

    public void Preco_ram(double preco)
    {
         preco = preco + 400;
         Console.WriteLine("O valor total com a ram recomendada é R${0}", Convert.ToDouble(preco) );
    }
}

class Program
{
    static void Main()
    {
        Pc pc = new Pc();

        Console.WriteLine("Qual a marca? ");
        string pc_marca = Console.ReadLine();

        Console.WriteLine("Qual o processador? ");
        string pc_processador = Console.ReadLine();

        Console.WriteLine("Qual o preço? ");
        int pc_preco = Convert.ToInt32(Console.ReadLine() );

        Console.WriteLine("Qual a RAM em gb? ");
        int pc_ram = Convert.ToInt32(Console.ReadLine() );

        pc.marca = pc_marca;
        pc.processador = pc_processador;
        pc.preco = pc_preco;
        pc.ram = pc_ram;

        Console.WriteLine("\n\n");
        Console.WriteLine("Marca: {0} | Processador: {1} | Preço: {2} | Ram: {3}gb",
                           pc.marca,pc.processador,pc.preco,pc.ram);

        Console.WriteLine("\n\n");
        pc.Taxa_valor();
        Console.WriteLine("O valor do PC com taxa é: {0}",pc.preco);

        Console.WriteLine("\n\n");
        Console.WriteLine(pc.Classe_pc() );

        Console.WriteLine("\n\n");
        Console.WriteLine("Você tem {0}gb de ram! O ideal para seu pc é {1}gb!"
            ,pc.ram
            ,pc.Ram_ideal(pc.ram) );

        Console.WriteLine("\n\n");
        pc.Preco_ram(pc.preco);

    }
}