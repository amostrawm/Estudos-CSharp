
namespace teste
{
    class Program()
    {
    struct Pessoa
    {
        string nome, cpf;
        int idade;
        float salario;
    }

    static void Main(String []args )
    {
        Pessoa[] ps = new Pessoa[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Escreva o nome.");
            ps[i].nome = Console.ReadLine();
            
        }
    }

}    
}