var vidaAliado = 100;
Console.Write("¿Cual es tu nombre? ");
string? nombreUsuario = Console.ReadLine();
Console.WriteLine($"¡Bienvenido! {nombreUsuario}");

while (vidaAliado >0)
{
    Console.WriteLine($"Vida actual {vidaAliado} ");
    Console.Write($"¿Cuano daño recibio? {nombreUsuario}");
    string? veriicar = Console.ReadLine();
    if (int.TryParse(veriicar, out int daño))
    {
        vidaAliado -= daño;
    }
    else
    {
        Console.WriteLine($"Por favor, ponga un numero valido. {nombreUsuario}");
    }
}
Console.WriteLine($"{nombreUsuario}Tu personaje a muerto");