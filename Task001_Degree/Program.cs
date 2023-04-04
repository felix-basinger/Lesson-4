// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Main();
 
void Main()
{
    bool Work = true;
    while(Work)
    {
        System.Console.Write("Let's start! Enter y/n: ");
        string a = System.Console.ReadLine();
        switch(a)
        {
            case "y":
            System.Console.Write("Enter number A: ");
            int A = int.Parse(Console.ReadLine());
            System.Console.Write("Enter number B: ");
            int B = int.Parse(Console.ReadLine());
            Degree(A, B);
            break;

            case "n":
            Work = false;
            break;
        }
    }
}

void Degree(int A, int B)
{  
   if(B == 0) System.Console.WriteLine($"{A} ^ {B} = 1");
   else
   {
   double deg = 1;
   for(int i = 0; i < B; i++)
   {
       deg *= A;
   } 
   System.Console.WriteLine($"{A} ^ {B} = {deg}");
   }
}  
 