int soma = 0;
        int numero;




        do
        {
            Console.Write("Digite um número (ou 0 para sair): ");
            numero = int.Parse(Console.ReadLine());


            if (numero != 0)
            {
                soma += numero;
            }
        }
        while (numero != 0);


       
        Console.WriteLine("A soma de todos os números digitados é: " + soma);






questão 10
Console.WriteLine("Digite o valor do dolar");
double dolar = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor a ser convertido");
double valor = double.Parse(Console.ReadLine());




double calculo = dolar * valor;
Console.WriteLine($"{calculo}");
