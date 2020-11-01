using System;
using System.IO;

class Pessoa
{
    public string nome;
    public int data_nasc;
    public long cpf;
    public string email;
    public long fone;
    public string senha;
    
    public virtual void Cadastro ()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine ("Cadastro realizado com sucesso..");
        Console.ResetColor();
    }
    
    public virtual void Login ()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine ("Login realizado com sucesso..");
        Console.ResetColor();
        Console.WriteLine("Bem vindo ao sistema !");
        Console.WriteLine();
    }
}

class Programa
{
    enum Assinaturas
    {
        Kids,
        Ciência,
        Ficção,
        Terror,
        Literatura_Brasileira,
        Premium
    }
    
    static void Teste(string emailuser, string senhauser)
    {
        string [] user_aut = {"preshugo737@gmail.com", "anna@gmail.com", "felipe@gmail.com", "julia@gmail.com", "gabriel@gmail.com", "banca@gmail.com", "gui@gmail.com", "paulera@gmail.com", "gustavo@gmail.com", "giovana@gmail.cm"};
        string [] user_senha = {"vitor2004", "analegal", "ofelipe12", "julia234", "gabrielzinho06", "bianca2020", "guiincrível", "paulo2020", "gustavo2004", "giovana2003"};
        
        bool aut = false;
        int i;
        for (i=0; i<10; i++)
        
        if (user_aut[i] == emailuser && user_senha[i] == senhauser)
        {
            aut = true;
        }
     
        if (aut == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ("ACESSO NEGADO");
            Environment.Exit(0);
            Console.ResetColor();
        }
        
        else if (aut == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ("ACESSO AUTORIZADO");
            Console.ResetColor();
        }
    }    
    static void Recomendação()
    {
        Console.WriteLine();
        Console.Write("Gostou da recomendação? (S/N): ");
        string recomend = Console.ReadLine().ToUpper();
        if(recomend == "S")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ficamos feliz que tenha gostado de nossa recomendação! Até a próxima!");
            Console.ResetColor();
            Environment.Exit(0);
        }
        
        else if(recomend == "N")
        {
            Console.WriteLine("Poxa! Sentimos muito por não ter gostado de nossa recomendação, apresentaremos a seguir um menu para escolher manualmente sua assinatura desejada!");
            Menu();
        }
        
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
    static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\t\t\t   ____________________");
        Console.WriteLine("\t\t\t  |MENU DE ASSINATURAS| ");
        Console.WriteLine("__________________________|                   |___________________________________"); 
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("|K => ASSINATURA KIDS: Esta assinatura é destinada ao Público Infantil,           |"); 
        Console.WriteLine("|   com o intuito de cultivar a leitura desde cedo. Na assinatura Kids, seu       |");
        Console.WriteLine("|   filho pode ler ilimitadamente os livros e quadrinhos de infanto juvenil       |"); 
        Console.WriteLine("|   disponíveis na plataforma!                                                    |");
        Console.WriteLine("|                                                                                 |");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("|C => ASSINATURA CIÊNCIA: Tal assinatura tem como grande objetivo a divul-        |"); 
        Console.WriteLine("|   gação científica. Acreditamos que levar a ciência aos leitores é a nossa      |"); 
        Console.WriteLine("|   forma de mudar o mundo. Esse plano contêm livros, revistas e biografias       |");
        Console.WriteLine("|   de grandes autores do ramo.                                                   |");
        Console.WriteLine("|                                                                                 |");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("|F => ASSINATURA FICÇÃO: Durante nossa amizade, você poderá se aventurar          |");
        Console.WriteLine("|   nos mais diversos universos criativos da literatura, de Harry Potter a        |");
        Console.WriteLine("|   Senhor dos Anéis, se divirta sem moderação.                                   |");
        Console.WriteLine("|                                                                                 |");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("|T => ASSINATURA TERROR: Para os leitores corajosos da plataforma, temos          |");
        Console.WriteLine("|   uma estante virtual recheada de suspense. Na assinatura Terror, você terá     |"); 
        Console.WriteLine("|   acesso as grandes obras do Terror internacional. Recomendamos tirar as        |"); 
        Console.WriteLine("|   crianças da sala!                                                             |");
        Console.WriteLine("|                                                                                 |");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("|LB => ASSINATURA LITERATURA BRASILEIRA: Não poderíamos incentivar a leitura      |"); 
        Console.WriteLine("|   sem nos orgulhar de nossos autores. Para os amantes da literatura brasilei-   |");
        Console.WriteLine("|   ra, preparamos esse plano com muito carinho para vocês.                       |");
        Console.WriteLine("|                                                                                 |");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("|P => ASSINATURA PREMIUM: Para os leitores campeões, temos a assinatura Premium,  |"); 
        Console.WriteLine("|   onde você encontra toda e qualquer obra disponível em nossa plataforma.\"O     |");
        Console.WriteLine("|   homem que não lê bons livros não tem nenhuma vantagem sobre o homem que não   |");
        Console.WriteLine("|   sabe ler\"~ Mark Twain.                                                        |");
        Console.WriteLine("|________________________________________________________________________________ |");
        Console.ResetColor();
        
