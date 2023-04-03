/*Создать консольное приложение, которое будет принимать 2 любых числа одного типа (int, float, double)
 и показывать какое больше, а также выводить их сумму.
*/

int int1 = 0;
int int2 = 0;

double double1;
double double2;

//Первое число
Console.WriteLine("Введите первое число");
string? str1 = "";
str1 = Console.ReadLine();
bool isInt = int.TryParse(str1, out int1);
if (isInt) {
    int1 = int.Parse(str1);
    Console.WriteLine("Тип числа - int.");

} 
else{
//Проверить на возможность 
bool isDouble = double.TryParse(str1, out double1);
if (isDouble) {
    double1 = double.Parse(str1);
    Console.WriteLine("Тип числа - double.");

}

else Console.WriteLine("Не верный формат числа");
}





//Второе число
Console.WriteLine("Введите второе число");
string? str2 = "";
str2 = Console.ReadLine();



int2 = int.Parse(str2);

if(int1 > int2){
Console.WriteLine($"{int1} больше, чем {int2}");
}
else { 
Console.WriteLine($"{int2} больше, чем {int1}");
}
Console.WriteLine($"Сумма чисел равна: а{int2 + int1}");
