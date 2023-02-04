// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Задайте номер четверти");
int numberA = int.Parse(Console.ReadLine() ?? "0");

if(numberA > 0 && numberA <= 4){
    if(numberA == 1){
        Console.WriteLine("Координаты точек, лежащих в 1 четверти, по x > 0, по y > 0.");
    }
    if(numberA == 2){
        Console.WriteLine("Координаты точек, лежащих во 2 четверти, по x < 0, по y > 0.");
    }
    if(numberA == 3){
        Console.WriteLine("Координаты точек, лежащих в 3 четверти, по x < 0, по y < 0.");
    }
    if(numberA == 4){
        Console.WriteLine("Координаты точек, лежащих в 4 четверти, по x > 0, по y < 0.");
    }
}
else{
    Console.WriteLine("Нет такой четверти.");
}