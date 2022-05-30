namespace SortingEx_01
{
    class Program
    {
        // 선택정렬
        // 정렬 알고리즘 3:51
        static void Main (string[] args)
        {
            int[] array = { 7, 5, 9, 0, 3, 1, 6, 2, 4, 8 };

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i; // 처음에는 가장 앞쪽 인덱스가 가장 작은 원소가 될 수 있게 세팅..

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                        minIndex = j;
                }

                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}