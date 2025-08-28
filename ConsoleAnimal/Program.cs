// See https://aka.ms/new-console-template for more information
using System.Data.Common;

Console.WriteLine("Hello, World!");

Animales Animal = new Animales();
Animal.Id= 1;
Animal.Nombre = "Perro";
Animal.edad = 10;
Animal.Raza = "Pitbull";
Console.WriteLine(Animal.Id);
Console.WriteLine(Animal.Nombre);
Console.WriteLine(Animal.edad);
Console.WriteLine(Animal.Raza);

public class Animales {
    public int Id;
    public int edad = 0;
    public string? Nombre = "";
    public string? Raza = "";

}


public class Especies {
    public int Id;
    public  String? NomEsp = "";
    public List<Animales>? Animales;
}


public class TipoAlimentaciones{
    public int Id;
    public String? NomAlimen = "";

    public List <Especies>? Especies; 
}


public class Onomatopeyas {
    public int Id;
    public String? NonOnoma = "";
}