using System;
namespace Exam
{
    public class Celular : Dispositivo, OrdenB
    {
        public Celular(int Imei, string Marca, string Modelo, string SistemaO): base (Imei, Marca, Modelo, SistemaO) { }
    
    public void ReparoD()
        {
            Console.WriteLine("Reparar celular");   
        }
    }
}
