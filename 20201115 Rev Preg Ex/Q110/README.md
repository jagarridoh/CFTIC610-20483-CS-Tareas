------

# QUESTION 110

------

You are developing a method named GenerateHash that will create the hash value for a file. The method
includes the following code. 

```c#
public byte[] GenerateHash(string filename, string hashAlgorithm)
{
	var signatureAlgo = HashAlgorithm.Create(hashAlgorithm);
    var fileBuffer = System.IO.File.ReadAllBytes(filename);
    // LINEA 5 INSERTAR CODIGO AQUÍ
}
```

You need to return the cryptographic hash of the bytes contained in the fileBuffer variable.
Which code segment should you insert at line 05;

A. 

```c#
var outputBuffer = new byte[fileBuffer.Length];
signatureAlgo.TransformBlock(fileBuffer, 0, fileBuffer.Length, outputBuffer, 0);
signatureAlgo.TransformFinalBlock(fileBuffer, fileBuffer.Length - 1, fileBuffer.Length);
return outputBuffer;
```

B. 

```c#
signatureAlgo.ComputeHash(fileBuffer);
return signatureAlgo.GetHashCode();
```

C. 

```c#
var outputBuffer = new byte[fileBuffer.Length];
signatureAlgo.TransformBlock(fileBuffer, 0, fileBuffer.Length, outputBuffer, 0);
return outputBuffer;
```

D. 

```c#
return signatureAlgo.ComputeHash(fileBuffer);
```





------

### RESPUESTA



A primera vista y revisando la teoría MOC Módulo 13, Lesson 1, Hasing Data.

* A. No utiliza "ComputeHash(...)" para calcular el hash. Además los métodos TransformBlock y TransformFinalBlock no aparecen en el MOC.
* B. Según la teoría, el hash es devuelto por ComputeHash(). GetHashCode() no aparece en el MOC.
* C. Mismo comentario del punto A.
* D. Es el más acorde a la teoría. 

Correct Answer: D
Section: Volume b
Explanation/Reference: SIN EXPLICACIONES EN EL PDF.

------

### PROGRAMACIÓN DE COMPROBACIÓN

Para las posibles respuestas:

* A. Compila pero falla en tiempo de ejecución.
* B. No compila.
* C. Compila, se ejecuta sin error pero devuelve el mismo texto.
* D. Compila, se ejecuta sin error y devuelve binario.





















