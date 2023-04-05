/*Создать консольное приложение, в котором можно задать минимальное и максимальное число (тип int),
 после чего в консоль выводятся все простые числа в указанном промежутке.
*/
//Вызов функции
MakeInterval(5,7);

//Функция
void MakeInterval(int first, int second){
if(first < second) {
    for(int i = first; i <= second; i++){
        Console.WriteLine($"{i}");
    }
}}