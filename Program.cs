using System.ComponentModel;

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

            string book = "Clean Code";
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
            #region answer_08
            ReplaceArray(ref bookPrices);
            Console.WriteLine(bookPrices.Length);
            #endregion
            #region answer_09
            TryGetPrice(book, out double price);
            Console.WriteLine(price);
            #endregion
            #region answer_10
            printBookinfo(book, pages);
            printBookinfo(book);
            #endregion
            #region answer_11
            printBookinfo(pages: pages, title: book);
            #endregion
            #region answer_12
            printalltitles(book, "Refactoring", "Design Patterns");
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
        static void AddBonusPages(int pages)
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

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        static bool TryGetPrice(string bookTitle, out double price)
        {
            if (bookTitle == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0.0;
                return false;
            }
        }
        static void printBookinfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }
        static void printalltitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }

        }
    }
}