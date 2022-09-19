Console.WriteLine("Enter a sentence: ");
string[] input = Console.ReadLine().Split(' ');
int size = input.Length;
int count = 0;
string[] array = new string[size];
for(int i = 0; i < input.Length; i++)
{
    if(input[i].Length <= 3)
    {
        array[i] = input[i];
        count++;
        Console.WriteLine(array[i]);
    }
}

Array.Resize(ref array, count);