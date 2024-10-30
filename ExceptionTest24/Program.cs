// See https://aka.ms/new-console-template for more information
using ExceptionTest24;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

//try
//{
//    Console.WriteLine("Indtast tal1 (i intervallet fra 0 til 100)");
//    int tal1 = int.Parse(Console.ReadLine());
//    if (tal1 < 0 || tal1 > 100)
//        throw new NotInRangeException("Tallet er uden for intervallet");

//    Console.WriteLine("Indtast tal2");
//    int tal2 = int.Parse(Console.ReadLine());

//    int result = tal1 / tal2;

//    Console.WriteLine($"Resultatet er {result}");
//}
//catch(NotInRangeException aex)
//{
//    Console.WriteLine(aex.Message);
//}

//catch(FormatException fex)
//{
//    Console.WriteLine("Forkert format");
//}
//catch(OverflowException oex)
//{
//    Console.WriteLine("Fr stort tal");
//}
//catch (DivideByZeroException dex)
//{
//    Console.WriteLine("Division med 0");
//}
//catch (Exception exp)
//{
//    Console.WriteLine(exp.Message);
//}
//finally
//{
//    Console.WriteLine("Udføres både hvis der er en exception eller ej");
//}

//Ikke et tal FormatException
//Uden for intervallet
//Stort tal OverflowException
// DivideByZeroException

try
{
    //indtastning
    Car c = new Car("121212", "Toyota", 2023);
}

catch (ArgumentException aex)
{
    Console.WriteLine($"Fejl {aex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine("generel fejl");
}


