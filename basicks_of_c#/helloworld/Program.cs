// Basiks of C# programming (Schleifen)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"This is line number {i}");

        }

        int h = 0;

        while(h < 50)
        {
            h++;
            if (h % 2 != 0)
            {
                Console.WriteLine(h + "     Zahl ungrade");
            } else
            {
                Console.WriteLine(h);
            }
        } 

        
    }
}



