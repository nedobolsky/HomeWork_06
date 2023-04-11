// Задача №41
Console.WriteLine("Введите числа разделенные пробелом: ");
string userNumbers = Console.ReadLine();
int[] numbers = userNumbers.Split(' ').Select(Int32.Parse).ToArray();
int PrintArray(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            count++;
        }
    }
    return count;
}
Console.WriteLine(PrintArray(numbers));

// Задача №43
int NumberPoint(string textPoint = ""){
    Console.Write($"Введите координату точки {textPoint}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

double b1 = NumberPoint("b1");
double k1 = NumberPoint("k1");
double b2 = NumberPoint("b2");
double k2 = NumberPoint("k2");
void IntersectionPoint(double b1, double k1, double b2, double k2){
    double x = Math.Round((-b1 + b2) / (k1 - k2), 2);
    Console.WriteLine(x);
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты пересечения двух прямых ({x}, {y})");
}
IntersectionPoint(b1, k1, b2, k2);
