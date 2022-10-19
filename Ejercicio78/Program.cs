
using System.Collections;
using System.Collections.Generic;

class Ejercicio77
{
    static void Main()
    {
        Dictionary<string, string> diccio = new Dictionary<string, string>();
        diccio.Add("Hello", "Hola");
        diccio["see you later"] = "hasta luego";

        Console.WriteLine(diccio["Hola"]);

        if (diccio.ContainsKey("Adios"))
            Console.WriteLine(diccio["Bye"]);
