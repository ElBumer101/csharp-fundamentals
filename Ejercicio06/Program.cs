var nombreUsuario = "Thorffinth";
var edadUsuario = 18 ;
var requisitos = true;
bool verificarBanco = (edadUsuario >= 18) && requisitos;
if (verificarBanco)
{
    Console.WriteLine($" {nombreUsuario} Puedes sacar tu cuenta de banco premium");
}
else
{
    Console.WriteLine("Tus documentos no son validos");
}






