
int[] arrNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
int M, N, nTasks;
int sumTotal = 0;

N = arrNum.Length;
M = 3;
nTasks = N / M;

Parallel.For(0, M,
    i => {
        int iStart, iEnd, j;
        iStart = i * nTasks;
        iEnd = (i+1) * nTasks-1;
        sumTotal += arrNum[i]; //BUG Here !!!
    });

Console.WriteLine(sumTotal);
