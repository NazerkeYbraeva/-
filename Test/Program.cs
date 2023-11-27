class Program
{
    static void Main()
    {

        Console.Write("Введите строки через запятую: ");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(", ");

        string[] newArray = FilterStrings(originalArray);

        Console.WriteLine("Новый массив:");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write($"{newArray[i]} ");
        }

        Console.ReadKey();
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}