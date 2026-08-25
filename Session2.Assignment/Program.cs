using System.Security.Cryptography.X509Certificates;

namespace Session2.Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /*Create a Book class with a Title (string) and Pages (int). Create a Book object and store it
             in a variable of type object. Print it.*/

            /// Book book = new Book();

            ///object obj = book;

            ///  Console.WriteLine(obj);

            #endregion

            #region Question02
            /*Using the Book class above, print the result of calling ToString(), Equals() (compare book
            with itself), GetHashCode(), and GetType() on book.*/

            ///Book book1 = new Book();
            ///Console.WriteLine(book1.ToString());
            ///Console.WriteLine(book1.Equals(book1));
            ///Console.WriteLine(book1.GetHashCode());
            ///Console.WriteLine(book1.GetType());

            #endregion

            #region Question03
            /*Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            divide by zero", and then prints "Done" in a finally block.*/

            /// try
            ///{
            ////    int x = 10;
            ///   int y = 0;
            ///   int z = x / y;
            /// }
            /// catch (DivideByZeroException)
            /// {
            ///     Console.WriteLine("Cannot divide by zero");
            /// }
            ///finally
            /// {
            ///     Console.WriteLine("Done");
            /// }
            #endregion

            #region Question04
            /*Declare an int pages = 300; then store it in a double variable without using a cast.*/

            ///int pages = 300;
            ///double pagesDouble = pages;

            #endregion

            #region Question05
            /*Declare a double price = 49.99; then convert it into an int using a cast.*/
            ///double price = 49.99;
            //int priceInt = (int)price;
            #endregion
        }
    }
}
