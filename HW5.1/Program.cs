// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);

if(anyNumberText.Length > 2)
{
    Console.WriteLine("Третья цифра вашего числа: " + anyNumberText[2]);
}
else
{
    Console.WriteLine("В вашем числе третьей цифры нет.");
}