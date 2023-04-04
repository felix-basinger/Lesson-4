//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

SumDig();

void SumDig()
{   
    double num;
    System.Console.Write("Enter your number: ");
    if(double.TryParse(Console.ReadLine(), out num))
    {   
        if(num < 0) System.Console.WriteLine("Error! It's a negative number");
        else
        {
            string str = num.ToString();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int numb = Convert.ToInt32(Convert.ToString(str[i]));
                count += numb;
            }
            System.Console.WriteLine($"Sum of digits in your number = {count}");
        }
        
    }
    else System.Console.WriteLine("It's not a number");
}