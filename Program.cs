// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

int num a;

int num b;

Console.Write("Введите число a: ");
num a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
num b = Convert.ToInt32(Console.ReadLine());

if (num a > num b){
    Console.WriteLine("Число a большее, число b  меньшее");
}    
else{
    Console.WriteLine(Число b большее, число a меньшее);
}

