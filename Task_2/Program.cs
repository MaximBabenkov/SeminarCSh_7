// В матрице чисел найти сумму элементов главной диагонали

void PrintMatrix (int[,]matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
}

int [,] FillMatrix (int rows, int columns, int minValue, int maxValue)
{
    int[,]matrix=new int[rows,columns];
    var Random=new Random();
    for (int i=0;i<rows;i++)
        for (int j=0;j<columns;j++)
            matrix[i,j]=new Random().Next(minValue,maxValue);
    return matrix;
}

int SumMainDiag (int[,]matr)
{
    int sum=0;
    for (int i=0;i<matr.GetLength(0);i++)
    {
        sum=sum+matr[i,i]; 
    }
    return sum;
}

Console.Clear();
Console.Write("Enter amount of matrix rows and columns: ");
int rows=int.Parse(Console.ReadLine() ?? "0");
int columns=rows;
Console.Write("Enter left side of matrix elements: ");
int start=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix elements: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = FillMatrix(rows,columns,start,finish);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write($"Sum of elements of matrix's main diagonal: {SumMainDiag(matrix)}");
