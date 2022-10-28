//Вид 1 - ничего не принимает, ничего не возвращает.

void Method1()
{
    Console.WriteLine("Автор ФИО");
}

//Вызвать метод:
Method1();

//Вид 2 - принимают аргументы, ничего не возвращают

void Method2(string msg)
{
Console.WriteLine(msg);
}

Method2("Текст сообщения");

//Вариант со счётчиком

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Тестирую метод со счётчиком", 10);
//ещё вариант вызова: Method21(msg: "Тестирую метод со счётчиком", count: 10);
//это именованные аргументы, их можно писать не по порядку, например:
//Method21(count: 8, msg: "Какой-то текст");


//Вид 3 - ничего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


//Вид 4 - что-то принимают, что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string anything = Method4(5, "сысысы");
Console.WriteLine(anything);