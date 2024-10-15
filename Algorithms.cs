namespace Sortowania
{
    public class Algorithms
    {
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(int[] T)
        {
            // piwerszy element tworzy posortowaną część tablicy
            for (int i = 1; i < T.Length; i++)
            {
                int key = T[i]; // bierzemy pierwszy element z nieposortowanej części tablicy
                int j = i - 1; // index elementu poprzedniego (z posortowanej częśći)

                while (j >= 0 && T[j] > key) // przechodzimy od konca przez elementy większe od analizowanego (w posortowanej części) przesuwam je po kolei w prawo o jedno miejsce az trafimy na element mniejszy 
                {
                    T[j + 1] = T[j]; // przsuwam wieksze elementy w prawo
                    j--;
                }
                T[j + 1] = key; // znalezlismy element mniejszy na pozycji j wiec ustawiam analizowany element na pozycji j+1
            }
        }

        public static void SelectionSort(int[] array)
        {
            int index = 0;
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[index])
                    {
                        index = j;
                    }
                }
                temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }

        public static int Partition(int l, int p, int[] T)
        {
            if (l == p) return l; // sprawdzamy czy tablica nie jest jednoelementowa

            int temp;
            int pivot = T[p]; // ustalam ostatni element na pivot

            int i = l - 1;
            int j = l;
            while (j < p)
            {
                if (T[j] < pivot) // wyznaczamy elementy tablicy mniejsze od pivotu i przenosimy je na początek
                {
                    temp = T[j];
                    T[j] = T[i + 1];
                    T[i + 1] = temp; // i + 1 -- index pierwszego elementu nieposortowanej części

                    i++; // liczymy ile nastąpiło zmian, dzięki temu wyznaczymy ile jest elementow mniejszych od pivotu co pozwoli na ustalenie jego docelowej pozycji
                }
                j++;
            }

            // ustalamy pivot na odpowiednim miejscu
            temp = T[i + 1];
            T[i + 1] = T[p];
            T[p] = temp;

            i++;

            return i;
        }
        public static void QuickSort(int l, int p, int[] array)
        {
            int pivot;
            if (l <= p)
            {
                pivot = Partition(l, p, array);
                QuickSort(l, pivot - 1, array);
                QuickSort(pivot + 1, p, array);
            }
        }
    }
}