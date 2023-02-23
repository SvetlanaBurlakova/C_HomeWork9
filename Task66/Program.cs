/* Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}
int SumNumbersBetweenTwoNumbers(int num1, int num2)
{
    if (num1==num2) return num2;
    else
    {
        return num1 + SumNumbersBetweenTwoNumbers(num1+1, num2);
    }
}
int number1 = GetNumber("Введите число 1:");
int number2 = GetNumber("Введите число 2:");
int sum=0;

if (number2>number1) 
    {
        sum = SumNumbersBetweenTwoNumbers(number1, number2);
    }
else 
    {
        sum = SumNumbersBetweenTwoNumbers(number2, number1);
    }
Console.WriteLine(sum);