// Задача: сформировать и вывести массив строк длиной не более 3-х символов из массива введенных строк

//takes data from console in reply to welcome msg & returns input as Int32
int ReadDataToInt(string msg)
{
    Console.Write(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

//takes string from console in reply to welcome msg
string ReadDataToString(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

//takes <num> number of strings from console and returns an array of strings
string[] ReadStringsToArray(int num)
{
    string[] strings = new string[num];

    for (int i = 0; i < num; i++)
        strings[i] = ReadDataToString($"String #{i + 1}: ");

    return strings;
}

//keeps only the strings of maxLen or less length
string[] keepShortStrings(string[] arr, int maxLen)
{
    string[] shortStrings = new string[arr.Length];
    int cntLen = 0;//counter for shortStrings[]

    for (int i = 0; i < arr.Length; i++)
    {
        shortStrings[i] = string.Empty;//to ensure init with no stuff inside
        if (arr[i].Length <= maxLen && arr[i] != "")
        {
            shortStrings[cntLen] = arr[i];
            cntLen++;
        }
    }

    if (cntLen > 0)
        Array.Resize(ref shortStrings, cntLen);//resizes array to real number of short strings (if any)

    return shortStrings;
}

//prints array of strings into console
void Print1DArr(string[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] != "") Console.Write($"\"{arr[i]}\", ");//skip empty strings
    }
    if (arr[arr.Length - 1] != "") Console.Write($"\"{arr[arr.Length - 1]}\"");//last string w/o ','

    Console.WriteLine("]");
}



int maxLen = 3;//max length of string to keep for output

int numOfStrings = ReadDataToInt("Enter a number of strings you would like to input: ");//number of strings to take

Console.WriteLine();
string[] inStrings = ReadStringsToArray(numOfStrings);//user inputs string one by one

Console.WriteLine();
string[] outStrings = keepShortStrings(inStrings, maxLen);//forms an array of strings which length <= maxLen
Print1DArr(outStrings);//prints formed array into console