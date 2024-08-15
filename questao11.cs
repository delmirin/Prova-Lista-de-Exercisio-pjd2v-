Console.WriteLine("Digite um número inteiro positivo x");
        int x = int.Parse(Console.ReadLine());
       
        if (x < 0)
        {
            Console.WriteLine("O número deve ser um inteiro positivo.");
        }
        else
        {
            int y = Fatorial(x);
            Console.WriteLine($"{x}! = {y}");
        }
   
          int Fatorial(int n)
    {
        if (n == 0)
            return 1;


        int resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
