// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите порядковый номер дня недели");
int day = int.Parse(Console.ReadLine() ?? "0");

if(day > 0 && day < 8){
    if (day == 6 || day == 7){
        Console.WriteLine("Это выходной.");
    }
    else {
        Console.WriteLine("Это рабочий день.");
    }
}
else {
    Console.WriteLine("В неделе 7 дней.");
}
