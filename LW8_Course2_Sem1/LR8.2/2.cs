int[] arrayA = { 3, 5, 8, 11, 16 };
int[] arrayB = { 1, 5, 7, 9, 12, 13, 18, 20 };

int[] mergedArray = MergeArrays(arrayA, arrayB);

Console.WriteLine("Слияние двух массивов:");
foreach (var item in mergedArray)
{
    Console.WriteLine(item);
}

Console.ReadKey();
static int[] MergeArrays(int[] arrayA, int[] arrayB)
{
    int[] mergedArray = new int[arrayA.Length + arrayB.Length];
    int indexA = 0, indexB = 0, indexMerged = 0;

    while (indexA < arrayA.Length && indexB < arrayB.Length)
    {
        if (arrayA[indexA] < arrayB[indexB])
        {
            mergedArray[indexMerged] = arrayA[indexA];
            indexA++;
        }
        else
        {
            mergedArray[indexMerged] = arrayB[indexB];
            indexB++;
        }
        indexMerged++;
    }

    while (indexA < arrayA.Length)
    {
        mergedArray[indexMerged] = arrayA[indexA];
        indexA++;
        indexMerged++;
    }

    while (indexB < arrayB.Length)
    {
        mergedArray[indexMerged] = arrayB[indexB];
        indexB++;
        indexMerged++;
    }

    return mergedArray;
}