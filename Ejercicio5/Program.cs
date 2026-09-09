var nombreEstudiante = "Thorffinth";
var calificacion = 100;

string? verificar = calificacion switch
{
    >= 95 => "Calificacion perfecta. Felicidades",
    >= 85 => "Calificacion buena",
    >= 70 => "Calificacion pasable",
    < 70 => "Date de baja"
};

Console.WriteLine($" {nombreEstudiante}. Los resultados de tu calificaico: {verificar} ");