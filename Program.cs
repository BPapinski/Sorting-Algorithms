﻿

using Sortowania;

int[] T = new int[10];

Preparation.fill(T);
Preparation.display(T);

//Algorithms.BubbleSort(T);
//Algorithms.InsertionSort(T);
//Algorithms.SelectionSort(T);
Algorithms.QuickSort(0, T.Length - 1, T);

Preparation.display(T);
