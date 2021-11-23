using System.IO; 

namespace cadastroPessoa
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        
        public Endereco endereco { get; set; }
        
        public float rendimento { get; set; }
        
        public abstract double PagarImposto(float salario);

        public void VerificarArquivo(string caminho){

            string pasta = caminho.Split("/")[0];
            //split = ele separa a string

            if(!Directory.Exists(pasta)) //O ponto de ! indica que inverteu o sentido( antes o if verificava se existia, agr verifica se não existe.)
            {
                Directory.CreateDirectory(pasta);

            } 

            if(!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }
}