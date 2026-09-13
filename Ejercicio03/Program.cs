Console.WriteLine("========================");
Console.WriteLine($"¿Que quieres comer?  ");
Console.WriteLine("1. Comer Manzanas");
Console.WriteLine("2. Comer Sandias");
Console.WriteLine("3. Comer Uvas");
Console.WriteLine("========================");
Console.Write("Elige una opción (1-3): ");
string? interaccion = Console.ReadLine();

Console.WriteLine("========================");

switch (interaccion)
{
    case "1":
        Console.WriteLine("Opcion 1 = Comeras una manzana");
        break;  

    case "2":
        Console.WriteLine("Opcion 2 = Comeras una sandia");
        break;

    case "3":
        Console.WriteLine("Opcion 3 = Comeras Uvas");
        break;

    default:
        Console.WriteLine("Obcion no valida, por favor elija un numero");
        return;

}
Console.WriteLine($"Elegiste la opcion: {interaccion}. ¡Buen provecho!");

