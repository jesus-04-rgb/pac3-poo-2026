namespace Project01.IntroCsharp.ArraysLists
{
    public class Arrays
    {
      public void Numbers(int length)
        {
          int[] numbers = new int[length];
          int[] pares = new int[] {2, 4, 6, 8, 10};
          string[] nombres = { "Juan", "Maria", "Pedro", "Ana", "Luis", "Magdalena" };

          for(int i = 0; i < numbers.Length; i++)
          {
            Console.WriteLine($"Ingrese el número para la posición {i + 1}: ");
            numbers[i] = int.TryParse(Console.ReadLine(), out int number) ? number : 0;
          }
          int avg = 0;
          for(int i = 0; i < numbers.Length; i++) 
          {
            avg += numbers[i];
            //avg = avg / numbers.Length;
          }
         avg = avg / numbers.Length;
          Console.WriteLine($"El promedio de los números ingresados es: {avg}");

        } 
    }
}