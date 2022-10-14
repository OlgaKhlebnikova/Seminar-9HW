Console.Clear();
Console.WriteLine("Какую задачу вы хотите проверить (1/2/3)? ");
int Task = Convert.ToInt32(Console.ReadLine());

if (Task == 1)
{
    Task1();
}
else if (Task == 2)
{
    Task2();
}
else if (Task == 3)
{
    Task3();
} 


// Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные 
// в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> 2, 4
//M = 4; N = 8 -> 4, 6, 8
void Task1()
{
    Console.WriteLine(" Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии. ");
    Console.WriteLine();
    Console.WriteLine("Введите первое число (M)");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число (N)");
    int N = Convert.ToInt32(Console.ReadLine());
    if (M>N)
    {
       Console.WriteLine("Введите первое число меньше чем второе");

    }
    else
    {
       Recurs(M,N);
    }

    
    void Recurs(int M, int N)
    {
        if (M <= N)
        {
            if (M%2 == 0)
            {           
            Console.Write(" " + M);
            M = M+2;
            Recurs(M,N);
            }
            else
            {
            M++; 
            Recurs(M,N);  
            }
            
        }
        else  return;
    }
}    


//Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

void Task2()

{
    Console.WriteLine(" Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии. ");
    Console.WriteLine();
    Console.WriteLine("Введите первое число (M)");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число (N)");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = SumBetweenMandN(M,N);
   
    if (M > N)
    {
       Console.WriteLine("Введите первое число меньше чем второе");

    }
    else
    {
       Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {sum}");
    }

    
   int SumBetweenMandN(int M, int N)
    {
        if (M < N) 
        {   
        return M + SumBetweenMandN(M+1, N);
        }
        else
        {
            return M;
        }
    }    

}

//Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
//M = 28; N = 7 -> 7
void Task3()

{
    Console.WriteLine(" Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии. ");
    Console.WriteLine();
    Console.WriteLine("Введите первое число (M)");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число (N)");
    int N = Convert.ToInt32(Console.ReadLine());
    int a = CommonDivisor(M,N);
   
    if (M < N)
    {
       Console.WriteLine("Введите первое число больш чем второе");

    }
    else
    {
        Console.WriteLine($"НОД ({M}, {N}) равен {a}");

    }

    
   int CommonDivisor(int M, int N)
    {
        
        if (M % N == 0) 
        {   
        return N;
        }
        else
        {
          return CommonDivisor (N, (M % N));

         }
    }    

}