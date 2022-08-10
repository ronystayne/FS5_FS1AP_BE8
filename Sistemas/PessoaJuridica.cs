namespace aula_fullstack
{
    public class PessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? RazaoSocial { get; set; }
        
        
        public override void PagarImposto(float rendimento){}
        
    }
}