Console.WriteLine("Digite seu Nome e sua Idade");
string[] ni = Console.ReadLine().Split(' ');
string nome = ni[0];
int idade = int.Parse(ni[1]);
Console.WriteLine($"Olá, {nome}, Você tem {idade} anos.");
