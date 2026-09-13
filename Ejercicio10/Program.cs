Console.WriteLine("===========================");
Console.WriteLine("SISTEMA DE DESCUENTO TIENDA");
Console.WriteLine("===========================");

Console.Write("Ingresa el precio del producto: ");
string? ingresarProducto = Console.ReadLine();

if (!double.TryParse(ingresarProducto, out double verificarProducto) ||  verificarProducto <= 0)
{
    Console.WriteLine("Error. Debes ingresar un número válido.");
    return;
}

while (true)
{
    Console.Write("¿Cuál es tu nombre? ");
    string? nombreUsuario = Console.ReadLine();
    Console.WriteLine("------------------------");
    Console.WriteLine($"¡Bienvenido, {nombreUsuario}! Disfrute del sistema de descuentos.");


    Console.WriteLine("Categoría de clientes.");
    Console.WriteLine("1.- Estudiando (Descuento a  20%).");
    Console.WriteLine("2.- Socio (30% de descuento).");
    Console.WriteLine("3.- Cliente General (sin descuento).");
    Console.WriteLine("4.- Salir.");
    Console.WriteLine("SELECCIONA UNA DE LAS 4 OPCIONES.");
    string? menuUsuario = Console.ReadLine();

    switch (menuUsuario.ToLower().Trim())
    {
        case "1":
        case "estudiante":
            double totalestudiante = verificarProducto * 0.80;
            Console.WriteLine($"{nombreUsuario}, tu descuento fue aplicado. Total a pagar: {totalestudiante}.");
            break;

        case "2":
        case "socio":
            double totalsocio = verificarProducto * 0.70;
            Console.WriteLine($"{nombreUsuario}, tu descuento fue aplicadeo del 30%. Total a pagar: {totalsocio}.");
            break;

        case "3":
        case "cliente general":
            double totalClienteGeneral = verificarProducto;
            Console.WriteLine($"{nombreUsuario}, no tienes descuentos. Total a pagar: {totalClienteGeneral}.");
            break;

        case "4":
        case "salir":
            Console.WriteLine($"{nombreUsuario}, gracias por usar el sistema.");
            return;

        default:
            Console.WriteLine($"Error. Opción no válida, {nombreUsuario}.");
            break;
    }
}