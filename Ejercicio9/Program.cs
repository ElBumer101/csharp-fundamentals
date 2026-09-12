Console.WriteLine("=======================");
Console.WriteLine("¿Cual es tu nombre?");
string? nombreUsuario = Console.ReadLine();

while (true)
{   
    Console.WriteLine($"!Bienvenido {nombreUsuario}¡, Opciones : Saludar/ Hora/ Salir");
    Console.Write("Elije una opcion: ");
    string? validar = Console.ReadLine();
    switch (validar?.ToLower().Trim())
    {
        case "saludar":
            Console.WriteLine($"Hola {nombreUsuario}");
            break;

        case "hora":
            Console.WriteLine($"La hora es {DateTime.Now:hh:mm tt}");
            break;

        case "salir":
            Console.WriteLine($"Hasta luego {nombreUsuario} ");
            return;

        default:
            Console.WriteLine($"{nombreUsuario} error, Opcion no valida");
            break;
    }
}   



