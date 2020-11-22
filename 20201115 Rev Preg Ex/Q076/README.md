------

# QUESTION 76

------

You are developing an application that implements a set of custom exception types. You declare the custom exception types by using the following code segments:

```c#
public class AdventureWorksException : System.Exception { ... }

public class AdventureWorksDbException : AdventureWorksException { ... }

public class AdventureWorksValidationException : AdventureWorksException { ... }
```

The application includes a function named DoWork that throws .NET Framework exceptions and custom
exceptions. The application contains only the following logging methods:

```c#
static void Log(Exception ex) { ... }

static void Log(AdventureWorksException ex) { ... }

static void Log(AdventureWorksValidationException ex) { ... }
```

The application must meet the following requirements:

* When AdventureWorksValidationException exceptions are caught, log the information by using the
  `static void Log(AdventureWorksValidationException ex)` method.
* When AdventureWorksDbException or other AdventureWorksException exceptions are caught, log
  the information by using the `static void Log(AdventureWorksException ex)` method.

You need to meet the requirements.
You have the following code:

```
try 
{
	DoWork();
}
catch <<Target 1>>
{
	Log (ex);
}
catch <<Target 2>>
{
	Log (ex);
}
catch <<Target 3>>
{
	Log (ex);
}
```

Which code segments should you include in <<Target 1>>, <<Target 2>>, and <<Target 3>> to complete the code? 

Each code segment may be used once, more than once, or not at all.  

NOTE: Each correct selection is worth one point.



Code segments:

A. (AdventureWorksValidationException ex)

B. (AdventureWorksException ex)

C. (Exception ex)

D. (AdventureWorksDbException ex)





------

### RESPUESTA

Correct Answer: 

<<Target 1>>  A. (AdventureWorksValidationException ex)

<<Target 2>>  D. (AdventureWorksDbException ex) 

<<Target 3>>  B. (AdventureWorksException ex)


Section: Volume A  
Explanation/Reference:  Sin explicaciones.

Da la impresión de que como no se pide que se logueen las excepciones normales `(clase Exception)`, no se debe tener en cuenta la respuesta `C. (Exception ex)`, ya que la solución alternativa siguiente cumpliría con los requerimientos y también proporcionaría la funcionalidad de que las excepciones normales sean tratadas por `static void Log(Exception ex) { ... }`: <<Target 1>>  A. (AdventureWorksValidationException ex); <<Target 2>>  B. (AdventureWorksException ex); <<Target 3>>  C. (Exception ex).



------

### PROGRAMACIÓN DE COMPROBACIÓN

Se puede comprobar que es correcta la respuesta mediante ProjectQ076. En esta solución, la ejecución acaba con error ya que no se captura Exception por no haberse pedido.

Se puede comprobar la solución alternativa comentando en Program.cs, dentro de la función LanzarDoWork(...): comentando el primer try-catch (líneas 24 a 39) y descomentando el segundo try-catch (líneas 41 a 58). En este caso, se capturan todas las excepciones y el programa acaba sin error.





