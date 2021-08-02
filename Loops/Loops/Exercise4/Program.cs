namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i]);
            }
            Console.WriteLine("\n");
            foreach (char v in vowels)
            {
                Console.Write(v);
            }
            Console.WriteLine("\n");
        }
    }
}

