using Shared;
using exercises34;

var n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");

var matrix = new HourglassMatrix(n);

Console.WriteLine(matrix.ShowMatrix());
Console.WriteLine(matrix.ShowHourglass());
