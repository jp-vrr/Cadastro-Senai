using System;

namespace cadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }
        
        public DateTime dataNasci { get; set; }

        public override void PagarImposto(float salario)
        {

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