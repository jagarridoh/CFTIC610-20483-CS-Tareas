------

# QUESTION 132

------

You define a class by using the following code:

```c#
public class Department
{
	public int Id { get; set; }
    public string Name { get; set; }
    public string Manager { get; set; }
    public int BuildingId { get; set; }
}
```

You create a collection by using the following code:

```c#
Department[] departments =
{
	new Department 
    { Id = 1, Name = "Accounting", Manager = "User1", BuildingId = 15 },
	new Department 
    { Id = 2, Name = "Sales", Manager = "User2", BuildingId = 3 },
	new Department 
    { Id = 3, Name = "IT", Manager = "User3", BuildingId = 15 },
	new Department 
    { Id = 4, Name = "Marketing", Manager = "User4", BuildingId = 3 }
};
var output = 
    from d in departments
    group d by d.BuildingId into dp
    select new { sorted = dp.Key, Department = dp };
```

Complete next statements:

1. The output collection will contain /* RELLENAR AQUI */  object(s).

   Respuestas posibles: 0, 1, 2, 3, 4

2. The sorted property of the output collection will be the /* RELLENAR AQUI */  type.

   Respuestas posibles: byte, int, string, var





------

### RESPUESTA

A primera vista, como el LinQ está agrupando por BuildingId y solo hay dos edificios, habrá solo dos elementos en la salida y el tipo de "sorted" será el mismo de Id, o sea int.

Correct Answer: 2, int
Section: Volume B
Explanation/Reference: SIN EXPLICACIONES EN EL PDF.

------

### PROGRAMACIÓN DE COMPROBACIÓN

Ejecutar ProjectQ132, y se comprueba que solo hay dos elementos y que el tipo es System.Int32 = int.

