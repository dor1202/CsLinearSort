namespace ConsoleApp1
{
    static class Sorts
    {
        public static int[] CountingSort(int[] a, int maxNum)
        {
            // {2,1,1,5,6,4,4,7,7}

            int[] howMenyTimesNumberExistInArray = new int[maxNum + 1];
            int[] howMenyNumbersTheNumberIsBigger = new int[a.Length];
            bool[] History = new bool[maxNum + 1];
            int[] result = new int[a.Length];

            for (int i = 0; i <= maxNum + 1; i++)
                howMenyTimesNumberExistInArray[a[i]]++;

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j <= a.Length - 1; j++)
                {
                    if (i == j) continue;

                    if (History[a[i]] == true)  break;

                    if (a[i] >= a[j])
                        howMenyNumbersTheNumberIsBigger[a[i]]++;
                }

                History[a[i]] = true;
            }

            for (int i = maxNum + 1; i >= 0; i--)
            {
                result[howMenyNumbersTheNumberIsBigger[a[i]]] = a[i];
                howMenyNumbersTheNumberIsBigger[a[i]]--;
            }
            return result;
        }
    }
}
