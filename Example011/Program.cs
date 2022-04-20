void FillArray(int[] collection)   // метод void ничего не возвращает - который определяет рандомные числа массива
                                   //collection - название
{
    int Length = collection.Length;  //определяет длину массива
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10); //положить новое любое случайное число из диапазона от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)     // метод void - который будет печатать массив, col - просто название
{
    int count = col.Length;   // определяем количество элементов
    int position = 0;   // определяем позицию числа , вместо index
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int [10]; // new int [10] создай новый массив в котором будет 10 элементов,
// по умолчанию будет заполнен "0" , но можем методом выше void FillArray
FillArray(array); //создал и заполнил массив
PrintArray(array); //распечатай массив

