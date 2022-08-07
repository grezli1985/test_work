/*  Задача: 

Примеры:

{"hello", "2", "world", ":-)"} -> ["2", ":-)"]

{"1234", "1567", "-2", "computer science"} -> ["-2"]

{"Russia", "Denmark", "Kazan"} -> [] */

Zadacha();

void Zadacha()
{
    string[]array = {"hello", "2", "world", ":-)"}; 
    PrintArray(array);
    Console.WriteLine();
    SortArray(array);
    Console.WriteLine();
}

