using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQ040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio Main ProjectQ040");
            Runner r = new Runner();
            r.Add("Libro 1 - Nombre");
            Console.WriteLine("Fin Main ProjectQ040");
            Console.ReadKey();
        }
    }

    
}

public class Book
{
    public Book(string nombre) { }
}

public delegate void AddBookCallback(int i);
public class BookTracker
{
    List<Book> books = new List<Book>();
    public void AddBook(string name, AddBookCallback callback)
    {
        Console.WriteLine("Inicio de AddBook");
        books.Add(new Book(name));
        callback(books.Count);
        Console.WriteLine("Fin de AddBook");
    }
}
/* LINEA 11 */
// OPTION C. delegate void AddBookDelegate(BookTracker bookTracker);                // OPTION C. 
// OPTION D. delegate void AddBookDelegate(string name, AddBookCallback callback);  // OPTION D.
public class Runner
{
    /* LINEA 14 */
    // OPTION A. private static void PrintBookCount(int i) { Console.WriteLine("PrintBookCount: {0}", i); }  // OPTION A.
    BookTracker tracker = new BookTracker();
    public void Add(string name)
    {
        /* LINEA 18 */
        // OPTION A. AddBookCallback callback = PrintBookCount;    // OPTION A.
        // OPTION B. tracker.AddBook(name, delegate (int i) { Console.WriteLine("Dentro de la funcion anónima de la option B: {0}", i); });   // OPTION B.
        // OPTION C. AddBookDelegate addDelegate = (bookTracker) => { Console.WriteLine("Dentro de la funcion anónima de la option C: {0}", bookTracker); }; // OPTION C. 
        // OPTION C. addDelegate(tracker);                                   // OPTION C.    
        // OPTION D. AddBookDelegate adder = (i, callback) => { Console.WriteLine("Dentro de la funcion anónima de la option D. i: {0}, callback: {1}", i, callback); };       // OPTION D. 
    }
}