// Задача: Написать программу, 
// которая из имеющегося массива 
// строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

void FilterAndPrintShortStrings(string[] array)   // Метод принимает на вход массив строк и выводит строки <=3 символов
{
    Console.WriteLine("Строки длиной 3 и меньше:");

    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            Console.WriteLine(str);
        }
    }
}
Console.Write("Введите размерность массива: ");
int size;
while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
{
    Console.WriteLine("Пожалуйста, введите положительное целое число для размерности массива: ");
}
string[] strArray = new string[size];  // создание массива заданного размера

for (int i = 0; i < size; i++)   // Вводим элементы массива
{
   Console.Write($"Введите элемент {i + 1}: ");
            string input = Console.ReadLine();
            
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Пожалуйста, введите строку: ");
                input = Console.ReadLine();
            }

            strArray[i] = input;
}

FilterAndPrintShortStrings(strArray); // Вызываем метод для фильтрации и вывода строк
Console.ReadLine(); //удержание консоли