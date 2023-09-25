Console.WriteLine("Digite o Nome do Aluno");
string nomeA = Console.ReadLine();

Console.WriteLine("Digite a primeira nota");
int nP = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
int nS = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota final");
int nT = int.Parse(Console.ReadLine());



int mediaA = (nP + nS + nT) / 3;
Console.WriteLine($"A media do {nomeA} é igual {mediaA}");

if (mediaA >= 7){
    Console.WriteLine($"{nomeA} passou com a media de {mediaA}");
}
else{
    Console.WriteLine($"{nomeA} nao pode passar de ano com a {mediaA}");
}