namespace aula_fullstack
{
    public abstract class Pessoa
    {
        //Atributos
       public string? nome { get; set; } 
       public string? Endereco { get; set; }
       
       //Metodos
       public abstract void PagarImposto();
    }
}