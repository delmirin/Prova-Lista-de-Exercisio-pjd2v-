Console.WriteLine(" Digite sua idade");
int idade = int.Parse(Console.ReadLine());


if( idade < 16){
    Console.WriteLine("Menor de idade, não pode votar nem dirigir.");
}
else if(idade < 18 ){
    Console.WriteLine("Menor de idade,pode votar mas não dirigir.");
}
else {
    Console.WriteLine("Maior de idade,pode votar e dirigir.");
}