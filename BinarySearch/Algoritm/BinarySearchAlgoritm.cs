namespace BinarySearch.Algoritm
{
    public class BinarySearchAlgoritm
    {
        /// <summary>
        /// Метод двоичного поиска
        /// </summary>
        public static int BinarySearch(int[] array, int searchValue)
        {
            var lowBorderIndex = 0;
            var highBorderIndex = array.Length - 1;

            while (lowBorderIndex <= highBorderIndex)
            {
                var midIndex = (lowBorderIndex + highBorderIndex) / 2;
                var currentValue = array[midIndex];

                if (currentValue == searchValue)
                {
                    return midIndex;
                }
                else if (currentValue > searchValue)
                {
                    highBorderIndex = midIndex - 1;
                }
                else
                {
                    lowBorderIndex = midIndex + 1;
                }
            }
            // Если элемент в массиве не найден
            return -1;
        }
    }
}
