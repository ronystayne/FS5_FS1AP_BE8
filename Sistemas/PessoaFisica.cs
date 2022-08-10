namespace aula_fullstack
{
    public class PessoaFisica
    {
        public string? cpf { get; set; }

        public DateTime dataNascimento { get; set; }
        
        
          public override void PagarImposto(float rendimento){}

          public bool ValidarDataNascimento(DateTime){
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays /365;

            if (anos >=18){
                return true;
            }else
            {
                return false;
            }



          }
    }
}