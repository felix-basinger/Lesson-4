//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{   
    System.Console.Write($"Enter the {i + 1} one or two-digit positive number: ");
    array[i] = int.Parse(Console.ReadLine());
    if(array[i] > 99 || array[i] < 0) 
    {
        while(array[i] > 99 || array[i] < 0)
        {
            System.Console.WriteLine("it's too big or negative number!");
            System.Console.Write("Enter the one or two-digit positive number: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }
    else System.Console.Write("");    
    // array[i] = new Random().Next(1,100);
}
Console.WriteLine(string.Join(", ",array));