        Console.Write("Escolha sua opção de assinatura: ");
        string op = Console.ReadLine().ToUpper();
        
        Assinaturas tip_assin;
        
        switch(op)
        { 
            case "K":
                tip_assin = Assinaturas.Kids;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Assinatura: " + tip_assin + ".");
                Console.ResetColor();
                Console.WriteLine("Preço mensal: R$9,99");
                Console.WriteLine();
                Console.WriteLine("=> A seguir estão algumas sugestões de livros desta categoria!");
                Console.WriteLine("=> As aventuras de Mike - Gabriel Dearo · Manu Digilio ");
                Console.WriteLine("=> Capitão Cueca - David Soren");
                Console.WriteLine("=> Diário de um Banana - Jeff Kinney");
                Console.WriteLine("=> O Diário de Gravity Falls - Alex Hirsch");
                Console.WriteLine("=> O Mágico de Oz - Victor Fleming · George Cukor");
                Console.WriteLine("=> O Menino, seu avô e a Árvore da vida - José Bortolini");
                Console.WriteLine("=> O Pequeno Príncipe - Antoine de Saint-Exupéry");
                Console.WriteLine("=> Os Três Mosqueteiros - Alexandre Dumas");
                Console.WriteLine("=> Peter Pan - J. M. Barrie");
                Console.WriteLine("=> Romeu e Julieta - William Shakespeare");
                Console.WriteLine();
                break;
               
            case "C":
                tip_assin = Assinaturas.Ciência;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Assinatura: " + tip_assin + ".");
                Console.ResetColor();
                Console.WriteLine("Preço mensal: R$29,99");
                Console.WriteLine();
                Console.WriteLine("A seguir estão algumas sugestões de livros desta categoria!");
                Console.WriteLine("=> As respostas de um astrofísico -  Neil deGrasse Tyson");
                Console.WriteLine("=> Buracos Negros - Stephen Hawking");
                Console.WriteLine("=> Homo Deus - Yuval Harari");
                Console.WriteLine("=> Matéria Escura - Blake Crouch");
                Console.WriteLine("=> O Cérebro Ansioso - Leandro Teles");
                Console.WriteLine("=> O Gene Egoísta - Richard Dawkins");
                Console.WriteLine("=> O Universo numa casca de noz - Stephen Hawking");
                Console.WriteLine("=> Rápido e Devagar -  Daniel Kahneman");
                Console.WriteLine("=> Sapiens - Yuval Harari");
                Console.WriteLine("=> Uma breve história do tempo - Stephen Hawking");
                Console.WriteLine();
                break;
               
            case "F": 
                tip_assin = Assinaturas.Ficção;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Assinatura: " + tip_assin + ".");
                Console.ResetColor();
                Console.WriteLine("Preço mensal: R$19,99");
                Console.WriteLine();
                Console.WriteLine("A seguir estão algumas sugestões de livros desta categoria!");
                Console.WriteLine("=> A Máquina do Tempo - H.G. Wells");
                Console.WriteLine("=> Angústia - Graciliano Ramos");
                Console.WriteLine("=> Apanhador no Campo de Centeio - J.D. Salinger");
                Console.WriteLine("=> Caixa de Pássaros - Josh Malerman");
                Console.WriteLine("=> Crime e Castigo - Fiódor Dostoiévski");
                Console.WriteLine("=> Flores para Algernon - Daniel Keyes");
                Console.WriteLine("=> Laranja Mecânica - Anthony Burgess");
                Console.WriteLine("=> Ressureição - Liev Tolstói");
                Console.WriteLine("=> Saga Harry Potter - J.K. Rowling");
                Console.WriteLine("=> Sherlock Holmes - Sir Arthur Conan Doyle");
                Console.WriteLine();
                break;
               
            case "T":
                tip_assin = Assinaturas.Terror;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Assinatura: " + tip_assin + ".");
                Console.ResetColor();
                Console.WriteLine("Preço mensal: R$19,99");
                Console.WriteLine();
                Console.WriteLine("A seguir estão algumas sugestões de livros desta categoria!");
                Console.WriteLine("=> Carrie, a Estranha - Stephen King");
                Console.WriteLine("=> Cemitério Maldito - Stephen King");
                Console.WriteLine("=> Coraline - Neil Gaiman");
                Console.WriteLine("=> Goosebumps - R.L Stine");
                Console.WriteLine("=> It a Coisa - Stephen King");
                Console.WriteLine("=> O Demonologista - Andrew Pyper");
                Console.WriteLine("=> O Exorcista - William Friedkin");
                Console.WriteLine("=> O Iluminado - Stephen King");
                Console.WriteLine("=> O Menino que Desenhava Monstros - Keith Donohue");
                Console.WriteLine("=> Psicose - Alfred Hitchcock");
                Console.WriteLine();
                break;
                    
            case "LB":
                tip_assin = Assinaturas.Literatura_Brasileira;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Assinatura: " + tip_assin + ".");
                Console.ResetColor();
                Console.WriteLine("Preço mensal: R$34,99");
                Console.WriteLine();
                Console.WriteLine("A seguir estão algumas sugestões de livros desta categoria!");
                Console.WriteLine("=> A Escrava Isaura - Bernardo Guimarães");
                Console.WriteLine("=> Dom Casmurro - Machado de Assis");
                Console.WriteLine("=> Iracema - José de Alencar");
                Console.WriteLine("=> Macunaíma - Mário de Andrade");
                Console.WriteLine("=> Memórias Póstumas de Brás Cubas - Machado de Assis");
                Console.WriteLine("=> O Ateneu - Raul Pompeia");
                Console.WriteLine("=> O Cortiço - Aluísio Azevedo");
                Console.WriteLine("=> O Guarani - José de Alencar");
                Console.WriteLine("=> O Homem que sabia Javanês - Lima Barreto");
                Console.WriteLine("=> Os Sertões - Euclides da Cunha");
                Console.WriteLine();
                break;
               
            case "P":
                tip_assin = Assinaturas.Premium;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Assinatura: " + tip_assin + ".");
                Console.ResetColor();
                Console.WriteLine("Preço mensal: R$69,99");
                Console.WriteLine();
                Console.WriteLine("Já para você, nosso leitor de carteirinha, fique tranquilo.\n Com o plano Premium você terá acesso a todos os livros presentes em nossa plataforma, \nindependente de gênero ou preço. Se divirta!");
                Console.WriteLine();
                break;
               
            default:
                Console.WriteLine("Tipo de Opção Inválida, insira novamente!");
                Menu();
                break;
        }
        Console.Write("Deseja escolher novamente (N) ou deseja sair do sistema (S)?: ");
        string sn = Console.ReadLine().ToUpper();
        if(sn == "S")
        {
           Console.WriteLine("Até a próxima!");
           Environment.Exit(0);
        }
        
