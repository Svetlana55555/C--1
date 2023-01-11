//Метод вид 1 - не принимает, не возвращает
/* void Method1()
{
    Console.WriteLine("Автор...");
} */
//Method1(); //вызов метода по имени со скобками


//Метод вид 2 - принимает, не возвращает
/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
} */
//Method21("Текст", 4);
//Method21(msg: "Текст",  count: 4); //если именовать, то можно перечислять в любом порядке


//Метод вид 3 - не принимает, возвращает
/* int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year); */

//Метод вид 4 - принимает, возвращает
/* string Method4(int count, string text)
{
    int i = 0;
    //string result = "";
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res); */


//Цикл for

/* string Method4(int count, string text)
{
    string result = string.Empty;
for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res); */

//вывод таблицы умножения на экран
/* for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
} */


//Дан текст. В тексте нужно все пробелы заменить черточками, 
//маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

/* string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?"; */

// string s = "qwerty"
//             012
// s[3] // r

/* string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText); */

//алгоритм сортировки методом выбора
//алгоритм сортировки методом мини-макса
//метод максимального 
//выбор максимального/минимального

//1. Найти позицию минимального элемента в неотсортированной части массива.
//2. Произвести обмен этого значения со значением первой неотсортированной позиции.
//3. Повторять пока есть неотсортированные элементы.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

/* void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr); */

//переделать на сортировку от максимального к минимальному
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int maxPosition = i;
        
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
