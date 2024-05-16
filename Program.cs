namespace Week_2_Challenge_Labs_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            makeTriangle();


            static void makeTriangle() 
            {
                Console.WriteLine("Please enter a character");
                char triangleCharacter = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Please enter a number");
                int triangleWidth = Convert.ToInt32(Console.ReadLine());

                for (int i = triangleWidth; i > 0; i--) 
                {
                    string line = new string(triangleCharacter, i);
                    Console.WriteLine(line);
                }
            }
        }
    }
}
