using System;

/*
1. Declarar array de 5 notas e imprimir cada una.
2. Calcular el promedio de un array de notas.
3. Encontrar el maximo y minimo de un array.
4. Invertir un array sin usar metodos de .NET.
5. Contar cuantos elementos son mayores a 7.
6. Crear List<string> de tareas y agregar 3 items.
7. Eliminar una tarea de la lista y verificar Count.
8. Recorrer la lista con foreach.
9. Crear array 2D 3x3 e imprimir la diagonal.
10. Verificar si un elemento existe en el array con un bucle.
*/



class Program
{
    static void Main()
    {
// 1. Declarar array de 5 notas e imprimir cada una.
Console.WriteLine("Consigna 1");
int[] notas = {8,6,2,7,9};
Console.WriteLine(notas[0]);
Console.WriteLine(notas[1]);
Console.WriteLine(notas[2]);
Console.WriteLine(notas[3]);
Console.WriteLine(notas[4]);
// 2. Calcular el promedio de un array de notas.
Console.WriteLine("Consigna 2");
int promedio=0;
for(int i=0; i<notas.Length;i++){
    promedio=promedio+notas[i];
}
int promedio1=notas.Length;
Console.WriteLine("El promedio de las notas es: " + promedio/promedio1);
// 3. Encontrar el maximo y minimo de un array.
Console.WriteLine("Consigna 3");
int maximo=notas[0];
int minimo=notas[0];
for(int i = 1;i<notas.Length;i++){
    if (notas[i] > maximo){
        maximo = notas[i];
            }
    if (notas[i] < minimo){
        minimo = notas[i];
            }
}
Console.WriteLine($"El valor maximo es: {maximo}");
Console.WriteLine($"El valor minimo es: {minimo}");
// 4. Invertir un array sin usar metodos de .NET.
int[] numeros = { 1, 2, 3, 4, 5 };

        int inicio = 0;
        int fin = numeros.Length - 1;    
        Console.WriteLine("Array original: ");    
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        while (inicio < fin)
        {
            int temporal = numeros[inicio];
            numeros[inicio] = numeros[fin];
            numeros[fin] = temporal;
            inicio++;
            fin--;
        }
        Console.WriteLine("\nArray invertido: ");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
Console.WriteLine("\nConsigna 4");
// 5. Contar cuantos elementos son mayores a 7.
Console.WriteLine("Consigna 5");
int Contador=0;
for(int i=0;i<notas.Length;i++){
    if (notas[i]>7){
        Contador++;
        }
    }
Console.WriteLine($"Hay {Contador} elementos mayor a 7");
// 6. Crear List<string> de tareas y agregar 3 items.
Console.WriteLine("Consigna 6");
List<string> tareas = new List<string>();
tareas.Add("Conseguir un gramo de antimateria");
tareas.Add("Moldear la antimateria");
tareas.Add("Sobrevivir dps de conseguir la antimateria");
foreach(string t in tareas){
Console.WriteLine(t);
}
// 7. Eliminar una tarea de la lista y verificar Count.
Console.WriteLine("Consigna 7");
Console.WriteLine($"Elementos en la lista antes de remover uno: {tareas.Count()}");
tareas.Remove("Sobrevivir dps de conseguir la antimateria");
Console.WriteLine($"Elementos en la lista despues de remover uno: {tareas.Count()}");
// 8. Recorrer la lista con foreach.
Console.WriteLine("Consigna 8");
foreach(string t in tareas){
Console.WriteLine(t);
}
// 9. Crear array 2D 3x3 e imprimir la diagonal.
Console.WriteLine("Consigna 9");
int[,] tabla = { {1,2,3}, {4,5,6},{7,8,9} };
Console.WriteLine(tabla[0,0]);
Console.WriteLine(tabla[1,1]);
Console.WriteLine(tabla[2,2]);
// 10. Verificar si un elemento existe en el array con un bucle.
Console.WriteLine("Consigna 10");
int[] elementos={1000,2000,30,12,62,67,67,67,};
    bool esta=false;
    int elemntobuscado=1000;
    for(int i=0; i<elementos.Length; i++){
        if(elementos[i]== elemntobuscado){
            esta=true;
        }

    }
    if(esta==true){
    Console.WriteLine($"El numero {elemntobuscado} si esta en el array");
    }
    else
    {    
    Console.WriteLine($"El numero {elemntobuscado} no esta en el array");
    }

    }
}