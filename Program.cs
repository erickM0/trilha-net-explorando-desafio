using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

// hospedes.Add(p1);
// hospedes.Add(p2);

// // Cria a suíte
// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 5);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

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
            Console.Clear();
            Console.WriteLine("\nOpção Incluir Hospede não está disponível.");
            Console.WriteLine("Digite qualquer tecla para continuar\n\n");
            Console.ReadKey();

        break;

        case "2":
            Console.Clear();
            Console.WriteLine("\nOpção Calcular Valor Devido não está disponível.");
            Console.WriteLine("Digite qualquer tecla para continuar\n\n");
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