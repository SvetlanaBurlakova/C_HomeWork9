/* Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


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
int Akkerman(int m, int n)
{
    if (m==0) return n+1;
    if (n==0 && m>0 ) return Akkerman(m-1,1);
    else return Akkerman(m-1,Akkerman(m,n-1));
}
int m = GetNumber("Введите число m, для расчета функции Аккермана A(m,n):");
int n = GetNumber("Введите число n, для расчета функции Аккермана A(m,n):");
int akkermanNumber=Akkerman(m,n);
Console.WriteLine($"Функция Аккермана A({m},{n}) = {akkermanNumber}");