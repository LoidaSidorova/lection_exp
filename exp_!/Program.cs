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
//int numberA = new Random().Next(1,10);
//int numberB = new Random().Next(1,10);
//Console.WriteLine(numberA);
//Console.WriteLine(numberB);
//int result = numberA+numberB;
//Console.WriteLine(result);

//Example_005
//Написать программу, приветствующую "любимчика" по-особенному.
Console.WriteLine("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
