Console.WriteLine("Digite o numero de um mes:");
int n1 = int.Parse(Console.ReadLine());

switch (n1)
{
    case 1:
    Console.WriteLine("JANEIRO tem 31 dias");
    break;
    case 2:
    Console.WriteLine("FEVEREIRO tem 28 dias");
    break;
    case 3:
    Console.WriteLine("MARÇO tem 31 dias");
    break;
    case 4:
    Console.WriteLine("ABRIL! tem 30 dias");
    break;
    case 5:
    Console.WriteLine("MAIO tem 31 dias");
    break;
    case 6:
    Console.WriteLine("JUNHO tem 30 dias");
    break;
    case 7:
    Console.WriteLine("JULHO tem 31 dias");
    break;
    case 8:
    Console.WriteLine("AGOSTO tem 31 dias");
    break;
    case 9:
    Console.WriteLine("SETEMBRO tem 30 dias");
    break;
    case 10:
    Console.WriteLine("OUTUBRO tem 31 dias");
    break;
    case 11:
    Console.WriteLine("NOVEMBRO tem 30 dias");
    break;
    case 12:
    Console.WriteLine("DEZEMBRO tem 31 dias");
    break;
    default:
    Console.WriteLine("Dia invalido");
    break; }