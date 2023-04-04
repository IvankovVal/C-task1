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
    Console.WriteLine($"{num1Int + num2Int}");
}