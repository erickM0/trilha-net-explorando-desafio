using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

// Pessoa p1 = new Pessoa(nome: "Hóspede 1");
// Pessoa p2 = new Pessoa(nome: "Hóspede 2");

// hospedes.Add(p1);
// hospedes.Add(p2);

// Cria a suíte
 Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
 Reserva reserva = new Reserva();
 reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");


void opcaoIncluirHospedes(){
    bool showOpcao = true;
    int numeroHospedes ;
    string numeroHospedesTexto = "";
    while(showOpcao){
        Console.Clear();

        Console.WriteLine("Informe o número de Hospedes que seseja incluir\n");
        numeroHospedesTexto = Console.ReadLine();
        bool ehInt = int.TryParse(numeroHospedesTexto,out numeroHospedes);
         if(ehInt){
            if(numeroHospedes + reserva.ObterQuantidadeHospedes() > suite.Capacidade){
                Console.WriteLine($"O número de Hospedes é maior que a capacidade da suite {suite.TipoSuite}!\n"+
                "Digite qualquer tecla para voltar ao menu inicial.\n");

                Console.ReadKey();
                showOpcao = false;
            }
            else if(numeroHospedes < 1){
                Console.WriteLine($"O número de Hospedes precisa ser maior que 0!\n"+
                "Digite qualquer tecla para voltar ao menu inicial.\n");
                Console.ReadKey();
                showOpcao = false;
            }
            else{
                for(int index = 0; index < numeroHospedes; index ++){
                    Pessoa pessoa = new Pessoa();

                    Console.Clear();
                    Console.WriteLine($"Digite o nome do {index+1}º hospede\n");
                    
                    pessoa.Nome = Console.ReadLine();

                    if(pessoa.Nome != ""){
                        hospedes.Add(pessoa);
                    }else{
                         Console.WriteLine($"O nome do hospede não pode estar vazio!\n"+
                        "Digite qualquer tecla para voltar ao menu inicial.\n");
                        Console.ReadKey();
                        
                        index = numeroHospedes;
                    }
                }
                reserva.CadastrarHospedes(hospedes);
                showOpcao = false;
            }
         }
        else{
            Console.WriteLine($"converção do número {numeroHospedesTexto} {numeroHospedes} inválido!");
            Console.ReadKey();
            showOpcao = false;
        }
    }
}
void calcularValorDevido(){
    bool showOpcao = true;
    string quantidadeDiasText ="";
    int quantidadeDias;
    while(showOpcao){
        Console.Clear();
        Console.WriteLine("Informe a quantidade de dias reservados:");
        quantidadeDiasText = Console.ReadLine();
        if(int.TryParse(quantidadeDiasText, out quantidadeDias) && quantidadeDias > 0){
            reserva.DiasReservados = quantidadeDias;
            Console.WriteLine($"\nO valor devido é R${reserva.CalcularValorDiaria()}");
            Console.WriteLine("\nPressione Pressione qualquer tecla para retornar ao menu anterior.");
            Console.ReadKey();
        }else{
            Console.WriteLine("\nNúmero de dias inválido!");
            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu anterior.");
            Console.ReadKey();
        }
        showOpcao = false;

    }
}




bool showMenu = true;
while(showMenu){
    Console.Clear();
    Console.WriteLine("----------------------------------");
    Console.WriteLine("|      Sistema de Reservas       |");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("| código |         opção         |");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("|    1   |     Incluir Hospede   |");
    Console.WriteLine("|    2   | Calcular Valor Devido |");
    Console.WriteLine("|    3   |           Sair        |");
    Console.WriteLine("----------------------------------\n");

    Console.WriteLine("Digite o código da opção desejada:");

    switch(Console.ReadLine()){
        case "1":
            // Console.Clear();
            // Console.WriteLine("\nOpção Incluir Hospede não está disponível.");
            // Console.WriteLine("Digite qualquer tecla para continuar\n\n");
            // Console.ReadKey();

            opcaoIncluirHospedes();

        break;

        case "2":
            Console.Clear();
            if(reserva.ObterQuantidadeHospedes() > 0){
                calcularValorDevido();
            }
            else{
                Console.WriteLine("Não existem hospedes cadastrados nessa reserva!\n");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                Console.ReadKey();                
            }
            Console.ReadKey();


        break;

        case "3":
            Console.Clear();
            Console.WriteLine("\nObrigado por usar o Sistema de Reservas");
            Console.WriteLine("Digite qualquer tecla para sair\n\n");
            Console.ReadKey();
            showMenu = false;

        break;

        default:
            Console.Clear();
            Console.WriteLine("\nOpção inválida!");
            Console.WriteLine("Digite qualquer tecla para continuar\n\n");
            Console.ReadKey();
        break;
    }
}