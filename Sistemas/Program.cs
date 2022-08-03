// See https://aka.ms/new-console-template for more information

namespace aula_fullstack{
    
class Program{
    static void Main(string[] args)
    {
        Pessoa Pessoa1 = new Pessoa();
        Pessoa caique = new Pessoa();
        Pessoa andre = new Pessoa();
        Pessoa lucas = new Pessoa();
        Pessoa raffael = new Pessoa();


        Pessoa1.Endereco = "qualquercoisa";
        Pessoa1.nome = "Kleber";

        Console.WriteLine(Pessoa1.Endereco);
        Console.WriteLine(Pessoa1.nome);
    }
    
 }


}

