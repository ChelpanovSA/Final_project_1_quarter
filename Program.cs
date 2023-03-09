// *написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.* 
// *Примеры: 
// ["hello","2","world",":-)",]->["2",":-)"]
// ["1234","1567","-2","computer scince"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]*

Console.Clear();


// Размер искомого массива 
int SearchValidSizeArray(string[] fullArray, int lengthElement)
{
    string[] validArray = new string[fullArray.Length];
    int countEmptyElement = 0;
    int validSizeArray = fullArray.Length;
    for (int i = 0; i < fullArray.Length; i++)
    {
        string currentElement = fullArray[i];
        if (currentElement.Length > lengthElement)
            countEmptyElement++;
    }
    validSizeArray -= countEmptyElement;
    if (validSizeArray == 0) validSizeArray++;
    return validSizeArray;
}

