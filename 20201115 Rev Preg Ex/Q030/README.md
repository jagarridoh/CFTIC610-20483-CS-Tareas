------

# QUESTION 30

#### PREGUNTA CON DERIVADAS TEORICAS 

------

You plan to implement the following interfaces: 

```c#
interface IFahrenheit
{
	double Temp();
}
interface ICelsius
{
	double Temp();
}
```


You have the following methods:

* getCelsiusFromKelvin returns the temperature in Celsius.
* getFahrenheitFromKelvin returns the temperature in Fahrenheit.

You need to implement both interfaces within a class named TempControl. The TempControl class must
return the Celsius temperature as the default temperature if the following code executes.

```c#
TempControl t = new TempControl();
var celsiusTemp = t.Temp();
```

How should you implement the interfaces? To answer, select the appropriate options in the answer area.

NOTE: Each correct selection is worth one point.

```c#
partial class TempControl : /* PONER AQUI PRIMERA SELECCION */
{
	double kelvin;
	public double /* PONER AQUI SEGUNDA SELECCION */
	{
		return getCelsiusFromKelvin();
	}
	double /* PONER AQUI TERCERA SELECCION */
	{
		return getFahrenheitFromKelvin();
	}
}
```



* PRIMERA SELECCION: poner uno de estos textos literalmente incluyendo coma si fuera el caso:
  * ICelsius 
  * IFahrenheit
  * IFahrenheit, ICelsius  
* SEGUNDA SELECCION: poner uno de estos textos literalmente incluyendo . y () si fuera el caso:
  * ICelsius.Temp()
  * IFahrenheit.Temp()
  * Temp()
* TERCERA SELECCION: poner uno de estos textos literalmente incluyendo . y () si fuera el caso:
  * ICelsius.Temp()
  * IFahrenheit.Temp()
  * Temp()

------

Correct Answer: 

* PRIMERA SELECCION : IFahrenheit, ICelsius  
* SEGUNDA SELECCION: ICelsius.Temp()
* TERCERA SELECCION: IFahrenheit.Temp()

Section: Volume A
Explanation:
SIN EXPLICACIONES EN EL PDF.

------

### COMENTARIOS

- A simple vista: 
  - PRIMERA SELECCION: como hay que implementar los dos interfaces, parece obvia.
  - SEGUNDA SELECCION: como se devuelve "getCelsiusFromKelvin", es decir, Celsius, parece claro que esta función implementa el método Temp de la interfaz ICelsius. Y se nos ha pedido implementar las dos interfaces.
  - TERCERA SELECCION: como se devuelve "getFahrenheitFromKelvin", es decir, Fahrenheit, parece claro que esta función implementa el método Temp de la interfaz IFahrenheit. Y se nos ha pedido implementar las dos interfaces.
- Duda sobre el enunciado: 
  - ¿Qué ocurre si se llama directamente a Temp() sin especificar ICelsius ni IFahrenheit() ¿existe un default? En la teoría creo que no se dice nada (MOC 20483C -> Module 4 -> Lesson 2).
- Para aclara la duda anterior se prepara proyecto con programación **ProjectQ030** y se observa:
  - No acepta "public" en "public double ICelsius.Temp()". 
    - Para entender por qué no acepta public: 
      - https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/compiler-messages/cs0106  ("La palabra clave public no está permitida en una declaración explícita de la interfaz. En este caso, quite la palabra clave public de la declaración explícita de la interfaz.")
      - https://stackoverflow.com/questions/2669031/compilation-error-the-modifier-public-is-not-valid-for-this-item-while-expl 
    - Si se quita, entonces no acepta la orden "var celsiusTemp = t.Temp();" pues no encuentra el método "Temp()", ni desde fuera ni desde dentro de la propia clase "Temp" en el método "testear()". 
      - En este caso se tiene que usar: "((ICelsius)t).Temp()" en lugar de "t.Temp()".
      - Es decir, que el comportamiento del objeto al llamarle a Temp() será diferente si el **tipo en ejecución es ICelsius o IFahrenheit, y no estará Temp() definida si el tipo en ejecución es TempControl**.
    - Se puede conseguir que funcione la orden "var celsiusTemp = t.Temp();" si se define el método  "public double Temp()". **Ver proyecto "ProjectQ030_alternativa"**. 
      - En este caso el comportamiento del objeto al llamarle a Temp()  será diferente si el **tipo en ejecución es ICelsius o IFahrenheit o TempControl, pero estará definido para los tres**.
    - **¿Es bueno tener esto en mente de cara al examen de certificación o se presupone que no lo vamos a tener?**




------

