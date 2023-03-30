string minVal= " Наименьшее значение : ";
string maxVal= " Наибольшее значение : ";
//Логические переменные
bool a = true;
Console.WriteLine($"I think it is {a}");
//byte
Console.WriteLine("Тип byte." + minVal + byte.MinValue + maxVal + byte.MaxValue );
//int
Console.WriteLine("Тип int." + minVal + int.MinValue + maxVal + int.MaxValue );
//long
Console.WriteLine("Тип long." + minVal + long.MinValue + maxVal + long.MaxValue );
//float
Console.WriteLine("Тип float." + minVal + float.MinValue + maxVal + float.MaxValue );
//double
Console.WriteLine("Тип double." + minVal + double.MinValue + maxVal + double.MaxValue );
//char
char l, m;
l ='к'; m = 'у';
Console.WriteLine($"{l}{m}!");
//string
string n;
n = "Конец.";
Console.WriteLine($"{n}");