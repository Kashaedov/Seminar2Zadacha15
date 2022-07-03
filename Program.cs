Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
nedely (number1);
void  nedely (int number1 )
{
    if (number1 > 7)
    {
        Console.WriteLine ( "Такого дня недели нет :) ");

    }
    else if (number1 == 1)  Console.WriteLine ("Понедельник! Будний день.");
    else if (number1 == 2)  Console.WriteLine ("Вторник! Будний день.");
    else if (number1 == 3)  Console.WriteLine ("Среда! Будний день."); 
    else if (number1 == 4)  Console.WriteLine ("Четверг! Будний день.");
    else if (number1 == 5)  Console.WriteLine ("Пятница! Будний день.");
    else if (number1 == 6)  Console.WriteLine ("Суббота! Выходной день.");
    else if (number1 == 7)  Console.WriteLine ("Воскресенье! Выходной день.");
    
}