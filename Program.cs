//Логические переменные
bool a = true;
Console.WriteLine($"I think it is {a}");
//byte
byte b, c;
b = 0; c = 255;
Console.WriteLine($"{b} - наименьший из byte, а {c} - наибольшее.");
//int
int d, e;
d = -2147483648; e = 2147483647;
Console.WriteLine($"{d} - наименьший из int, а {e} - наибольшее.");
//long
long f, g;
f = -9223372036854775808; g = 9223372036854775807;
Console.WriteLine($"{f} - наименьший из long, а {g} - наибольшее.");
//float
float h, i;
h = 3.4e38f; i = -3.4e38f;
Console.WriteLine($"{h} - наименьший из float, а {i} - наибольшее.");
//double
double j, k;
j = 5e-324; k = 1.7e+308;
Console.WriteLine($"{j} - наименьший из double, а {k} - наибольшее.");
//char
char l, m;
l ='к'; m = 'у';
Console.WriteLine($"{l}{m}!");
//string
string n;
n = "Конец.";
Console.WriteLine($"{n}");