using System;


namespace cadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }
        
        public DateTime dataNasci { get; set; }

        public override double PagarImposto(float rendimento)
        {
          if (rendimento <= 1500)
          {
            return 0; 

          }else if (rendimento > 1500 && rendimento <= 5000)
          {
            return (rendimento/100) * 3; 
         
          }else
          {
            return (rendimento/100) * 5;

          }
        }
          
          public bool ValidarDataNascimento(DateTime dataNasci){

              DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasci).TotalDays / 365;

            if (anos >= 18){
                return true;

            }
                return false;
          }
    }
}