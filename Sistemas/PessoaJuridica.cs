namespace aula_fullstack
{
    public class PessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? RazaoSocial { get; set; }
        
        
        public override void PagarImposto(float rendimento){}

        public bool ValidarCNPJ (String cnpj){
            if(cnpj.Length>=14 && (cnpj.Substring(cnpj.Length - 4)) == "0001"){
                return true;
            }else{
                return false;
            }
        }
        
    }
}