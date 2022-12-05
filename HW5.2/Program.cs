// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру от 1 до 7 и узнаете является ли этот день выходным: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Выходной!");
}
else if(dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Необходимо ввести цифру от 1 до 7. Повторите запрос.");
}
else Console.WriteLine("Будний день.");