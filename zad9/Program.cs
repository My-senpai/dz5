﻿//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] Copy(int[] mas){
int[] mas2 = new int[mas.Length];

for (int i = 0; i < mas.Length; i++)
{
mas2[i] = mas[i];
}

return mas2;
}

void Vivod(int[] mas){
for (int i = 0; i < mas.Length; i++)
{
if (i == mas.Length-1)
{
Console.Write($"{mas[i]}");
continue;
}
Console.Write($"{mas[i]}, ");
}
}

int[] mas = new int[5]{1,2,3,4,5};

int[] masCopy = Copy(mas);
Vivod(masCopy);


/*
T[] Copy<T> (T[] array)
{
T[] result = new T[array.Length];
return result;
}
*/

/////////////////////////////////

/*
AllType[] Copy<AllType> (AllType[] array)
{
AllType[] result = new AllType[array.Length];
for (int i = 0; i < array.Length; i++)
{
result[i] = array[i];
}
return result;
}

string[] strArray = new string[3] {"1","2332","fdfdf"};
int[] intArray = new int[3]{1,2,3};
bool[] boolArray = new bool[3]{true, false, false};

string[] resStrArray = Copy(strArray);
int[] resIntArray = Copy(intArray);
var resBoolArray = Copy(boolArray);

*/