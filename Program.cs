
            Console.WriteLine("--- Operadores aritméticos");
            double x;
            double y;

            Console.WriteLine("Qual o valor de x ?");
             
            x=Convert.ToDouble(Console.ReadLine());   


            Console.WriteLine("Qual o valor de y ?");

            y=Convert.ToDouble(Console.ReadLine());

            double soma = x + y;
            double diferenca = x - y;
            double produto = x * y;
            double quociente = x / y;

            double exponencial = Math.Pow(x,y);
            double radiciação = Math.Sqrt(x);

            Console.WriteLine($"{x} + {y} = {soma}");
            Console.WriteLine($"{x} - {y} = {diferenca}");
            Console.WriteLine($"{x} * {y} = {produto}");
            Console.WriteLine($"{x} / {y} = {quociente}");
            Console.WriteLine($"{x} ^ {y} = {exponencial}");
            Console.WriteLine($"Raiz de {x} = {radiciação}");
            