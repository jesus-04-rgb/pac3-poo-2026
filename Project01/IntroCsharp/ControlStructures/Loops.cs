using System.Data;

namespace Project01.IntroCsharp.ControlStructures
{
    public class Loops
    {
      string[] products = { "Laptop", "Mouse", "Keyboard", "Monitor", "Printer" };
        public void ForEach()
        {
            // for (int i = 0; i <= 3; i++)
            // {
            //     Console.WriteLine($"Producto: {products[i]}");
            // }
            foreach (string product in products)
            {
                Console.WriteLine(product);
            }
        }
      public void For()
        {
           
            for(int i = 1; i <= 5 ; i++ )
            {
                Console.WriteLine($"Iteración: {i}");
            }
        }  
        public void ForDesc()
        {
            for(int i = 5; i >= 1 ; i-- )
            {
                Console.WriteLine($"Iteración: {i}");
            }
        }
    public void Multiply(int number)
        {
            for (int j = 1; j <= 12; j++)
            {
              Console.WriteLine($"{j} x {number} = {j * number}"); 
            }
        
        }
    public void MultiplyLimit(int number, int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }
    public void While()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine($"Iteración: {i}");
                i++;
            }
        }
    public void WhileMultiply(int number)
        {
            int i = 1;
            while (i <= 12)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
                i++;
            }
        }
     public void DescWhile()
        {
            int i = 5;
            while (i >= 1)
            {
                Console.WriteLine($"Iteración: {i}");
                i--;
            }
        }
        public void whileLimit(int number, int limit)
        {
            int i = 1;
            while (i <= limit)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
                i++;
            }
        }
            public void PrintNumberPyramid(int n)
        {
            int digits = n.ToString().Length;
            

            for(int row = 1; row < n; row++)
            {
                for(int space = 1; space < n - row; space++)
                {
                    Console.Write(" ");
                }
            for(int number = 1; number<=row; number++)
            {
              Console.Write(number.ToString().PadLeft(digits, '0'));
               if(number < row) Console.Write(" "); 
            }
            Console.WriteLine();
        }
    
        }
    public void WhilePrintNumberPyramid (int n)
        {
          n = n * 2 - 1;
          int row = 1;
            while (row < n)
            {
                int space = 1;
                while (space < n - row)
                {
                    Console.Write(" ");
                    space++;
                }
                int number = 1;
                while (number <= row)
                {
                    Console.Write(number.ToString().PadLeft(2, '0'));
                    if (number < row) Console.Write(" ");
                    number++;
                }
                Console.WriteLine();
                row++;
            }   
        }
    
     }  
}
