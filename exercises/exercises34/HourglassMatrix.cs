namespace exercises34;

public class HourglassMatrix
{
    // Fields
    private int _n;
    private int[,] _matrix;

    // Constructor
    public HourglassMatrix(int n)
    {
        _n = n;
        _matrix = new int[_n, _n];
        FillMatrix();
    }

    //Métodos privados

    private void FillMatrix()
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                _matrix[i, j] = (2 * i) + j; 
            }
        }
    }

    //Mostrar matriz completa

    public string ShowMatrix()
    {
        string output = "MATRIZ COMPLETA\n";

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                output += $"{_matrix[i, j],3}";
            }
            output += "\n";
        }

        return output;
    }

    // 🔹 Reloj de arena

    public string ShowHourglass()
    {
        string output = "RELOJ DE ARENA\n";
        int mid = _n / 2;

        for (int i = 0; i < _n; i++)
        {
            int start = (i <= mid) ? i : _n - i - 1;
            int end = _n - start - 1;

            // espacios
            for (int s = 0; s < start; s++)
                output += "   ";

            // valores
            for (int j = start; j <= end; j++)
                output += $"{_matrix[i, j],3}";

            output += "\n";
        }

        return output;
    }
}
