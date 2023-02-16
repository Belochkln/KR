// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам
string[] array = { "=)", "Geek", "123", "two", "+-*/=" };
string word;

for (int i = 0; i < array.Length; i++)
{
    word = array[i];
    if (word.Length <= 3)
    {
        Console.Write(word + " ");
    }
}