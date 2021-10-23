namespace cadastroPessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        
        public string razaoSocial { get; set; }

        public override void PagarImposto(float salario){

        }
    }
}