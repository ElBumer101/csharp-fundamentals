using System.Runtime.InteropServices;

Console.WriteLine("Iniciando programa...");
Console.Write("¿Aceptas los términos y condiciones? S/N: ");
string? verificarUsuario = Console.ReadLine();

if (verificarUsuario.ToLower() != "s")
{
    Console.WriteLine("No aceptaste los términos y condiciones.");
    return;
}
Console.WriteLine("Aceptaste los términos y condicones.");

Console.WriteLine("=================");

Console.WriteLine("Escribe la contraseña: ");
var constraseñaUsuario = "123admin";
string? verificarContraseña = Console.ReadLine();
if (verificarContraseña != constraseñaUsuario)
{
    Console.WriteLine("Tu contraseña es incorrecta.");
    return;
}
Console.WriteLine("Tu contraseña es correcta. Bienvenido.");
