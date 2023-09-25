
Console.WriteLine("Digite o Valor de X:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o Valor de Y:");
int y = int.Parse(Console.ReadLine());

// exemplos de operadores aritmeticos

int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;  //calcalando o se o numero é par ou impar
int restoYdiv2 = y % 2;



// console para exibir na tela as variaveis em cada linha 
// soma: 15

Console.WriteLine($"A soma de {x} com {y} ter seu resultado igual {soma}");
Console.WriteLine($"A subtraindo o valor de {x} com {y} ter seu resultado igual {subtracao}");
Console.WriteLine($"A a multiplicação de {x} com {y} ter seu resultado igual {multiplicacao}");
Console.WriteLine($"A divisão de {x} com {y} ter seu resultado igual {divisao}");
Console.WriteLine($"O resto de {x} com {y} ter seu resultado igual {resto}");

if (restoDiv2 == 0)
{
    Console.WriteLine($" O numero {x} é par");
}
else
{
    Console.WriteLine($" O numero {x} é impar");
}

if (restoYdiv2 == 0)
{
    Console.WriteLine($" O numero {y} é par");
}
else
{
    Console.WriteLine($" O numero {y} é impar");
}

// string sede = "tomar agua";
// string nomeP = Console.ReadLine();
// Console.WriteLine($"{nomeP} precisar ir {sede}");


//operador ternario
// condição ? se verdade: senão
string resultado = (restoYdiv2 == 0) ? $"O numero {y} é par" : $" O numero {y} é impar";
Console.WriteLine("resultado");

int diaSemana = 3;
// aprendendo o Switch case
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje é domingo");
        break;
    case 2:
        Console.WriteLine("Hoje é segunda");
        break;
    case 3:
        Console.WriteLine("Hoje é terça");
        break;
      case 4:
        Console.WriteLine("Hoje é quarta");
        break;
        case 5:
        Console.WriteLine("Hoje é quinta");
        break;
          case 6:
        Console.WriteLine("Hoje é sexta");
        break;
            case 7:
        Console.WriteLine("Hoje é sabado");
        break;
      
};