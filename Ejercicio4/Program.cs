Console.Write("Nombre: ");
string? nombre = Console.ReadLine();

Console.Write("Edad: ");
string? edadTexto = Console.ReadLine();
int.TryParse(edadTexto, out int edad);

Console.Write("Precio del producto: ");
string? precioTexto = Console.ReadLine();
double.TryParse (precioTexto, out double precio);

string categoria = (edad >= 18) ? "Adulto" : "Menor";
double descuento = (categoria == "Adulto") ? 0.10 : 0.05;
double precioFinal = precio - (precio * descuento);

Console.WriteLine($"Cliente: {nombre}");
Console.WriteLine($"Categoría: {categoria}");
Console.WriteLine($"Precio final: {precioFinal}");

Console.WriteLine("- - - - - - - - - - ");

Console.WriteLine("Nombre del usuario: ");
string? nombreUsuario = Console.ReadLine();

Console.WriteLine("Tu edad: ");
string? edadUsuario = Console.ReadLine();
int.TryParse(edadUsuario, out int edad1);
string verificar = (edad1 >=18) ? "Edad valida." : "Eres menor de edad.";

Console.WriteLine("Tienes un historial limpio?: ");
bool historialLimpio = true;
string historial = historialLimpio ? "Puedes tener tu pasaporte." : "Pasaporte denegado.";

Console.WriteLine($"Bienvenido {nombreUsuario}");
Console.WriteLine($"Tienes {verificar} ");
Console.WriteLine($"¿Tienes un historial limpio? {historial}");
