// напишите программу, которая на вход принимает число и выводит его квадрат

// Console.WriteLine("Input a number: ");

// int num = Convert.ToInt32(Console.Readline());

// int res = num * num;

// Console.WriteLine($"Quater of {num} is {res}");

//Console.WriteLine("Input number 1");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input number 2");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num2*num2==num1){
//    Console.WriteLine($"{num1} is quater of {num2}");
//   }
//   else{
//       Console.WriteLine($"{num1} is not quater of {num2}");
//   }
// программа выводит все натуральные числа до N

//Console.WriteLine("input number");
//int n = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while (count<n){
// Cosole.WriteLine($"{count} ");
//count++;
//}   /
//на входе трехзначное число, а на выходе последняя цифра
// Console.Writeline("Input a third char number^ ");
//internal class Program
//{
//private static void Main(string[] args)
//{
//int number = Convert.ToInt32(Console.ReadLine());
//if (number < 0)
//            number = number * -1;
//        if (numbrt > 99 && number < 1000)
//{
//    int result = number % 10;
//  Console.writeline($"Last numb is {result}");
//}
//else
//{
//Console.WriteLine($"Number is not 3 character");

//        }
//}
//}

// Программа, которая выдает название дня недели по заданному номеру

internal class Program
{
    private static void Main(string[] args)
    {
        Console.writeline("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num==1){
         Console.Writeline("Monday");
        }
        else if(num==2){
         Console.Writeline("Wensday");}
         else if(num==3){
         Console.Writeline("Thurday");}
         else if(num==4){
         Console.Writeline("Thursday");}
         else if(num==5){
         Console.Writeline("Friday");}
         else if(num==6){
         Console.Writeline("Saturnday");}
         else if(num==7){
         Console.Writeline("Sunday");}
         }
         else{
            Consol.WriteLine("Unknow nomber of day");
            
         }

}