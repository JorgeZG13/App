using System;
namespace Exam;

public class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine("HELADO DE COCO");
        var heladoCoco = new HeladoDeCoco();
        Console.WriteLine($"El precio del helado de coco es de: {heladoCoco.CalcularTotalPrecio()}");
        var topping1 = new Toping1(heladoCoco);
        Console.WriteLine($"El precio del helado de coco con un topping es de: {topping1.CalcularTotalPrecio()}");
        var topping2 = new Topping2(heladoCoco);
        Console.WriteLine($"El precio del helado de coco con dos toppings es de: {topping2.CalcularTotalPrecio()}");
        var topping3 = new Topping3(heladoCoco);
        Console.WriteLine($"El precio del helado de coco con tres toppings es de: {topping3.CalcularTotalPrecio()}");
        Console.WriteLine();

      









    } 











}
