------

# QUESTION 40

#### PREGUNTA REVISABLE

------

You are developing an application that includes a class named BookTracker for tracking library books. The
application includes the following code segment.  

```c#
public delegate void AddBookCallback(int i);
public class BookTracker
{
    List<Book> books = new List<Book>();
    public void AddBook(string name, AddBookCallback callback)
    {
        books.Add(new Book(name));
        callback(books.Count);
    }
}
/* LINEA 11 */
public class Runner
{
    /* LINEA 14 */
    BookTracker tracker = new BookTracker();
    public void Add(string name)
    {
        /* LINEA 18 */
    }
}
```

You need to add a user to the BookTracker instance. What should you do?

#### OPTION A 

Insert the following code segment at line 14:

```c#
private static void PrintBookCount(int i)
{
    ...
}
```

Insert the following code segment at line 18:

```c#
AddBookCallback callback = PrintBookCount;
```

#### OPTION B 

Insert the following code segment at line 18:

```c#
tracker.AddBook(name, delegate(int i)
{
    ...
});
```

#### OPTION C 

Insert the following code segment at line 11:

```c#
delegate void AddBookDelegate(BookTracker bookTracker);
```

Insert the following code segment at line 18:

```c#
AddBookDelegate addDelegate = (bookTracker) => 
{
    ...
};
addDelegate(tracker);
```

#### OPTION D 

Insert the following code segment at line 11:

```c#
delegate void AddBookDelegate(string name, AddBookCallback callback);
```

Insert the following code segment at line 18:

```c#
AddBookDelegate adder = (i, callback) => 
{
    ...
};
```





------

Correct Answer:  OPTION B

Section: Volume A
Explanation:
SIN EXPLICACIONES EN EL PDF.

------

### COMENTARIOS

- A simple vista: 
  - OPTION A : como no llama a AddBook() desde Add(), da la impresión de que no se va a añadir el libro.
  - OPTION B: trata con el objeto correcto, el método correcto y pasa una función anónima, con la sintaxis delegate(int i) y cuadra con la definición de delegado de la primera línea.
  - OPTION C:  como no llama a AddBook() desde Add(), da la impresión de que no se va a añadir el libro. Pero ojo, podría ser que la llamada a AddBook() estuviera dentro de los puntos suspensivos, pero esto es mucho liar, igual que crear addDelegate y llamarlo a continuación. La sintaxis de asignar a un delegado una función anónima no recuerdo haberla visto en la teoría.
  - OPTION D: define adder pero no lo utiliza ni tampoco pone llamada a tracker.AddBook().
  - OPTION B: parece la menos mala.
- Para entender más se puede revisar la teoría de delegates:
  - https://geeks.ms/etomas/2010/07/21/c-bsico-delegates/
  - http://www.codedigest.com/Articles/CSHARP/5_Delegates_and_Anonymous_methods_in_C_.aspx
  - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/anonymous-functions
- Para aclarar dudas se prepara proyecto con programación **ProjectQ040**. Para probar cada opción hay que descomentar el código comentado en "Program.cs". Se observa:
  - OPTION A: compila y se ejecuta pero no se añade en la lista de libros, o sea no se llama a AddBook. Opción incorrecta.
  - OPTION B: compila, se ejecuta, se añade en la lista de libros  y se llama al callback. **Ok, y es la respuesta del PDF**.
  - OPTION C: compila, se ejecuta, se llama a la función anónima, pero no hace función de callback si no que se llama de manera directa. No se llama a AddBook con lo que no se añade en la la lista de libros. Opción incorrecta.
  - OPTION D: compila, se ejecuta, pero no se llama a AddBook ni a la función anónima del delegado adder. Opción incorrecta.
