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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;  //определяем кол-во элементов
    int index = 0; //определяем индексы - счтать массивы
    int position = -1; //ставим значение -1 который покажет его когда элемент не найден

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;  //кладем в position значение index
            break; //после первого найденного числа - стоп
        }
        index++;
    }
    return position;  //ожидаем позицию элемента
}

int[] array = new int [10]; // new int [10] создай новый массив в котором будет 10 элементов,
// по умолчанию будет заполнен "0" , но можем методом выше void FillArray
FillArray(array); //создал и заполнил массив
array[4] = 4; //искусственно добавили число 4 на 4 и 6 позицию, ниже строкой тоже
array[6] = 4;


PrintArray(array); //распечатай массив
System.Console.WriteLine(); //выведем пустую строчку чтобы узнать не является частью вывода массва

int pos = IndexOf(array, 444);  //определим переменную pos и положим в нее результат метода IndexOf
//в в качестве аргумента будет передавать наш массив и допустим искать число 4 в массиве
System.Console.WriteLine(pos); //после того как метод отработает, покажем на экране pos