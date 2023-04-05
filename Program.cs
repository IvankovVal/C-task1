/*Создать консольное приложение, которое будет принимать 2 любых числа одного типа (int, float, double)
 и показывать какое больше, а также выводить их сумму.
*/
string? str1;
string? str2;

Console.WriteLine("Введите число типа int");
str1 = Console.ReadLine();
Console.WriteLine("Введите второе число типа int");
str2 = Console.ReadLine();

int num1Int;
bool is1numInt = int.TryParse(str1, out num1Int);
int num2Int;
bool is2numInt = int.TryParse(str2, out num2Int);

if(!is1numInt) Console.WriteLine("Не верный ввод первого числа");
if(!is2numInt) Console.WriteLine("Не верный ввод второго числа");
if(is1numInt & is2numInt){
    if(num1Int > num2Int) Console.WriteLine($"{num1Int} больше, чем {num2Int}");
    else Console.WriteLine($"{num2Int} больше, чем {num1Int}");
    Console.WriteLine($"Сумма чисел равна: {num1Int + num2Int}");
}
else Console.WriteLine("Не верный ввод чисел!");
//-------------------------------------------------
Console.WriteLine("Введите число типа float");
str1 = Console.ReadLine();
Console.WriteLine("Введите второе число типа float");
str2 = Console.ReadLine();

float num1Float;
bool is1numFloat = float.TryParse(str1, out num1Float);
float num2Float;
bool is2numFloat = float.TryParse(str2, out num2Float);

if(!is1numFloat) Console.WriteLine("Не верный ввод первого числа");
if(!is2numFloat) Console.WriteLine("Не верный ввод второго числа");
if(is1numFloat & is2numFloat){
    if(num1Float > num2Float) Console.WriteLine($"{num1Float} больше, чем {num2Float}");
    else Console.WriteLine($"{num2Float} больше, чем {num1Float}");
    Console.WriteLine($"Сумма чисел равна: {num1Float + num2Float}");
}
else Console.WriteLine("Не верный ввод чисел!");
//-------------------------------------------------
Console.WriteLine("Введите число типа double");
str1 = Console.ReadLine();
Console.WriteLine("Введите второе число типа double");
str2 = Console.ReadLine();

double num1Double;
bool is1numDouble = double.TryParse(str1, out num1Double);
double num2Double;
bool is2numDouble = double.TryParse(str2, out num2Double);

if(!is1numDouble) Console.WriteLine("Не верный ввод первого числа");
if(!is2numDouble) Console.WriteLine("Не верный ввод второго числа");
if(is1numDouble & is2numDouble){
    if(num1Double > num2Double) Console.WriteLine($"{num1Double} больше, чем {num2Double}");
    else Console.WriteLine($"{num2Double} больше, чем {num1Double}");
    Console.WriteLine($"Сумма чисел равна: {num1Double + num2Double}");
}
else Console.WriteLine("Не верный ввод чисел!");