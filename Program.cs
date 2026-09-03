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
            #region answer_04

            string book = "clean code";
            printbooktitles(book);

            #endregion
            #region answer_05
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            //the expected output is 400 because the method AddBonusPages modifies a local copy of the pages variable, not the original variable in the Main method.
            //To modify the original variable, you would need to pass it by reference using the ref keyword.
            #endregion
            #region answer_06
            double[] bookPrices = { 25.5, 40.0 };
            ApplyDiscount(bookPrices);
            Console.WriteLine(bookPrices[0]);
            //the expected output is 20.5 because the ApplyDiscount method modifies the first element of the bookPrices array, which is a reference type. Therefore, the change is reflected in the original array. 
            #endregion
            #region answer_07
            AddBonusPagesR(ref pages);
            //the output will be 405
            //atherwise Q5:the output will be 400

            #endregion




        }
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library");
        }
        static void printbooktitles(string book)
        {
            Console.WriteLine($"Book Title: {book}");
        }
        static void  AddBonusPages(int pages)
        {
            pages += 5;
        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5.0; 
        }
        static void AddBonusPagesR(ref int pages)
        {
            pages += 5;
        }

    }
}