//Задача 25: Используя определение степени числа, напишите цикл, 
// принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void Zadacha25()
{
    Console.WriteLine("Enter a first number");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a second number");
    int number2 = Convert.ToInt32(Console.ReadLine());
    double itog = 1;
    for (int i = 1; i<=number2; i++)
    {
        itog =itog*number1;
    }
    Console.WriteLine(itog);
}
//Zadacha25();
//Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
void Zadacha27()
{
     Console.WriteLine("enter a number");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int numberN = number;
    int sum = 0;

       while(numberN > 0)
        {
            sum = sum + numberN%10;
            numberN/=10;
        }
   Console.WriteLine(sum);
}
//Zadacha27();
//Задача 29: Напишите программу, которая задаёт массив из 8 случайных
// целых чисел и выводит отсортированный по модулю массив.
void Zadacha29()
{
    void FillArray(int[] collection)
        {
            int lenght = collection.Length;
    
            for (int index = 0; index<lenght; index++)
            {
                collection[index] = new Random().Next(-100, 101);
            }
        }
    void PrintArray(int[] col)
    {
        int count = col.Length;
        for(int position = 0; position < count; position++)
        {
            Console.Write(col[position]+" ");
        }
    }
    void SelectionSort(int[] collect)
        {
            for (int i=0; i < collect.Length - 1; i++)
            {
                int minPosition = i;
        
                for (int j = i + 1; j < collect.Length; j++)
                {
                    if (Math.Abs(collect[j]) < Math.Abs(collect[minPosition])) minPosition = j;
                }
        int temp = collect[i];
        collect[i] = collect[minPosition];
        collect[minPosition] = temp;
    }
}
    Random random = new Random();
    int size = random.Next(5, 12);
    int[] numbers = new int[size];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    SelectionSort(numbers);
    PrintArray(numbers);
}
Zadacha29();