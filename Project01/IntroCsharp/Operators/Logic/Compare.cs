namespace Project01.IntroCsharp.Operators.Logic
{
    public class Compare
    {
        private int x = 20; 
        private int y = 0;

        private int z = 10;

        public void Valid()
        {
        Console.WriteLine( "Es igual x que y :" + (x == y));
        Console.WriteLine( "Es diferente x que y :" + (x != y));
        Console.WriteLine( "Es mayor x que y :" + (x > y));
        Console.WriteLine( "Es menor x que y :" + (x < y));
        Console.WriteLine( "Es mayor o igual x que y :" + (x >= y));
        Console.WriteLine( "Es menor o igual x que y :" + (x <= y));

        // && AND
            Console.WriteLine("z es mayor que x y menor que y: " + (z > x && z < y));
           // || OR
            Console.WriteLine("z es mayor que x o menor que y: " + (z > x ||z < y));

           //Interpolación de strings
            Console.WriteLine($"{z} es mayor que {x} y menor que {y}: {z > x && z < y}");

        }
    public void ValidInterpolation()
        {
        Console.WriteLine( $"{x} es igual a {y}: {x == y}");
        Console.WriteLine( $"{x} es diferente de {y}: {x != y}");
        Console.WriteLine( $"{x} es mayor que {y}: {x > y}");
        Console.WriteLine( $"{x} es menor que {y}: {x < y}");
        Console.WriteLine( $"{x} es mayor o igual a {y}: {x >= y}");
        Console.WriteLine( $"{x} es menor o igual a {y}: {x <= y}");
        Console.WriteLine( $"{z} es mayor que {x} y menor que {y}: {z > x && z < y}");
        Console.WriteLine( $"{z} es mayor que {x} o menor que {y}: {z > x || z < y}");
        Console.WriteLine( $"{z} es mayor que {x} y menor que {y}: {z > x && z < y}");
        }   
    }
}