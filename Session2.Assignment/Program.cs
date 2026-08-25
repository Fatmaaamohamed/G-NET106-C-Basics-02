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

            #region Question06
            /*Given string pagesText = "464";, convert it into an int using the Convert class.*/

            /// string pagesText = "464";
            /// int pagesInt = Convert.ToInt32(pagesText);
            #endregion

            #region Question07
            /*Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
            "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.*/
            /// string yearText = "2023";
            /// int year =int.Parse(yearText);
            /// Console.WriteLine($"year: {year}");
            #endregion

            #region Question07 part 2
            /*Then given string badText =
            "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails*/
            ///string badtext = "abc";
            ///bool flag = int.TryParse(badtext ,out int result) ;
            /// if (!flag) { 
            /// Console.WriteLine("Invalid number");
            /// }
            #endregion

            #region Question08
            /*Given int pages = 464;, convert it into a string using ToString() and print its type using
            GetType() to prove it's now a string.*/

            ///int Pages = 464;
            ///string pagesText = Pages.ToString();
            ///Console.WriteLine(pagesText.GetType());

            #endregion

            #region Question09
            /*Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
            value.*/
            /// int? year = null;
            ///Console.WriteLine($"year has a value: {year.HasValue}");
            ///year = 2023;
            ///Console.WriteLine($"year: {year}");
            #endregion

            #region Question10
            /*Declare a string? reviewer = null;. Print whether it is null.*/
            ///string ? reviewer = null;
           /// Console.WriteLine(reviewer == null);
            #endregion
        }
    }
}
