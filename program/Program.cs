Console.WriteLine("Программа, из имеющегося массива строк формирует массив из строк, длина которых <=3 символам");
string[] arrayOne = new string[5] {"3", "hello", "world", "res",":-("};
string[] arrayTwo = new string[3];

CreatingASecondArray(arrayOne, arrayTwo);//Заполнение второго массива 
PrintArray(arrayOne, arrayTwo);//Вывод результата в терминал

void CreatingASecondArray (string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if(arrayOne[i].Length < 4)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}
void PrintArray(string[] arrayOne, string[] arrayTwo)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        Console.Write(arrayOne[i] + "; ");
    }
    Console.Write("] -> [ ");
    for (int i = 0; i < arrayTwo.Length; i++)
    {
        Console.Write(arrayTwo[i] + "; ");
    }
    Console.Write("]");
    Console.WriteLine();
}
