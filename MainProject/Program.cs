using Medium;

char[][] board = 
    {new[] {'a', 'b'}, new[] {'c', 'd'}};
// {
//     new[] {'A', 'B', 'C', 'E'},
//     new[] {'S', 'F', 'C', 'S'},
//     new[] {'A', 'D', 'E', 'E'}
// };
// {
// new[] {'A', 'B', 'C', 'E'},
// new[] {'S', 'F', 'E', 'S'},
// new[] {'A', 'D', 'E', 'E'}
// };

// Should be true

SearchWord sw = new SearchWord();

Console.WriteLine(sw.Solve(board, "abdc"));