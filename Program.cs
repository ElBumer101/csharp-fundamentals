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

//extraer texto
var datos ="Joseph, 17,Mexico";
string[] partes = datos.Split(',');
Console.WriteLine(partes[0]);
Console.WriteLine(partes[1]);
Console.WriteLine(partes[2]);


Console.WriteLine("- - - - - - - - -");

//Encuentra un texto Contains(texto)
var nombre2 = "Thorffinth";
bool buscaOr = nombre2.Contains("or");
Console.WriteLine(buscaOr);


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
Console.WriteLine(buscarNumero);
