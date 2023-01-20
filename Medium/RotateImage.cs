namespace Medium;

public class RotateImage
{
    public void Rotate(int[][] matrix)
    {
        List<List<int>> lines = new();

        for (int i = 0; i < matrix.Length; i++)
        {
            List<int> line = new();

            for (int j = matrix.Length - 1; j >= 0; j--)
            {
                line.Add(matrix[j][i]);
            }

            lines.Add(line);
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = lines[i][j];
            }
        }
    }
}