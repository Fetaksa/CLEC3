//Пример 1 - цикл FOR

string Method4(int count, string text)
{

    string result = String.Empty;


    for (int i = 0; i < count; i++) //счётчик; проверка условия; инкремент - увеличение счётчика

    {
        result = result + text;

    }

    return result;
}

string anything = Method4(5, "сысысы");
Console.WriteLine(anything);

//Пример 2 - ЦИКЛ В ЦИКЛЕ
//выводим таблицу умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int b = 2; b <= 10; b++)
    {
        Console.WriteLine($"{i} x {b} = {i*b}");
    }

    Console.WriteLine(); //здесь используем в качестве разрыва для перехода на новую строку
}

