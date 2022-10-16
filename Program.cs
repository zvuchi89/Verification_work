
Console.WriteLine("Введите элементы через пробел:");
string text = Console.ReadLine();
string[] array_elements = text.Split(new char[] { ' ', ' ', ' ', ' ' },
StringSplitOptions.RemoveEmptyEntries);
var res = from element in array_elements 
          where element.Length <= 3 // определяет фильтр выборки
          select element;  // select - определяет проекцию выбранных значений
if (res.Count() == 0) // возвращает значение
{
    Console.WriteLine("Длина элементов больше 3");
}
else
{
    foreach (string s in res)
    {
        Console.WriteLine("Длина элементов меньше или равна 3: ");
        Console.WriteLine(s);
    }
}

