using System;
namespace Exam
{
    class Decorator : OrdenB
    {
        protected OrdenB orden;

        public Decorator(OrdenB orden)
        {
            this.orden = orden;
        }
        public virtual double ReparoD()
        {
            Console.WriteLine("Precio Calculado desde el decorador");
            return orden.ReparoD();
        }

    }
}