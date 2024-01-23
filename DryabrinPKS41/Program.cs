string hello = "Hello"; // Переменная типа String
const string WORLD = "World"; // Константа

Console.WriteLine($"{hello}, {WORLD}!"); // Вывод в консоль

var number = 10.0; // Неявная типизация

int inputInt = Convert.ToInt32(Console.ReadLine()); // Ввод значения и преобразовние в int

bool isTrue = true;
bool isFalse = false; // Переменные типа bool

// ++ = инкремент | -- = декремент
int num1 = 5;
int num2 = num1++; // num1 = 4, num2 = 5
int num3 = ++num2; // num1 = 4, num3 = 5

Console.WriteLine(0b1011); // 11 | Двоичная форма
Console.WriteLine(0x0A); // 10 | Шестнадцатеричная форма

// Арифметические операции
int a = 5 + 10; // 15
int b = 10 / 4; // 2
int c = a * b; // 30
