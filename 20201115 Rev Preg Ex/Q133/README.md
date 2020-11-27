------

# QUESTION 133

### PREGUNTA CON ERROR EN LA RESPUESTA

------

You are developing a C# console application that outputs information to the screen. The following code
segments implement the two classes responsible for making calls to the Console object:

```c#
abstract class BaseLogger
{
	public virtual void Log(string message)
    {
        Console.WriteLine("Base: " + message);
    }
    public void LogCompleted() 
    {
        Console.WriteLine("Completed");
    }
}
class Logger : BaseLogger
{
	public override void Log(string message)
    {
        Console.WriteLine(message);
    }
    public new void LogCompleted() 
    {
        Console.WriteLine("Finished");
    }
}
```

When the application is run, the console output must be the following text:

```c#
Log started
Base: Log continuing
Finished
```

You need to ensure that the application outputs the correct text.
Which four lines of code should you use in sequence? (arrange them in the correct order)



1. logger.Log("Base: Log continuing");
2. ((BaseLogger)logger).Log("Log continuing");
3. var logger = new BaseLogger();
4. ((Logger)logger).LogCompleted();
5. logger.Log("Log started");
6. BaseLogger logger = new Logger();
7. logger.LogCompleted();



------

### RESPUESTA

A primera vista, para sacar el primer mensaje necesitaremos la línea 5 y antes la que crea logger, que puede ser la 3 o 6. La 3 no puede ser porque BaseLogger es abstracta y no se puede instanciar. 

Para sacar el segundo mensaje, necesitamos la 1 o 2. El cast de la 2 parece innecesario porque logger ya tiene puesto el tipo BaseLogger en su creación (linea 6). Asimismo, como logger es de tipo Logger(), el método Log que se ejecutará será el de Logger y no el de BaseLogger, ya que se ha hecho overriden y no se ha cortado la herencia. 

Para sacar el tercer mensaje, solo sirve ejecutar el LogCompleted en Logger. Esto requeriría hacer cast a Logger a la variable logger, pero no se ha marcado en la respuesta escogida. Vamos a ejecutarlo.

Correct Answer:

- 6. BaseLogger logger = new Logger();
- 5. logger.Log("Log started");
- 1. logger.Log("Base: Log continuing");
- 7. logger.LogCompleted();

Section: Volume B
Explanation/Reference: 

Note:

* The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.

* An abstract class cannot be instantiated. The purpose of an abstract class is to provide a common definition of a base class that multiple derived classes can share.

  

------

### PROGRAMACIÓN DE COMPROBACIÓN

Ejecutar ProjectQ133, y se comprueba que con la solución del PDF la salida es:

```
Log started
Base: Log continuing
Completed
Presione una tecla para continuar . . .
```

Mientras que si ponemos cast a Logger en la cuarta orden:

```C#
static void Main(string[] args)
        {
            BaseLogger logger = new Logger();
            logger.Log("Log started");
            logger.Log("Base: Log continuing");
            ((Logger)logger).LogCompleted();
        }
```

... el resultado es el pedido:

```
Log started
Base: Log continuing
Finished
Presione una tecla para continuar . . .
```

