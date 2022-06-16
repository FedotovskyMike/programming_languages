//1 Вид

/* void Method1()
{
    Console.WriteLine("name");
}
Method1(); */


//2 Вид

/* void Method2(string msg)//методы которые ни-чего не возвращают но могут принимать какие то аргументы.
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");//метод вызывает аргумент метода.

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;//увиличение счётчика на 1 называется ИНКРИМЕНТ. Уменьшение ДЕКкриментом.
    }
}
//Method21(msg "Text", count 4);
Method21(count: 4, msg: "Новый текст"); */

//3 Вид

/* int Method3()
{
    return DateTime.Now.Year;//Что за оператор RENURN?
}
int year = Method3();
Console.WriteLine(year); */

//4 Вид

/* string Method4(int count, string Text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + Text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");//выводит текст
Console.WriteLine(res); */