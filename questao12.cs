Console.WriteLine("Digite um número positivo");
        int w = int.Parse(Console.ReadLine());


        if (w <= 0)
        {
            Console.WriteLine("Por favor, insira um número positivo.");
            return;
        }


        Console.WriteLine($"Aqui estão os {w} primeiros números da sequência de Fibonacci:");
        for (int i = 0; i < w; i++)
        {
            Console.Write(Fib(i) + " ");
        }
        Console.WriteLine(); 
    int Fib(int n)
    {
        if (n <= 1)
            return n;
       
        int a = 0, b = 1, c;


        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }


        return b;
    }
