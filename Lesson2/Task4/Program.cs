// Вариант 1. WHILE
// int n = 5;
// int[] array = { 2, 88, 107, 3, 9 };
// int i = 0;
// int max = array[0];

// while(i < n)
// {
//     if(array[i] > max)
//     {
//         max = array[i];
//     }
//     i++;
// }
// System.Console.WriteLine(max);

// Вариант 2. FOR
// int n = 5;
// int[] array = { 2, 88, 107, 3, 9 };
// int max = array[0];

// for(int j = 0; j < n; j++)
// {
//    if(array[j]>max)
//    {
//     max = array[j];
//    }
// }
// System.Console.WriteLine(max);

//Вариант 3. FOREACH
int n = 5;
int[] array = { 2, 88, 107, 3, 9 };
int max = array[0];

foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
System.Console.WriteLine(max);