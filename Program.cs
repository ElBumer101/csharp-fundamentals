//string interpolacion ($".")
using System.Data;

string nombre = "Thorffinth";
int edad = 67;
string amigos = "no tengo amigos";
string gei = "Crazy";
string resultaInterpolacion = $"Mi nombre es {nombre}. Tengo {edad} años y {amigos}, mi novia es {gei}.";

Console.WriteLine(resultaInterpolacion);

Console.WriteLine("- - - - - - - - -");

//Este es un corte de texto (Substring)
var nombre1 = "Thorffinth";
var oficio = "Pogramador";
var parte = oficio.Substring(0, 4);
var resultado1 = $"Mi nombre es {nombre1} y solo agarrare estas letras {parte}";
Console.WriteLine(resultado1);

Console.WriteLine("- - - - - - - - -");

//Quita las "," con Split(´,´);
var datos ="Joseph, 17, Mexico";
string[] partes = datos.Split(',');
Console.WriteLine($"Encuentra un texto: {partes[0]}, {partes[1]}, {partes[2]}");



Console.WriteLine("- - - - - - - - -");

//Encuentra un texto Contains(texto)
var nombre2 = "Thorffinth";
bool buscaOr = nombre2.Contains("or");
Console.WriteLine($"Encuentra un texto: {buscaOr}");


Console.WriteLine("- - - - - - - - -");
 
//validar si un correo tiene @
var correo = "Thorffinth@icloud.com0";
if (correo.Contains("@"))
{
    Console.WriteLine("El correo es valido");
}


Console.WriteLine("- - - - - - - - -");

//devuelve la posicion a un numero IndexOf(texto)
var nombre3 = "Thorffinth";
var buscarNumero = nombre3.IndexOf("t");//resultado = 8
Console.WriteLine($"Devuelve la operacion Thorffinth a numero = {buscarNumero}");

Console.WriteLine("- - - - - - - - -"); 

//Reemplazar texto Replace(textoViejo, textoNuevo)
var cambiar = "Texto Remplazada: {Thorffinth0}";
var nuevoTexto = cambiar.Replace("Thorffinth", "Hamburguesa");
Console.WriteLine(nuevoTexto);
//Uso practico 
var telefono = $"Numero de telefono: {123-456-7890}";
var limpio = telefono.Replace("-", "");
Console.WriteLine(limpio);

//Bool Usuario vip
var UserVip = "Thorffinth";
bool accesoUserVip = true;
if (accesoUserVip)
{
    Console.WriteLine($"{UserVip} tiene acceso. Puede pasar");
}
else
{
    Console.WriteLine("NO tienes acceso. No puedes pasar.");
}

// Bool Ambos iguales
var nombre4 = "Thorffinth";
var pasaporteValido = true;
var edadPermitida = 18;
bool pasaportePermitido = pasaporteValido && (edadPermitida >= 18);
if (pasaportePermitido)
{
    Console.WriteLine($"{nombre4}tienes permiso para sacar un pasaporte.");
}
else
{
    Console.WriteLine($"No tienes los requisitos, no puedes pasar");
}