using System;
namespace Exam
{
    public class Tableta:Dispositivo, OrdenB
    {
       public string País;

        public string Chip;
    
    public Tableta(string país, string chip, int Imei, string Marca, string Modelo, string SistemaO):base(Imei, Marca, Modelo, SistemaO)
        {
            this.País = país;
            this.Chip = chip;
        }


        public double ReparoD()
        {
            return 50.00;
        }
    }
}
