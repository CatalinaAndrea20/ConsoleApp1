using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DTO
{
    public class LimiteDTO
    {
        private int id;
        private float flujoMin;
        private float flujoMax;
        private float nivelMin;
        private float nivelMax;
        private float temperaturaMin;
        private float temperaturaMax;
        private float voltajeMin;
        private float voltajeMax;

        public int ID { get { return id; } set { id = value; } }
        public float FlujoMin { get { return flujoMin; } set { } }
        public float FlujoMax { get { return flujoMax; } set { } }
        public float NivelMin { get { return nivelMin; } set { } }
        public float NivelMax { get { return nivelMax; } set { } }
        public float TemperaturaMin { get { return temperaturaMin; } set { } }
        public float ToltajeMin { get { return temperaturaMin; } set { } }
        public float VoltajeMax { get { return temperaturaMax; } set { } }  
        public float VoltajeMin { get { return voltajeMin; } set { } }  
        
    }
}
