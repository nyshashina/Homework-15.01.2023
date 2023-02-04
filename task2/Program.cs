// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine() ?? "0");

if(numberB * numberB == numberA || numberA * numberA == numberB) {
    Console.WriteLine("Одно число является квадратом другого.");
}
else {
    Console.WriteLine("Никакое из чисел не является квадратом другого.");
}
