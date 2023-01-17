using Medium;

char[][] board = { new[] {'A','B','C','E'}, new[] {'S','F','C','S'}, new[] {'A','D','E','E'} };
string word = "ABCCED";

Console.WriteLine(SearchWord.Solve(board, word));

word = "SEE";
Console.WriteLine(SearchWord.Solve(board, word));

word = "ABCB";
Console.WriteLine(SearchWord.Solve(board, word));