Console.WriteLine("========================");
Console.WriteLine($"¿Qué quieres comer?");
Console.WriteLine("1. Comer Manzanas.");
Console.WriteLine("2. Comer Sandías.");
Console.WriteLine("3. Comer Uvas.");
Console.WriteLine("========================");
Console.Write("Elige una opción (1-3): ");
string? interaccion = Console.ReadLine();

Console.WriteLine("========================");

switch (interaccion)
{
    case "1":
        Console.WriteLine("Opción 1 = Comerás una manzana.");
        break;  

    case "2":
        Console.WriteLine("Opción 2 = Comerás una sandía.");
        break;

    case "3":
        Console.WriteLine("Opción 3 = Comerás Uvas.");
        break;

    default:
        Console.WriteLine("Obcion no válida, por favor, elija un número.");
        return;

}
Console.WriteLine($"Elegiste la opcion: {interaccion}. ¡Buen provecho!");

