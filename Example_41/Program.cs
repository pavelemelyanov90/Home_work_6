// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Вариант с рандомным заполнением

/*Console.WriteLine("Введите количество чисел:\t");
int col = int.Parse(Console.ReadLine()!);

int[] InputArray (int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1 );
    }
    return arr;
}


int OutArray(int[] result)
{
    int count = 0;
    for(int i = 0; i < result.Length; i++)
    {
        if(result[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = InputArray(col, 0, 10);
Console.WriteLine(String.Join(" , ", array));
int res = OutArray(array);
Console.WriteLine($"Количество значений больше 0 равно: {res});*/

// Вариант с пользовательским вводом

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = String.Empty;

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " , ");
    }
    Console.Write("]");
}

Console.Clear();
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");
