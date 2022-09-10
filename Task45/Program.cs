// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{ 
    array[i] = rand.Next(0, 20);
}  
Console.WriteLine('[' +string.Join(",", array) + ']');

int[] copy = new int[array.Length];
for (int i = 0; i < array.Length; i++) 
 {
     copy[i] = array[i];
}
Console.WriteLine('[' +string.Join(", ", copy) + ']');            







//Console.WriteLine("Hello, World!");
