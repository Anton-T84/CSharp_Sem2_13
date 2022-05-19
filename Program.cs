/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int EnterNumberTest()
{
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt)
    {
        Console.Write("Введите число : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt))
        {
            number = numberInt;
            readlineFromStrToInt = false;
        }
        else Console.WriteLine("Ввели не число , повторите попытку");
    }
    return number;
}

string number = Convert.ToString(EnterNumberTest());

if (number[0] == '-')
{
    if (number.Length >=4) Console.WriteLine($"{number} - > {number[3]}");
    else Console.WriteLine($" {number} - > нет 3го числа");
}
else
{
    if (number.Length >=3) Console.WriteLine($"{number} - > {number[2]}");
    else Console.WriteLine($" {number} - > нет 3го числа");
}

