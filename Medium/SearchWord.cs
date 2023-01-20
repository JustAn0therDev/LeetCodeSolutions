namespace Medium;

public class SearchWord
{
    private HashSet<(int, int)> SeenCells { get; set; } = new();
    public bool Solve(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (word[0] == board[i][j] && SearchRecursively(board, word, 1, (i, j)))
                {
                    return true;
                }

                SeenCells.Clear();
            }
        }

        return false;
    }

    public bool SearchRecursively(char[][] board, string word, int wordIdx, (int x, int y) cellCoord)
    {
        if (wordIdx == word.Length)
        {
            return true;
        }
   
        SeenCells.Add(cellCoord);

        // check up
        if (cellCoord.x > 0 && word[wordIdx] == board[cellCoord.x - 1][cellCoord.y] &&
            !SeenCells.Contains((cellCoord.x - 1, cellCoord.y)))
        {
            if (SearchRecursively(board, word, wordIdx + 1, (cellCoord.x - 1, cellCoord.y)))
            {
                return true;
            }
        }

        // check down
        if (cellCoord.x < board.Length - 1 && word[wordIdx] == board[cellCoord.x + 1][cellCoord.y] &&
                                                            !SeenCells.Contains((cellCoord.x + 1, cellCoord.y)))
        {
            if (SearchRecursively(board, word, wordIdx + 1, (cellCoord.x + 1, cellCoord.y)))
            {
                return true;
            }
        }

        // check left
        if (cellCoord.y > 0 && word[wordIdx] == board[cellCoord.x][cellCoord.y - 1] &&
                                             !SeenCells.Contains((cellCoord.x, cellCoord.y - 1)))
        {
            if (SearchRecursively(board, word, wordIdx + 1, (cellCoord.x, cellCoord.y - 1)))
            {
                return true;
            }
        }

        // check right
        if (cellCoord.y < board[cellCoord.x].Length - 1 && word[wordIdx] == board[cellCoord.x][cellCoord.y + 1] &&
            !SeenCells.Contains((cellCoord.x, cellCoord.y + 1)))
        {
            if (SearchRecursively(board, word, wordIdx + 1, (cellCoord.x, cellCoord.y + 1)))
            {
                return true;
            }
        }

        SeenCells.Remove(SeenCells.LastOrDefault());
        return false;
    }
}