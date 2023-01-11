using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string GetUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int GetFavNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int fav_number = int.Parse(Console.ReadLine());
            return fav_number;
        }

        static int SquareNumber(int fav_number)
        {
            int square = fav_number * fav_number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        {
            DisplayMessage();

            string user_name = GetUserName();
            int user_num = GetFavNumber();
            int square_num = SquareNumber(user_num);

            DisplayResult(user_name, square_num);

        }
    }
}