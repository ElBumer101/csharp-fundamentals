using System.Runtime.InteropServices;

Console.WriteLine("Iniciando programa...");
Console.Write("¿Aceptas los terminos y condiciones? S/N: ");
string? verificarUsuario = Console.ReadLine();

if (verificarUsuario.ToLower() != "s")
{
    Console.WriteLine("No aceptaste los terminos y condiciones.");
    return;
}
Console.WriteLine("Aceptaste los terminos y condicones");

Console.WriteLine("=================");

Console.WriteLine("Escribe la contraseña: ");
var constraseñaUsuario = "123admin";
string? verificarContraseña = Console.ReadLine();
if (verificarContraseña != constraseñaUsuario)
{
    Console.WriteLine("Tu contraseña es incorrecta");
    return;
}
Console.WriteLine("Tu contraseña es correcta. Bienvenido");
