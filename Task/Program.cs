Console.WriteLine("Введите размер массива: ");
int size  = int.Parse(Console.ReadLine());
string[] array1 = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write("Введите элемент массива: ");
    array1[i] = Convert.ToString(Console.ReadLine());
}  
Console.WriteLine("Первоначальный массив: " + $"[{string.Join(", ", array1)}]");

int n = 0;
for (int i = 0; i < array1.Length; i++){
	if (array1[i].Length <= 3) 
    	n++;
}
string[] array2 = new string[n];
int j = 0;
for (int i = 0; i < array1.Length; i++){
    if (array1[i].Length <= 3)
    {
        array2[j] = array1[i];
        j++;
    }
}
Console.Write("Полученный массив: " + $"[{string.Join(", ", array2)}]");