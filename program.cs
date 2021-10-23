using System;

namespace cadastroPessoa
{
    class program
    {
        static void Main(string[] args)
        {
            PessoaFisica pF = new PessoaFisica();
            PessoaFisica novapF = new PessoaFisica();
            Endereco end = new Endereco(); 

            end.logradouro = "Rua x";
            end.numero = 789;
            end.complemento = "proximo ao hospital";
            end.enderecocomerci = false;

            novapF.endereco = end;
            novapF.cpf = "12345678901";
            novapF.dataNasci = new DateTime(2000, 26, 01);

            Console.WriteLine(novapF.endereco);
            Console.WriteLine(novapF.cpf);
            Console.WriteLine(novapF.dataNasci);
            
            
            

            bool idadeValida = pF.validarDataNascimento(novapF.dataNasci);

            if (idadeValida == true)
            {
                Console.WriteLine($"Cadastro concluido");
                
            } else {
                Console.WriteLine($"Falha no cadastro, não é possivel cadastrar pessoas menores de idade");

                
            }
                
        }
    }
}