using System;
namespace Exam
{
    public class Cliente
    {
        public string NombreC { get; set; }

        public int Cedula { get; set; }

        public string Direccion;

        public string Dis;

        public Cliente(string Nombre, int Cedula, String Direccion , string dis)
        {

            this.NombreC = Nombre;
            this.Cedula = Cedula;
            this.Direccion = Direccion;
            this.Dis = dis;
        }


    }
}
