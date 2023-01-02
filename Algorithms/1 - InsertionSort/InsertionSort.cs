using System.Collections.Generic;

namespace Algorithms._1___InsertionSort
{
    public static class InsertionSort
    {
        public static void SortByInsertionSort(this List<int> input)
        {
            //Vai fazendo a comparação do atual com o próximo e fazendo as trocas
            int i, key;

            for (int j = 1; j < input.Count; j++)
            {
                key = input[j];

                i = j - 1;

                while (i >= 0 && input[i] > key)
                {
                    input[i + 1] = input[i];
                    i--;
                }

                input[i + 1] = key;
            }
        }
    }
}
