namespace Project01.IntroCsharp.Operators.Logic
{
    public class Compare
    {
        private int x = 20; 
        private int y = 0;

        private int z = 22;

        public void Valid()
        {
        Console.WriteLine( $"{x} es igual que {y} :" + (x == y));
        Console.WriteLine( $"{x} es diferente que {y} :" + (x != y));
        Console.WriteLine( $"{x} es mayor que {y} :" + (x > y));
        Console.WriteLine( $"{x} es menor que {y} :" + (x < y));
        Console.WriteLine( $"{x} es mayor o igual que {y} :" + (x >= y));
        Console.WriteLine( $"{x} es menor o igual que {y} :" + (x <= y));

        // && AND
        Console.WriteLine($"{z} es mayor que {x} y menor que {y}: " + (z > x && z < y));
           // || OR
           Console.WriteLine($"{z} es mayor que {x} o menor que {y}: " + (z > x ||z < y));

           //Interpolación de strings
              Console.WriteLine($"{z} es mayor que {x} y menor que {y}: {z > x && z < y}");

        }
    }
}