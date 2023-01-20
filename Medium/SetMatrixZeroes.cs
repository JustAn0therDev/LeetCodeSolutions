namespace Medium;

public class SetMatrixZeroes
{
    public void SetZeroes(int[][] matrix)
    {
        List<(int, int)> changed = new();

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0 || changed.Contains((i, j))) 
                    continue;

                int start = 0;

                while (start < matrix[i].Length)
                {
                    if (matrix[i][start] == 0 && !changed.Contains((i, start)))
                    {
                        start++;
                        continue;
                    }
                    matrix[i][start] = 0;
                    changed.Add((i, start));
                    start++;
                }

                start = 0;

                while (start < matrix.Length)
                {
                    if (matrix[start][j] == 0 && !changed.Contains((start, j)))
                    {
                        start++;
                        continue;
                    }
                    
                    matrix[start][j] = 0;
                    changed.Add((start, j));
                    start++;
                }
                
                changed.Add((i, j));
            }
        }
    }
}