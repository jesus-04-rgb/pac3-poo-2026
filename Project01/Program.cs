using Project01.IntroCsharp.Variables;
using Project01.IntroCsharp.Operators.Arithmetic;
using Project01.IntroCsharp.Operators.Logic;

Numbers numbers = new Numbers();

Strings strings = new Strings();

//strings.variables();

Calculator calculator = new Calculator();

// Console.WriteLine("la suma de 50 + 10 es: " + calculator.Sum(50, 10));
// Console.WriteLine("la resta de 50 - 25 es: " + calculator.Subtract(50, 25));
// Console.WriteLine("la multiplicación de 11 * 10 es: " + calculator.Multiply(11, 10));
// Console.WriteLine("la división de 100 / 10 es: " + calculator.Divide(100, 10));
// Console.WriteLine("el valor de Pi es: " +(int) calculator.Pi());
// Console.WriteLine("el módulo de  11 % 3 es: " + calculator.Modulus(11, 3));

Compare compare = new Compare();
compare.Valid();
