var nombreUsuario = "Thorffinth";

Console.WriteLine("======================");
Console.WriteLine("escribe tu edad: ");
string? edadUsuario = Console.ReadLine();
int.TryParse(edadUsuario, out int verificarEdad);
if (verificarEdad <= 18)
{
    Console.WriteLine($"{nombreUsuario} No cumples con los requisitos");
    return;
}

Console.WriteLine("¿Tienes Boleto de entrada? S/N");
string? accesoVip = Console.ReadLine();
string? verificarAcceso = (accesoVip.ToLower() == "s") ? "Puedes pasar al evento" : "No puedes pasar al evento";
Console.WriteLine($"{nombreUsuario}, {verificarAcceso}"); 
