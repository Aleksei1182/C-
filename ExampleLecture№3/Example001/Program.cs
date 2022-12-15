// методы (функции)




// 1 тип методов - ничего не принимают ничего не передают.

void Method1() // Достаточно указать только тип метода и её наименование
{
    Console.WriteLine("Автор Алексей");
}

//Method1(); // - так вызываются методы!





// 2 тип методов -  принимают, но ничего не передают.

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg: "Текст сообшения");


// Есть вариант этого метода, когда принимается несколько аргументов
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Текст сообщения", 4);
//как вариант можем явно указывать какому значению соотвествует аргумент msg и count
//пример:
//Method21(msg: "Текст сообщения", count: 4);
//При явном обозначении аругмента их можно менять местами
//Method21(count: 4, msg: "Текст сообщения");





// 3 тип методов -  ничего не принимают, но что-то передают.

int Method3() //обязательно указывается тип данных которые будем передавать. в данном случае int
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);





// 4 тип методов -  что-то принимают, но что-то передают.

/*string Method4(int count, string text) //обязательно указывается тип данных, которые будем передавать. В данном случае int и string
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
string res = Method4(10, "asdf");
Console.WriteLine(res);*/

//Далее тоже самое но через цикл for
string Method4(int count, string text) //обязательно указывается тип данных, которые будем передавать. В данном случае int и string
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;     
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);