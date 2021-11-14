using System;
using System.Threading;

namespace cadastroPessoa
{
    class program
    {
        static void Main(string[] args)
        {     
            string opcao; 

            Console.Clear(); 
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($@"
            ====================================
            /     Bem vindo ao nosso Sistema   /
            /           de Cadastro            /
            /                                  /
            ====================================
             ");

             Console.ResetColor();
             Thread.Sleep(3000);
              
              Console.Clear();
              Console.ResetColor();

              do
              {
                  Console.ForegroundColor = ConsoleColor.DarkRed;
                  Console.WriteLine(@$"
                  ==============================================
                  /        Escolha uma opção a seguir:         /
                  ==============================================
                  /                                            /
                  /         1. Pessoa Juridica                 / 
                  /         2. Pessoa FIsica                   / 
                  /                                            / 
                  /         0. Sair                            /
                  /                                            / 
                  ==============================================
                  ");

                            opcao = Console.ReadLine();

                            switch(opcao)
                            {
                                case "1":


                                        Console.ResetColor();
                                        PessoaJuridica pJ = new PessoaJuridica();
                                        PessoaJuridica novaPj = new PessoaJuridica();
                                        Endereco endpj = new Endereco();

                                        endpj.logradouro = "Rua z";
                                        endpj.numero = 155;
                                        endpj.complemento = "loja de esquina";
                                        endpj.enderecocomerci = true;

                                        novaPj.endereco = "endpj";
                                        novaPj.cnpj = "12345678900001";
                                        novaPj.razaoSocial = "pessoajuridica";
            
                                        if (!pJ.ValidarCNPJ(novaPj.cnpj))
                                        {
                                            Console.WriteLine($"CNPJ válido");
                                         }
                                         else
                                        {
                                             Console.WriteLine("CNPJ inválido");
                                        }

                                                break;

                                case "2":
                                        PessoaFisica pF = new PessoaFisica();
                                        PessoaFisica novapF = new PessoaFisica();
                                        Endereco endpf = new Endereco();

                                        endpf.logradouro = "Rua x";
                                        endpf.numero = 789;
                                        endpf.complemento = "proximo ao hospital";
                                        endpf.enderecocomerci = false;
            
                                        novapF.endereco = "endpf";
                                        novapF.cpf = "12345678901";
                                        novapF.dataNasci = new DateTime(2000, 26, 01);
             
                                        Console.WriteLine(novapF.endereco);
                                        Console.WriteLine(novapF.cpf);
                                        Console.WriteLine(novapF.dataNasci);
                
                
                
                                        bool idadeValida = pF.ValidarDataNascimento(novapF.dataNasci);

                                        if (idadeValida == true)
                                        {

                                        Console.WriteLine($"Cadastro concluido");

                                        }
                                         else
                                        {

                                         Console.WriteLine($"Falha no cadastro, não é possivel cadastrar pessoas menores de idade");

                                        }


                                        break;

                                case "0":
                                        
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine($@"Obrigado por usar nosso sistema.");

                                        Console.Clear();
                                        Console.WriteLine($"Finalizando");
                                        Thread.Sleep(2000);

                                        break; 

                                default:
                                        Console.ResetColor();
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine($"Opção invalida, digite uma opção válida");
                                        break;
                                        
                            }
              } while (opcao != "0");
               
        }
    }
}