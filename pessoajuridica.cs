using System.IO;
using System.Collections.Generic;

namespace cadastroPessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        
        public string razaoSocial { get; set; }

        public string caminho { get; private set; } = "DataBase/PessoaJuridica.csv";

        public override double PagarImposto(float rendimento)
        {
            if (rendimento <= 5000)
          {
            return rendimento * .06; 

          }else if (rendimento > 5000 && rendimento <= 10000)
          {
            return (rendimento/100) * 8; 
         
          }else
          {
            return (rendimento/100) * 10;

          }

        }
        
        public bool ValidarCNPJ(string cnpj){

            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length - 6, 4) == "0001")
            {
                return true;

            }
            return false;
        }


      public string PrepararLinhasCsv(PessoaJuridica pJ){

            return $"{pJ.cnpj};{pJ.nome};{pJ.razaoSocial}";


        }

        public void Inserir(PessoaJuridica pJ){

            string[] linhas = {PrepararLinhasCsv(pJ)};

            File.AppendAllLines(caminho, linhas);

        }

        public List<PessoaJuridica> Ler(){

          List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

          string[] linhas = File.ReadAllLines(caminho);
          // não tem problema usar o msm nome por estar em metodos diferentes

          foreach (var cadalinha in linhas)
          {
            string[] atributos = cadalinha.Split(";");

            PessoaJuridica cadapj = new PessoaJuridica();

            cadapj.cnpj = atributos[0];
            cadapj.nome = atributos[1];
            cadapj.razaoSocial = atributos[2];

            listaPJ.Add(cadapj);
          }

          return listaPJ;

        }

    }
}