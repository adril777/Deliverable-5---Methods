using System;
class HelloWorld
{
    // Random Method
    static int[] random(int length)
    {
        int[] array = new int[length];
        Random r = new Random();
        int i = 0;
        // Implement loop to show up random numbers between 10 to 50
        for (; i < length; i++) array[i] = r.Next(10, 50);
        return array;
    }
    // Sum Method
    static int sum(int[] array)
    {
        int i = 0, total = 0;
        // Implement loop to find the sum of array
        for (; i < array.Length; i++) total += array[i];
        return total;
    }
    static void Main()
    {
        int length = -1;
        bool isValid = true;
        do
        {
            // validate user input length using try catch
            try
            {
                length = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                isValid = false;
                Console.WriteLine("Invalid Input!!");
            }
            // validate length in which integer number must be between 5 and 15
            if (isValid && (length < 5 || length > 15))
                Console.WriteLine("Integer number must be between 5 and 15.");
            isValid = true;

        } while (!isValid || (length < 5 || length > 15)); 
        // call random method
        int[] array = random(length);
        // display array numbers
        Console.Write("The elements of the arrays are: ");
        int i = 0;
        for (; i < length; i++) Console.Write(array[i] + " ");
        Console.WriteLine();
        Console.WriteLine();
        // call sum method
        int total = sum(array);
        // display sum of array
        Console.Write("The sum is: " + total);

    }
}
