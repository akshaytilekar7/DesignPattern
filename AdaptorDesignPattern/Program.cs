using System;

class MainClass
{
    public static string LongestMatrixPath(string[] strArr)
    {

        // code goes here  
        var row = strArr.Length;
        var col = strArr[0].Length;

        char[,] arr = new char[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                arr[i, j] = strArr[i][j];
            }
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }

        return "10";
    }

    public void Run(int curRow, int curCol, int row, int col, char[,] arr, char[,] result)
    {
        if (curCol < 0 || curCol > col) return;
        if (curRow < 0 || curRow > row) return;

        if (result[curRow, curCol] != int.MinValue)
            return;


    }


    static void Main()
    {

        // keep this function call here
        Console.WriteLine(LongestMatrixPath(new string[] { "12256", "56219", "43215" }));

    }

}