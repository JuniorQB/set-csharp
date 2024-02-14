class Program
{
    public static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();

        Console.Write("How many students for course A? ");
        int studentsCourseA = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentsCourseA; i++)
        {
            int register = int.Parse(Console.ReadLine());
            set.Add(register);
        }

        Console.Write("How many students for course B? ");
        int studentsCourseB = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentsCourseB; i++)
        {
            int register = int.Parse(Console.ReadLine());
            set.Add(register);
        }

        Console.Write("How many students for course C? ");
        int studentsCourseC = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentsCourseC; i++)
        {
            int register = int.Parse(Console.ReadLine());
            set.Add(register);
        }

        Console.WriteLine(set.Count);
    }
}