//Example_001
// Задача вывода Hello World!
// Console.WriteLine("123 Hello, World!");

//Example_002
// Задача вывода приветствия пользователя.
//Console.WriteLine("Введите Ваше имя ");
//string username=Console.ReadLine();
//Console.Write("Привет, ");
//Console.Write(username);
//Console.Write("!");

//Example_003
//написать программу, выводящую сумму двух натуральных чисел на экран.

//Console.WriteLine("Введите два числа ");
//int numberA=Convert.ToInt32(Console.ReadLine());
//int numberB=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(numberA+numberB);

//Example_004
//написать программу выводящую частное двух чисел.
//double numberA = new Random().Next(1,10);
//double numberB = new Random().Next(1,10);
//Console.WriteLine(numberA);
//Console.WriteLine(numberB);
//double result = numberA/numberB;
//Console.WriteLine(result);

//Example_005
//Написать программу, приветствующую "любимчика" по-особенному.
//Console.WriteLine("Введите ваше имя: ");
//string username = Console.ReadLine();

//if(username.ToLower() == "Маша")
//{
//Console.WriteLine("Ура, это же Маша!");
//}
//else
//{
//  Console.Write("Привет, ");
//Console.WriteLine(username);
//}

//Example_006

int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);