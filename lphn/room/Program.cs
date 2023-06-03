// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
Console.Write("number=");
int n = int.Parse(Console.ReadLine());

PrintTableOfCubes(n);

void PrintTableOfCubes(int number){
    for(int i = 1; i <= number; i++){
        Console.Write(i * i * i);
        Console.Write(" ");
    }
}
