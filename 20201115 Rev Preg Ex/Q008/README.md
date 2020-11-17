------

# QUESTION 8

------

An application receives JSON data in the following format:

```c#
{ "FirstName" : "David",
  "LastName" : "Jones",
  "Values" : [0, 1, 2] }
```

The application includes the following code segment.

```c#
public class Name
{ 
	public int [] Values {get; set; }
	public string FirstName {get; set; }
	public string LastName {get; set; }
}
public static Name ConvertToName (string json) 
{
	var ser = new JavascriptSerializer();
	-> LINEA 10 A RELLENAR <-
}
```

You need to ensure that the ConvertToName() method returns the JSON input string as a Name object.

Which code segment should you insert at line 10?

A. Return ser.ConvertToType\<Name>(json);  
B. Return ser.DeserializeObject(json);  
C. Return ser.Deserialize\<Name>(json);  
D. Return (Name)ser.Serialize(json);   



------

Correct Answer: C  
Section: Volume A  
Explanation:  
JavaScriptSerializer.Deserialize\<T> - Converts the specified JSON string to an object of type T.  
References: http://msdn.microsoft.com/en-us/library/bb355316.aspx

------

### COMENTARIOS

- A simple vista: la B no puede ser válida por que no develve objeto de tipo Name y lo exige el método ConvertToName. La A por el nombre "ConvertToType" no da pie a esperar que se realice una deserialización de JSON. La D por un lado indica operación de serialización, cuando lo que queremos hacer es lo contrario, y por otro lado el cast de Object a Name parece poco probable que pueda funcionar tan facilmente. La C en cambio tiene buena pinta.
- Respuesta C: effectivamente se indica por qué es correcta en:   http://msdn.microsoft.com/en-us/library/bb355316.aspx 
- Para poder disponer de JavaScriptSerializer, que está dentro del 
  Namespace: System.Web.Script.Serialization, lo primero que he visto ha sido crear: ASP .NET Web Application, por si acaso con .NET Framework 4.7, y tipo Web Forms. Como ésta es la primera pregunta que trato, me limitaré a revisar la programación debugando en VS 2019. La programación está en ...\Q008\SolucionQ008\ProyectoQ008\Default.aspx.cs. Y hay que poner un breakpoint en la primera linea del método "Page_Load()".
- Los resultados de ejecutar la programación confirman lo dicho:
  - //A. return ser.ConvertToType<Name>(json);    //A. Error runtime: System.InvalidOperationException: 'No se puede convertir el objeto de tipo 'System.String' en el tipo 'ProyectoQ008.Name''
  - //B. return ser.DeserializeObject(json);      //B. Error en build: Error CS0266  Cannot implicitly convert type 'object' to 'ProyectoQ008.Name'.An explicit conversion exists (are you missing a cast?) ProyectoQ008
  - //C. return ser.Deserialize<Name> (json);     //C.  FUNCIONA y se confirma la respuesta del PDF
  - //D. return(Name)ser.Serialize(json);         //D. Error en build: Error CS0030  Cannot convert type 'string' to 'ProyectoQ008.Name' ProyectoQ008 

------

