// See https://aka.ms/new-console-template for more information

namespace aula_fullstack{
    
    class Program{
    static void Main(string[] args)
    {
        Endereco end = new Endereco();
        end.logradouro = "Rua x";
        end.numero = 100;
        end.complemento = "Qualquer coisa";
        end.enderecoComercial = false;

        PessoaFisica pf = new PessoaFisica();
        pf.endereco = end;
        pf.nome = "Rony Stayne";
        pf.cpf = "5464165164156";
        pf.dataNascimento = new DateTime (1986, 06, 26);

            //interpolação
        console.WriteLine($" O {pf.nome} mora na {pf.endereco.logradouro} numero {pf.endereco.numero}
        ");
        //concatenação
        Console.WriteLine("O " + pf.nome + "mora na " + pf.endereco.logradouro);
        //forma não-inteligente
        Console.WriteLine(pf.endereco.logradouro);
        Console.WriteLine(pf.endereco.numero);
        Console.WriteLine(pf.endereco.complemento);
        Console.WriteLine(pf.endereco.enderecoComercial);

        bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

        if (idadeValida == true)
        {
            System.console.WriteLine("Cadastro Aprovado");
        }else{
            Console.WriteLine("Cadastro Reprovado");
        }

    }


}