        else if(sn == "N")
        {
            Menu();
        }
        
        else
        {
           Console.WriteLine("Opção invalida!");
           Menu();
        }
    }

    static void Main ()
    {
        Pessoa user = new Pessoa();
        Pessoa confirmcad = new Pessoa();
        Pessoa confirmlog = new Pessoa();
        
        Console.WriteLine("\tBEM-VINDO AO NOSSO SITE!");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("     L'itteratura: Leia e Enriqueça!\n");
        Console.ResetColor();
        Console.Write("Você já possui um login (L) ou deseja cadastrar-se (C)?: ");
        string opç = Console.ReadLine().ToUpper();
        Console.Clear();
        
        switch (opç)
        {
            case "L":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t***SESSÃO DE LOGIN***\n");
                Console.ResetColor();
                Console.Write("Digite seu email: ");
                user.email = Console.ReadLine();
             
                Console.Write("Digite sua senha: ");
                user.senha = Console.ReadLine();
                Teste(user.email,user.senha);
                
                confirmlog.Login();
                break;
             
            case "C":
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t***SESSÃO DE CADASTRAMENTO***\n");
                Console.ResetColor();
                string path = @"C:\vitor\exercicio.txt";
              
                Console.Write("Digite seu nome: ");
                user.nome = Console.ReadLine();
              
                Console.Write("Digite sua data de nascimento: ");
                user.data_nasc = Convert.ToInt32(Console.ReadLine());
             
                Console.Write("Digite seu CPF: ");
                user.cpf = Convert.ToInt64(Console.ReadLine());
              
                Console.Write("Digite seu email: ");
                user.email = Console.ReadLine();
               
                Console.Write("Digite uma senha: ");
                user.senha = Console.ReadLine();
                
                Console.Write("Digite seu n° de telefone: ");
                user.fone = Convert.ToInt64(Console.ReadLine());
             
                Console.WriteLine();
                confirmcad.Cadastro();
                Console.WriteLine("Nome: " + user.nome);
                Console.WriteLine("Data de Nascimento: " + user.data_nasc);
                Console.WriteLine("CPF: " + user.cpf);
                Console.WriteLine("Email: " + user.email);
                Console.WriteLine("Senha: " + user.senha);
                Console.WriteLine("Telefone: " + user.fone + "\n");
                if(!File.Exists(path))
                {
                    string arqv = user.nome + ", " + user.data_nasc + ", " + user.cpf + ", " + user.email + ", " + user.senha + ", " + user.fone + "\n";
                    File.WriteAllText(path,arqv);
                }
                
                else
                {
                    string arqv = user.nome + ", " + user.data_nasc + ", " + user.cpf + ", " + user.email + ", " + user.senha + ", " + user.fone + "\n";                        
                    File.AppendAllText(path,arqv);
                }
                Console.Write("Pressiona ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
                break;
             
            default:
                Console.WriteLine("Opção Inválida!");
                Environment.Exit(0);
                break;
        }
        
        int laço = 0;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("__________________________________");
        Console.WriteLine("|      ***MENU DE OPÇÕES***      |");
        Console.WriteLine("|                                |");
        Console.WriteLine("|1 - Escolha uma Assinatura      |");
        Console.WriteLine("|2 - Recomendação por Interesses |");
        Console.WriteLine("|3 - Sair do Sistema             |");
        Console.WriteLine("|________________________________|");
        Console.ResetColor();
        Console.Write("Escolha uma opção: ");
        int escolha = Convert.ToInt32(Console.ReadLine().ToUpper());
        
        if(escolha == 1)
        {
            while( laço == 0)
            {
                Menu();
            }
        }
         
        else if(escolha == 2)
        {
            Console.Write("Por favor, nos informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            if(idade<8) 
            {
                Console.WriteLine("\nDe acordo com nossa bola de cristal,\nrecomendamos o plano Kids para você!\nNele você encontra divertidos livros\ne HQ's de Infanto Juvenil.\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Assinatura: Kids.");
                Console.WriteLine("Preço mensal: R$9,99\n");
                Console.ResetColor();
                Recomendação();
                Environment.Exit(0);
            }
            
            else if (idade>8 && idade<12)
            {
                Console.WriteLine("\nChecamos aqui na nossa nave espacial e te recomendamos o plano Ciência.\nFomentar o interesse pela ciência nessa idade te trará grandes frutos.\nTalvez até a fórmula secreta do hambúrguer de siri, rsrsr.\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Assinatura: Ciência.");
                Console.WriteLine("Preço mensal: R$29,99\n");
                Console.ResetColor();
                Recomendação();
                Environment.Exit(0);
            }
            
            Console.WriteLine("\n<------------------------------------------------------------->");
            Console.WriteLine("|Por favor, responda as próximas questões com sinceridade     |\n|para que possamos te recomendar a melhor assinatura possível.|");
            Console.WriteLine("<------------------------------------------------------------->\n");
           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*Orientação: Digite a sigla (entre parênteses) da sua escolha em cada pergunta*\n");
            Console.ResetColor();
            Console.Write("\nUma tarde de domingo em família, você ficou responsável \npelo filme que todos irão assistir, qual você escolheria\nentre: As Crônicas de Nárnia (CN), It, a Coisa (IC),\nInterestelar (I) ou Harry Potter (HP): " );
            string filme = Console.ReadLine().ToUpper();
          
            Console.Write("\nEm uma questão de vida ou morte, quem você salvaria,\nStephen King (SK) ou Machado de Assis (MA)?: ");
            string autor = Console.ReadLine().ToUpper();
            
            Console.Write("\nSe por ventura você pudesse ser qualquer uma\ndessas profissões: Astronauta (A), Analista\nde CyberSegurança (CS) ou Sociólogo (S), qual você seria? Seja sincero. Estamos de olho rsrs. " );
            string profissao = Console.ReadLine().ToUpper();
           
            if (filme == "I" && idade>=13 && profissao == "A")
            {
                Console.WriteLine("\nConversamos com aquela tia que só te presenteia com cuecas\ne ela nos confirmou que você é apaixonado por ciência, por isso,\nficamos muito felizes em te recomendar este plano.\n\"Que a força esteja com você!\".");
                Recomendação();
            }
            
            else if(idade>=16 && autor == "MA" && profissao == "S")
            {
                Console.WriteLine("\nA leitura nos abre portas, nos ensina, nos emociona. É com grande prazer e entusiasmo\nque te recomendamos o plano Literatura Brasileira. Com esta assinatura você têm acesso\na grandes clássicos de nossa história.\n\n\"O que vale na vida não é o ponto de partida e sim a caminhada. Caminhando e semeando,\nno fim terás o que colher\". Cora Coralina. ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Assinatura: Literatura Brasileira.");
                Console.WriteLine("Preço mensal: R$34,99");
                Console.ResetColor();
                Recomendação();
            }
            
            else if(idade>18 && filme == "IC" && autor == "SK")
            {
                Console.WriteLine("\nViemos de carona com a turma de Hopkins para te avisar\nque o plano ideal para você se chama TERRRRORR.\nEssa assinatura te permite acesso ilimitado\n-enquanto os zumbis não te devorarem-\nà grandes obras internacionais do gênero. " );
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Assinatura: Terror.");
                Console.WriteLine("Preço mensal: R$19,99");
                Console.ResetColor();
                Recomendação();
            }
            
            else if (idade>14 && filme == "HP" && profissao == "CS")
            {
                Console.WriteLine("\nGaláxias, governos malignos, super heróis, cidades macabras ou uma Casa que te devora, rsrs.\nPercebemos que você adora se desligar da sua realidade, nem que seja por 10 minutos, para se\nencantar em diversos universos paralelos que a leitura nos possibilita.\nPor isso, lhe recomendamos o plano Ficção." );
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Assinatura: Ficção.");
                Console.WriteLine("Preço mensal: R$19,99");
                Console.ResetColor();
                Recomendação();
            }
            
            else 
            {
                Console.WriteLine("\nOps, algo deu errado, tente novamente.");   
            }
        }
        
        else if( escolha == 3)
        {
            Console.WriteLine("Saiu do sistema com sucesso!");
            Environment.Exit(0);
        }
        
        else
        {
            Console.WriteLine("Opção Inválida!");
            Environment.Exit(0);
        }
    }
}
