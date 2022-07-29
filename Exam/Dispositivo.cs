using System;
namespace Exam
{
    public class Dispositivo
    {
        public int Imei;

        public string Marca;

        public string Modelo;

        public string SistemaO;

        public Dispositivo (int imei, string marca, string modelo, string sistemaO)
        {
            this.Imei = imei;
            this.Marca = marca;
            this.Modelo = modelo;
            this.SistemaO = sistemaO;
        }
    }
}
