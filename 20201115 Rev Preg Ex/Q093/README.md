------

# QUESTION 93

------

You are creating a console application named App1.
App1 retrieves data from the Internet by using JavaScript Object Notation (JSON).
You are developing the following code segment.

```c#
public bool ValidateJson(string json, Dictionary<string, object> result)
{
    // LINEA 3 INSERTAR CODIGO AQUÍ
    try 
    {
        result = serializer.Deserialize<Dictionary<string, object>>(json);
        return true;
    }
    catch 
    {
        return false;
    }
}
```

You need to ensure that the code validates the JSON string.
Which code should you insert at line 03?

A. DataContractSerializer serializer = new DataContractSerializer();
B. var serializer = new DataContractSerializer();
C. XmlSerializer serializer = new XmlSerializer();
D. var serializer = new JavaScriptSerializer();





------

### RESPUESTA

A primera vista y revisando la teoría:

* A. DataContractSerializer no aparece en el MOC pero si en la web de MS: https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.datacontractserializer?view=net-5.0 Pero requiere data contract y no tenemos las decoraciones correspondientes. Además la ayuda documenta que genera XML pero no trata de JSON.
* B. Es lo mismo que la A, con lo que ambas son incorrectas.
* C. XmlSerializer serializa a/desde XML.
* D. JavaScriptSerializer sí serializa / deserializa JSON. Ver:  https://docs.microsoft.com/es-es/dotnet/api/system.web.script.serialization.javascriptserializer



Correct Answer: D
Section: Volume A
Explanation/Reference:
The JavaScriptSerializer Class Provides serialization and deserialization functionality for AJAX-enabled applications.
The JavaScriptSerializer class is used internally by the asynchronous communication layer to serialize and deserialize the data that is passed between the browser and the Web server. You cannot access that instance of the serializer. However, this class exposes a public API. Therefore, you can use the class when you want to work with JavaScript Object Notation (JSON) in managed code.



------

### PROGRAMACIÓN DE COMPROBACIÓN

Por usar JavaScriptSerializer opto por trabajar con proyectos .NET Framework 4.6 de tipo Web. Para ver el funcionamiento del programa se tiene que debugar y poner un breakpoint en la primera lína (15) de Page_Load() dentro de Default.aspx.cs.

* El programa con respuesta D genera como cadena JSON a tratar: `"{\"Elemento1\":\"Valor1\",\"Elemento2\":\"Valor2\"}"`. (linea 19, variable: serializado). Y funciona correctamente devolviendo Dictionary<string, object>.
* Respuesta C: no compila: indica que XmlSerializer es inaccesible debido a su nivel de protección. Como esta clase no aparece en el MOC, no profundizo en el tema.
* Respuesta B: no compila: a pesar de haber puesto: `using System.Runtime.Serialization;` no encuentra la clase. 
* Respuesta A: igual que B, no compila.

















