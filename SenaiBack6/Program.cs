// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SenaiBack6.Classes;

Console.WriteLine(@$"
=================================================
|       Bem vindo ao sistema de cadastro de     |
|           Pessoas Físicas e Jurídicas         |
=================================================
");

BarraCarregamento( "Carregando ", 500 );

List<PessoaFisica> listaPf = new List<PessoaFisica>();

List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;

do
{
    Console.Clear();

    Console.WriteLine(@$"
    =================================================
    |       Escolha uma das opções abaixo           |
    |-----------------------------------------------|
    |       1 - Pessoa Física                       |
    |       2 - Pessoa Jurídica                     |
    |                                               |
    |       0 - Sair                                |
    =================================================
    ");

    opcao = Console.ReadLine(  );

    switch( opcao )
    {
        case "1":

            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;

            do
            {
                Console.Clear();

                Console.WriteLine(@$"
                =================================================
                |       Escolha uma das opções abaixo           |
                |-----------------------------------------------|
                |       1 - Cadastrar Pessoa Física             |
                |       2 - Mostrar Pessoas Físicas             |
                |                                               |
                |       0 - Voltar ao menu anterior             |
                =================================================
                ");

                opcaoPf = Console.ReadLine();

                switch( opcaoPf )
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();

                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                    
                        novaPf.nome = Console.ReadLine();

                        // bool dataValida;

                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAAA");

                        //     string? dataNasc = Console.ReadLine();

                        //     dataValida = metodoPf.ValidarDataNascimento( dataNasc );

                        //     if( dataValida )
                        //     {
                        //         novaPf.dataNascimento = dataNasc;
                        //     }

                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;

                        //         Console.WriteLine( $"Data digitada inválida, por favor digite uma data válida" );

                        //         Console.ResetColor();
                        //     }
                        // } while( dataValida == false );

                        // Console.WriteLine($"Digite o número do CPF");

                        // novaPf.cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o rendimento mensal (Digite somente números)");

                        // novaPf.rendimento = float.Parse( Console.ReadLine() );

                        // Console.WriteLine($"Digite o logradouro");
                        
                        // novoEnd.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o número");
                        
                        // novoEnd.numero = int.Parse( Console.ReadLine() );

                        // Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        
                        // novoEnd.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereço é comercial? S/N");
                        
                        // string endCom = Console.ReadLine().ToUpper();

                        // if( endCom == "S" )
                        // {
                        //     novoEnd.endComercial = true;
                        // }

                        // else
                        // {
                        //     novoEnd.endComercial = false;
                        // }

                        // novaPf.endereco = novoEnd;

                        //listaPf.Add( novaPf );

                        //StreamWriter sw = new StreamWriter( $"{novaPf.nome}.txt" );

                        //sw.Write( novaPf.nome );

                        //sw.Close();

                        using ( StreamWriter sw = new StreamWriter( $"{novaPf.nome}.txt" ) )
                        {
                            sw.WriteLine( $"{novaPf.nome}" );
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine($"Cadastro realizado com sucesso!");

                        Thread.Sleep( 3000 );

                        Console.ResetColor();
                    
                        break;

                    case "2":

                        Console.Clear();

//                         if( listaPf.Count > 0 )
//                         {
//                             foreach( PessoaFisica cadaPessoa in listaPf )
//                             {
//                                 Console.Clear();

//                                 Console.WriteLine(@$"
// Nome: {cadaPessoa.nome}
// Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
// Data de nascimento: {cadaPessoa.dataNascimento}
// Taxa de imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
// ");

//                                 Console.WriteLine($"Aperte 'Enter' para continuar");
            
//                                 Console.ReadLine();
//                             }
//                         }

//                         else
//                         {
//                             Console.WriteLine($"Lista Vazia!");

//                             Thread.Sleep( 3000 );
//                         }

                            using ( StreamReader sr = new StreamReader( "Odirlei.txt" ) )
                            {
                                string linha;

                                while( ( linha = sr.ReadLine() ) != null )
                                {
                                    Console.WriteLine( $"{linha}" );
                                }
                            }

                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            
                            Console.ReadLine();
                            

                        break;
                
                    case "0":
                        break;
                
                    default:

                        Console.Clear();

                        Console.WriteLine($"Opção inválida, por favor digite outra opção.");

                        Thread.Sleep( 2000 );

                        break;
                }

            } 
            
            while( opcaoPf != "0" );

            break;

        case "2":

            PessoaJuridica metodoPj = new PessoaJuridica();

            string? opcaoPj;

            do
            {
                Console.Clear();

                Console.WriteLine(@$"
                =================================================
                |       Escolha uma das opções abaixo           |
                |-----------------------------------------------|
                |       1 - Cadastrar Pessoa Jurídica           |
                |       2 - Mostrar Pessoas Jurídicas           |
                |                                               |
                |       0 - Voltar ao menu anterior             |
                =================================================
                ");

                opcaoPj = Console.ReadLine();

                switch( opcaoPj )
                {
                    case "1" :

                        PessoaJuridica novaPj = new PessoaJuridica();

                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa jurídica que deseja cadastrar");
                        
                        novaPj.nome = Console.ReadLine();

                        bool dataValidaCnpj;

                        do
                        {
                            Console.WriteLine($"Digite o número do cnpj Ex: XX.XXX.XXX/0001-XX ou XXXXXXXX0001XX");

                            string? dataCnpj = Console.ReadLine();

                            dataValidaCnpj = metodoPj.validarCnpj( dataCnpj );

                            if( dataValidaCnpj )
                            {
                                novaPj.cnpj = dataCnpj;
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;

                                Console.WriteLine( $"CNPJ digitado inválido, por favor digite um CNPJ válido!" );

                                Console.ResetColor();
                            }
                        }

                        while( dataValidaCnpj == false );

                        Console.WriteLine($"Digite a razão social");
                        
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (Digite somente números)");

                        novaPj.rendimento = float.Parse( Console.ReadLine() );

                        Console.WriteLine($"Digite o logradouro");

                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");

                        novoEndPj.numero = int.Parse( Console.ReadLine() );

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");

                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N");

                        string endCom = Console.ReadLine().ToUpper();

                        if( endCom == "S" )
                        {
                            novoEndPj.endComercial = true;
                        }

                        else
                        {
                            novoEndPj.endComercial = false;
                        }

                        novaPj.endereco = novoEndPj;

                        listaPj.Add( novaPj );

                        metodoPj.Inserir( novaPj );

                        List<PessoaJuridica> lista2Pj = metodoPj.Ler();

                        foreach( PessoaJuridica cadaItem in lista2Pj )
                        {
                            Console.Clear();

                            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
");
                            Console.WriteLine($"Aperte 'Enter' para continuar");
            
                            Console.ReadLine();
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine($"Cadastro realizado com sucesso!");

                        Thread.Sleep( 3000 );

                        Console.ResetColor();

                        break;

                    case "2" :

                        Console.Clear();

                        if( listaPj.Count > 0 )
                        {
                            foreach( PessoaJuridica cadaPessoaJ in listaPj )
                            {
                                Console.Clear();

                                Console.WriteLine(@$"
Nome: {cadaPessoaJ.nome}
Razão social: {cadaPessoaJ.razaoSocial}
CNPJ: {cadaPessoaJ.cnpj}
Taxa de imposto a ser paga é: {metodoPj.PagarImposto(cadaPessoaJ.rendimento).ToString("C")}
");

                                Console.WriteLine($"Aperte 'Enter' para continuar");
            
                                Console.ReadLine();
                            }
                        }

                        else
                        {
                            Console.WriteLine($"Lista Vazia!");

                            Thread.Sleep( 3000 );
                        }

                        break;

                    case "0" :
                        break;

                    default :

                        Console.Clear();

                        Console.WriteLine($"Opção inválida, por favor digite outra opção.");

                        Thread.Sleep( 2000 );

                        break;
                }
            }

            while( opcaoPj != "0" );

            break;
    
        case "0":

            Console.Clear();

            Console.WriteLine($"Obrigado por utilizar nosso sistema.");

            BarraCarregamento( "Desligando ", 100 );

            Console.Clear();

            break;
    
        default:

            Console.Clear();

            Console.WriteLine($"Opção inválida, por favor digite outra opção.");

            Thread.Sleep( 2000 );

            break;
    }
}

while( opcao != "0" );

static void BarraCarregamento( string texto, int tempo )
{
    Console.BackgroundColor = ConsoleColor.Green;

    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write( $"{texto}" );

    for( var contador = 0; contador < 20; contador++ )
    {
        Console.Write( ". " );
        Thread.Sleep( tempo );
    }

    Console.ResetColor();
}
