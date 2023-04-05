/*Создать консольное приложение, в котором можно задать минимальное и максимальное число (тип int),
 после чего в консоль выводятся все простые числа в указанном промежутке.
*/
Console.WriteLine("Введите минимальное число");
string? str1;
str1 = Console.ReadLine();
int num1 = 0;
if(str1 != null) {
num1 = int.Parse(str1);
}
else Console.WriteLine("Вы ничего не ввели, поэтому будет использован 0.");


Console.WriteLine("Введите максимальное число");
string? str2;
str2 = Console.ReadLine();
int num2 = 0;
if(str2 != null) {
num2 = int.Parse(str2);
}
else Console.WriteLine("Вы ничего не ввели, поэтому будет использован 0.");

//Вызов функции
MakeInterval(num1,num2);

//Функция
void MakeInterval(int first, int second){
if(first < second) {
    for(int i = first; i <= second; i++){
        Console.WriteLine($"{i}");
    }
}}