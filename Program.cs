/*Создать консольное приложение, которое будет принимать 2 любых числа одного типа (int, float, double)
 и показывать какое больше, а также выводить их сумму.
*/

Console.WriteLine("Введите первое число");
string? str1 = "";
str1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string? str2 = "";
str2 = Console.ReadLine();

int num1 = 0;
int num2 = 0;

num1 = int.Parse(str1);
num2 = int.Parse(str2);

if(num1 > num2){
Console.WriteLine($"{num1} больше, чем {num2}");
}
else { 
Console.WriteLine($"{num2} больше, чем {num1}");
}
Console.WriteLine($"Сумма чисел равна: а{num2 + num1}");
