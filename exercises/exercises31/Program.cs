using Shared;
using exercises31;

var n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");

var matrix = new Matrix(n);

Console.WriteLine(matrix.ShowMatrix());
Console.WriteLine(matrix.ShowLowerTriangular());
