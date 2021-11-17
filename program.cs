using System;
using System.Collections.Generic;
using System.Threading; 


namespace cadastroPessoa
{
    class program
    {
        static void Main(string[] args)
        {     
            string opcao; 
            List<PessoaFisica> Listapf = new List<PessoaFisica>();
            List<PessoaJuridica> Listapj = new List<PessoaJuridica>();

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
                  /            Pessoa Juridica                 / 
                  /         1- Cadastrar Pessoa Jurídica       /
                  /         2- Listar Pessoa Jurídica          /
                  /         3- Remover Pessoa Jurídica         /
                  /                                            /
                  /            Pessoa FIsica                   /
                  /         4- Cadastrar Pessoa Física         /
                  /         5- Listar Pessoa Física            /
                  /         6- Remover Pessoa Física           /
                  /                                            /
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

                                        Console.WriteLine($"Qual o seu nome/empresa?");
                                        novaPj.nome = Console.ReadLine();
                                        

                                        Console.WriteLine($"Digite seu logradouro:");
                                        endpj.logradouro = Console.ReadLine();

                                        Console.WriteLine($"Digite o número do seu logradouro:");
                                        endpj.numero = int.Parse(Console.ReadLine());
                                        
                                        Console.WriteLine($"Digite o complemento do seu logradouro(Se quiser manter vazio aperte Enter)");
                                        endpj.complemento = Console.ReadLine();
                                        
                                        Console.WriteLine($"Seu endereço é comercial? S/N");
                                        string Enderecocomercial = Console.ReadLine().ToUpper();
                                        
                                        if(Enderecocomercial == "S")
                                        {
                                            endpj.enderecocomerci = true;

                                        } else 
                                        {
                                            endpj.enderecocomerci = false; 
                                        }
                                        

                                        novaPj.endereco = endpj;

                                        Console.WriteLine($"Digite seu CNPJ:");
                                        novaPj.cnpj = Console.ReadLine(); 
                                        
                                        Console.WriteLine($"Digite seu rendimento:");
                                        novaPj.rendimento = int.Parse(Console.ReadLine());
                                        
                                        novaPj.razaoSocial = "pessoa juridica";
            
                                        if (!pJ.ValidarCNPJ(novaPj.cnpj))
                                        {
                                            Console.WriteLine($"CNPJ válido");
                                            Listapj.Add(novaPj);
                                            Console.WriteLine(pJ.PagarImposto(novaPj.rendimento).ToString("N2"));
                                         }
                                         else
                                        {
                                             Console.WriteLine("CNPJ inválido");
                                        }

                                        
                                        

                                        break;

                                case "2":

                                        foreach (var cadaItem in Listapj)
                                        {
                                            Console.WriteLine($"{cadaItem.nome}, {cadaItem.cnpj}");
                                            
                                        }

                                        break;

                                case "3":

                                        Console.WriteLine($"Digite o CNPJ que quer remover:");
                                        string cnpjprocurado = Console.ReadLine();

                                        PessoaJuridica PessoaEncontrada = Listapj.Find(cadaitem => cadaitem.cnpj == cnpjprocurado);
                                        if(PessoaEncontrada != null)
                                        {
                                            Listapj.Remove(PessoaEncontrada);
                                            Console.WriteLine($"Cadastro removido");
                                            

                                        }else{

                                            Console.WriteLine($"Cadastro não encontrado");
                                            
                                        }

                                        

                                        break;

                                case "4":
                                        PessoaFisica pF = new PessoaFisica();
                                        PessoaFisica novapF = new PessoaFisica();
                                        Endereco endpf = new Endereco();

                                        Console.WriteLine($"Digite seu logradouro:");
                                        endpf.logradouro = Console.ReadLine();
                                        
                                        Console.WriteLine($"Digite o número do seu logradouro:");
                                        endpf.numero = int.Parse(Console.ReadLine());
                                        
                                        Console.WriteLine($"Digite um complemento(aperte Enter se quiser manter vazio):");
                                        endpf.complemento = Console.ReadLine();
                                        Console.WriteLine($"Seu endereço é comercial? S/N ");
                                        string endComercial = Console.ReadLine().ToUpper();

                                        if (endComercial == "S")
                                        {
                                            endpf.enderecocomerci = true;
                                        }else{
                                            endpf.enderecocomerci = false; 
                                        }
                                        
            
                                        novapF.endereco = endpf;

                                        Console.WriteLine($"Digite seu CPF(somente números):");
                                        novapF.cpf = Console.ReadLine();
                                    
                                        Console.WriteLine($"Digite seu nome:");
                                        novapF.nome = Console.ReadLine();
                                        
                                        Console.WriteLine($"Qual o seu rendimento?(somente números)");
                                        novapF.rendimento = float.Parse(Console.ReadLine());

                                        Console.WriteLine($"Digite sua data de nascimento:");
                                        novapF.dataNasci = DateTime.Parse(Console.ReadLine());
    
                                        bool idadeValida = pF.ValidarDataNascimento(novapF.dataNasci);

                                        if (idadeValida == true)
                                        {

                                        Console.WriteLine($"Cadastro concluido");
                                        Listapf.Add(novapF);
                                        Console.WriteLine(pF.PagarImposto(novapF.rendimento));

                                        }
                                         else
                                        {

                                         Console.WriteLine($"Falha no cadastro, não é possivel cadastrar pessoas menores de idade");

                                        }

                                        
                                        


                                        break;

                                case "5":

                                foreach (var cadaitem in Listapf)
                                {
                                    Console.WriteLine($"{cadaitem.nome}, {cadaitem.cpf}, {cadaitem.endereco.logradouro}");
                                    
                                    
                                }


                                        break;

                                case "6":
                                        Console.WriteLine($"Digite o CPF que deseja remover");
                                        string cpfprocurado = Console.ReadLine();

                                        PessoaFisica Pessoaencontrada = Listapf.Find(cadaitem => cadaitem.cpf == cpfprocurado);
                                        if(Pessoaencontrada != null)
                                        {
                                            Listapf.Remove(Pessoaencontrada);
                                            Console.WriteLine($"Cadastro removido");
                                            

                                        }else{

                                            Console.WriteLine($"Cadastro não encontrado");
                                            
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