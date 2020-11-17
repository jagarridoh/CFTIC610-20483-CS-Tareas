------

# QUESTION 25

#### CON ERROR 

------

You are developing an application that includes a class named Kiosk. The Kiosk class includes a static property named Catalog. The Kiosk class is defined by the following code segment. 

```c#
public class Kiosk
{ 
	static Catalog _catalog = null;
    static object _lock = new object();
	public static Catalog Catalog
	{
		get 
		{
			// -> LINEA 9 INSERTAR RESPUESTAS <-	
			return _catalog;
		}
	}
}
```


You have the following requirements:

* Initialize the _catalog field to a Catalog instance.
* Initialize the _catalog field only once.
* Ensure that the application code acquires a lock only when the _catalog object must be instantiated.

You need to meet the requirements.



Which three code segments should you insert in sequence at line 09? 

1. lock (_lock)
2. if (_catalog != null) _catalog = new Catalog();
3. if (_catalog != null)
4. if (_catalog == null) _catalog = new Catalog();
5. if (_catalog == null)

------

Correct Answer:   

* (1) lock (_lock)
* (4) if (_catalog == null) _catalog = new Catalog();

Section: Volume A  
Explanation:  
After taking a lock you must check once again the _catalog field to be sure that other threads didn't instantiated it in the meantime.

------

### COMENTARIOS

- A simple vista: 
  - (1) es el único elemento referente a bloqueos con lo que tendrá que estar. 
  - (2) no se puede usar pues se indica "Initialize the _catalog field only once". 
  - (3) No aporta nada. 
  - (4) Correcto usarla pues solo se inicializa si es nulo. 
  - (5) observar que esta orden sería posible colocarla la primera si tuviera apertura de llaves pues evitaríamos entrar en el lock si no es necesario, cosa que se pide en "Ensure that the application code acquires a lock only when the _catalog object must be instantiated".
  
- Error en enunciado: se pide insertar tres elementos en secuencia y luego son solo 2. Además no parece que se cumpla elúltimo requerimiento.

- Uso de lock() : ver MOC 20483C -> Module 10 -> Lesson 3.

- Dejo para más adelante verificar que la siguiente programación funciona en un programa multithread ya que parece claro:

	```c#
	public class Kiosk
	{ 
		static Catalog _catalog = null;
	    static object _lock = new object();
		public static Catalog Catalog
		{
			get 
			{
				// -> LINEA 9 INSERTAR RESPUESTAS <-	
				if (_catalog == null) {
					lock (_lock) {
						if (_catalog == null) _catalog = new Catalog();
					}
				}
				return _catalog;
			}
		}
	}
	```
	
	


------

