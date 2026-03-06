

namespace exercises31;

public class Matrix
{
    // Fields
    private int _n;
    private int[,] _matrix;

    // Constructor
    public Matrix(int n)
    {
        _n = n;
        ValidateN();
        _matrix = new int[_n, _n];
        FillMatrix();
    }

    // Properties
    public int N => _n;
    public int[,] Values => _matrix;

    //Métodos públicos

    public string ShowMatrix()
    {
        string output = "";

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                output += $"{_matrix[i, j],4}";
            }
            output += "\n";
        }

        return output;
    }

    public string ShowLowerTriangular()
    {
        string output = "";

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                output += $"{_matrix[i, j],4}";
            }
            output += "\n";
        }

        return output;
    }

    //  Métodos privados
    //El método FillMatrix es un método privado que se utiliza para asignar valores a cada posición de la matriz.

    private void FillMatrix()
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                _matrix[i, j] = i + j;
            }
        }
    }
    //se utiliza para verificar que el valor de n, que representa el tamaño de la matriz, sea válido.
    private void ValidateN()
    {
        if (_n <= 0)
            throw new ArgumentException("N must be greater than zero");
    }
}
