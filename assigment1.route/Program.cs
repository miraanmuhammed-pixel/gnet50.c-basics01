using System.Globalization;
using Microsoft.VisualBasic;

namespace assigment1.route;

class Program
{
    static void Main(string[] args)
    {

        #region q1

        /*  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it. */
        
        
        // object book1 = new Book() { title = "in the stars", pages = 300 };
        // object book2 = new Book() { title = "in the stars", pages = 300 };
        //
        // Console.WriteLine(book1);
        //

        #endregion

        #region q2

        //Using the Book class above, print the result of calling ToString(), Equals () (compare book with itself, GetHashCode(), and GetType() on
        // Console.WriteLine("to string="+ book1.ToString());
        // Console.WriteLine( "equals="+book1.Equals(book1));
        // Console.WriteLine(book1.Equals(book2));
        // Console.WriteLine("getHashCode="+ book1.GetHashCode());
        // Console.WriteLine("get type="+book1.GetType());
        //
        
        #endregion

        #region q3

        // Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
        // int pages = "464";
        // Compile-time error — you can't put text (string) into an int variable.
        // int pages = 464;

        #endregion

        #region q4

        // Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
        // divide by zero", and then prints "Done" in a finally block.

        // try
        // {
        //     int x = 10;
        //     int y = 0;
        //     int result = x / y;
        //     Console.WriteLine(result);
        // }
        // catch (DivideByZeroException e)
        // {
        //     Console.WriteLine($"error msg={e.Message}");
        //     Console.WriteLine("Cannot divide by zero");
        //     throw;
        // }
        // finally
        // {
        //     Console.WriteLine("all done");
        // }
        //
        //
         #endregion

         #region q5

        // Declare an int pages = 300; then store it in a double variable without using a cast. 
        // int pages = 300;
        // double pages2 = pages;
        // Console.WriteLine(pages2);
        #endregion

        #region q6

     //   Declare a double price = 49.99; then convert it into an int using a cast.

     // double price = 49.99;
     // int price2 = (int)price;
     // Console.WriteLine(price2);

     #endregion

     #region q7
    // Given string pagesText = "464";, convert it into an int using the Convert class.
    // string pagesText = "464";
    // int pages = Convert.ToInt32(pagesText);
    // Console.WriteLine(pages);

    #endregion


    #region Q9

    // Given int pages = 464;, convert it into a string using ToString() and print its type using
    //     GetType() to prove it's now a string.
    // int pages = 464;
    // string pagesText = pages.ToString();
    // Console.WriteLine(pagesText.GetType());
    #endregion
    #region Q8

    // Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
    //  //     "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
    //  string yearText = "2023";
    //  int year = int.Parse(yearText);
    //  Console.WriteLine(year);
    // string badText = "abc";
    // if (int.TryParse(badText, out int numbeResult))
    // {
    //     Console.WriteLine(numbeResult);
    // }else
    // {
    //     Console.WriteLine("Invalid number");
    // }
    // ;



    #endregion

    #region َQ10
   // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
   // // variable, and print both.
   // int copies = 100;
   // object badCopy = copies;
   // int goodCopy =(int) badCopy;
   //
   // Console.WriteLine(badCopy);
   // Console.WriteLine(goodCopy);
   #endregion

   #region Q11

   // Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
   // value.
   
   // int? year = null;
   // Console.WriteLine(year);
   // year = 2023;
   
   
   #endregion

   #region q12

   // Declare a string? reviewer = null;. Print whether it is null.
   // string? reviewer = null;
   // Console.WriteLine(reviewer);
   #endregion

   #region q13
  // Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the
  //  program, and print the result.
  
  // Book? book = new Book();
     // string? bookTitle=book?.title;
     // Console.WriteLine(bookTitle);

     #endregion

     #region q14
     // Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??=
     //  to assign title the value "Untitled" only if it's still null
     // string? sameTitle = bookTitle ?? "untitled";
     // Console.WriteLine(sameTitle);
     // sameTitle ??= "untitled2";
     // Console.WriteLine(sameTitle);
     #endregion

     #region q15

     // Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable
     // string confirmedName using the ! operator.
     
     // string? name="ahmed" ;
     // string confirmedName = name!;
     // Console.WriteLine(confirmedName);

     #endregion
    }
}