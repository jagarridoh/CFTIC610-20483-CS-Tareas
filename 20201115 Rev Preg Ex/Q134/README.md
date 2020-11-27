------

# QUESTION 134

### PREGUNTA TEORICA

------

You are creating an application that reads from a database.
You need to use different databases during the development phase and the testing phase by using conditional compilation techniques.
What should you do?

A. Configure the assembly metadata to use the pre-existing public key for the assembly identity by using the AssemblySignatureKeyAttribute attribute.
B. Disable the strong-name bypass feature of Microsoft .NET Framework in the registry.
C. Configure the Define DEBUG constant setting in Microsoft Visual Studio.
D. Decorate the code by using the [assembly:AssemblyDelaySignAttribute(true)] attribute.





------

### RESPUESTA

Revisando la teoría: 

* AssemblySignatureKeyAttribute : no aparece en el MOC, y en la ayuda de la web de MS, trata de adaptación de tipos de firmas...
* bypass no aparece en el MOC. En la web de MS parece que trata de temas de rendimiento?? https://docs.microsoft.com/en-us/dotnet/standard/assembly/disable-strong-name-bypass-feature
* DEBUG no aparece en el MOC. No está claro que pueda diferenciar la fase de desarrollo y test, pero podría permitirlo con compilación condicional.
* AssemblyDelaySignAttribute no aparece en el MOC. En la web indica: "Specifies that the assembly is not fully signed when created.".



Correct Answer: C
Section: Volume B
Explanation/Reference:
Use one debug version to connect to the development database, and a standard version to connect to the live database.

