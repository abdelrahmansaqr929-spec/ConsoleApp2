namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer_01
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion
            #region answer_02
            int[,] ShelfCopeis = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(ShelfCopeis[1, 0]);
            #endregion
            #region answer_03
            PrintWelcomeMessage();
            #endregion


        }
     static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library");
        }
    }


}