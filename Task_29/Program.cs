Console.Write("Введите максимальный порог значений элементов массива n ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] element)
{
    int length = element.Length;
    int index = 0;
    while (index < length)
    {
        element[index] = new Random().Next(1, n);
        index++;
    }
}

void PrintArray(int[] elem)
{
    int count = elem.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{elem[position]}" + ", ");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);

PrintArray(array);

